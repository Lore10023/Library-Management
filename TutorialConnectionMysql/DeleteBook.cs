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
    public partial class DeleteBook : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        private HomeForm1 homedashboard;

        public delegate void ProgessEveniment(string message);

        //eveniment de progres
        public event ProgessEveniment Progress;
        public DeleteBook(HomeForm1 home)
        {
            InitializeComponent();
            homedashboard = home;
        }

        private void btnDelete_Click(object sender, EventArgs e) { 

            string input_id=bookIdtextBox.Text;
            int Id = 0;
            bool isValid = true;
            bool verification = true;
            ProgressNotification("Connecting to database...");
            if (string.IsNullOrEmpty(input_id))
            {
                MessageBox.Show("fill in the box with the book ID you want to delete");
                isValid = false;
                verification = false;
            }
            if(isValid==true && !int.TryParse(input_id, out Id)){
                MessageBox.Show("Id must be a number.");
                verification = false;
            }

            if (verification == true)
            {
                ProgressNotification("Deleting book into database...");
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string query = "delete from book where bookId=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", Id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ProgressNotification("Book deleted succesfully!");
                        //MessageBox.Show("Book deleted succesfully!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Faild to delete the book!");
                    }
                }
                homedashboard.LoadData();
            }
            
        }

        public void ProgressNotification(string message)
        {
            Progress?.Invoke(message);
        }
    }
}
