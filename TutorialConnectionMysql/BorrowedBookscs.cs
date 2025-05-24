using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
    public partial class BorrowedBookscs : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        String nameStud;
        public BorrowedBookscs(String name1)
        {
            InitializeComponent();
            nameStud = name1;
        }

        public void LoadBooksAvailable()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                if (comboBox1.Text == "All")
                {
                    LoadData2("bookid");
                }
                else if (comboBox1.Text == "Author")
                {
                    LoadData2("author");
                }
                else if (comboBox1.Text == "Title")
                {
                    LoadData2("title");
                }
                else if (comboBox1.Text == "Genre")
                {
                    LoadData2("genre");
                }
            }
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            //StudentDashboard dashboard = new StudentDashboard();
            this.Hide();
            //dashboard.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JustLoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "select title,author,genre,publicationyear,status from book where status='in library'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "select title,author,genre,publicationyear,status from book where status='in library'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                        btn.Text = "Borrow";
                        btn.Name = "btnBorrow";
                        btn.HeaderText = "Borrowed";
                        btn.UseColumnTextForButtonValue = true;
                        dataGridView1.Columns.Add(btn);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnBorrow") {
                var row = dataGridView1.Rows[e.RowIndex];

                string title = row.Cells["title"].Value.ToString();
                BorrowPopUp dashboard = new BorrowPopUp(title,nameStud);
                dashboard.ShowDialog();
            }
            JustLoadData();
        }

        private void LoadData2(String order)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = $"select title,author,genre,publicationyear,status from book where status='in library' order by {order}";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BorrowedBookscs_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBooksAvailable();
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            String SearchText = searchbar.Text;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    string query = "select title,author,genre,publicationyear,status from book where status='in library' and quantity>0 and "+
                        "(title like concat('%',@searchtext,'%') or author like concat('%',@searchtext,'%') or genre like concat('%',@searchtext,'%'))";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@searchtext", SearchText);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
