using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialConnectionMysql
{
    public partial class SearchBook : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        public SearchBook()
        {
            InitializeComponent();
        }

        private void search_Button(object sender, EventArgs e)
        {
            string title = titletextBox.Text;
            string author = autortextBox.Text;
            string genre = gentextBox.Text;

            int count = 0;

            if(string.IsNullOrEmpty(title) && string.IsNullOrEmpty(author) && string.IsNullOrEmpty(genre))
            {
                MessageBox.Show("You need to complete one of the fields!");
            }

            //validate if are more than one fields completed
            if (!string.IsNullOrEmpty(title)) count++;
            if (!string.IsNullOrEmpty(author)) count++;
            if (!string.IsNullOrEmpty(genre)) count++;
            if (count != 1) {
                MessageBox.Show("Please complete only one field!");
            }

            using (MySqlConnection conn = new MySqlConnection(connection)) { 
                conn.Open();

                if (!string.IsNullOrWhiteSpace(title))
                {
                    string query = "select * from book where title=@title";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter2.Fill(dt);
                    dataGridView1.DataSource = dt;
                }else if (!string.IsNullOrWhiteSpace(author))
                {
                    string query = "select * from book where author=@author";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@author", author);
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter2.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else
                {
                    string query = "select * from book where genre=@genre";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    //MySqlDataReader reader = cmd.ExecuteReader();
                    MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter2.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
