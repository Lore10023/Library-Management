using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace TutorialConnectionMysql
{
    public partial class AddBook : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        private HomeForm1 homedashboard;

        //delegate pentru progres
        public delegate void ProgessEveniment(string message);

        //eveniment de progres
        public event ProgessEveniment Progress; 
        public AddBook(HomeForm1 home)
        {
            InitializeComponent();
            homedashboard = home;
        }

        public void btnAdding_Click(object sender, EventArgs e)
        {
            string title = titlutextbox.Text;
            string author = autortextBox.Text;
            string genre = gentextBox.Text;
            string input_year=yeartextBox.Text;
            string input_quantity=quantitytextBox.Text;
            int quantity=0;
            int public_year=0;

            bool isValid = true;
            bool verification = true;

            //validate the fields
            if(string.IsNullOrEmpty(title) || string.IsNullOrEmpty(author) || string.IsNullOrEmpty(genre) || string.IsNullOrEmpty(input_year) || string.IsNullOrEmpty(input_quantity))
            {
                MessageBox.Show("You need to complete all the fields!");
                isValid = false;
                verification = false;
            }

            //validate the year and quantity if it is a valid number
            if (isValid==true && !int.TryParse(input_year, out public_year))
            {
                MessageBox.Show("Publication year must be a number.");
                verification = false;
            }

            if (isValid == true && !int.TryParse(input_quantity, out quantity))
            {
                MessageBox.Show("Quantity must be a number.");
                verification = false;
            }

            //validate the quantity to not be less than 1
            if (isValid == true && quantity < 1)
            {
                MessageBox.Show("Quantity must be at least 1.");
                verification=false;
            }

            if (verification == true)
            {
                ProgressNotification("Connecting to database...");

                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    ProgressNotification("Inserting book into database...");

                    string query = "insert into book (title,author,genre,publicationYear,quantity) values (@title,@author,@genre,@public_year,@quantity)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@genre", genre);
                    cmd.Parameters.AddWithValue("@public_year", public_year);
                    cmd.Parameters.AddWithValue("@quantity", quantity);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        ProgressNotification("Book added successfully!");
                        //MessageBox.Show("Book added succesfully!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Faild to add book!");
                    }

                }

                homedashboard.LoadData();
            }
        }

        public void ProgressNotification(string message) {
            Progress?.Invoke(message);
        }
    }
}
