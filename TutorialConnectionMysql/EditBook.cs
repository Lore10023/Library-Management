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
    public partial class EditBook : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";

        private HomeForm1 homedashboard;

        public delegate void ProgessEveniment(string message);

        //eveniment de progres
        public event ProgessEveniment Progress;
        public EditBook(HomeForm1 home)
        {
            InitializeComponent();
            homedashboard = home;
        }


        private void editbtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                string bookId = bookID.Text.Trim();
                if (string.IsNullOrEmpty(bookId))
                {
                    MessageBox.Show("Please enter a valid Book ID.");
                    return;
                }

                List<string> updates = new List<string>();
                if (!string.IsNullOrEmpty(titlebox.Text))
                    updates.Add($"title = @title");
                if (!string.IsNullOrEmpty(authorbox.Text))
                    updates.Add($"author = @author");
                if (!string.IsNullOrEmpty(genbox.Text))
                    updates.Add($"genre = @genre");
                if (!string.IsNullOrEmpty(yearbox.Text))
                    updates.Add($"publicationyear = @publicationyear");
                if (!string.IsNullOrEmpty(quantitybox.Text))
                    updates.Add($"quantity = @quantity");

                if (updates.Count == 0)
                {
                    MessageBox.Show("No fields to update.");
                    return;
                }

                string updateQuery = $"UPDATE book SET {string.Join(", ", updates)} WHERE bookid = @id";

                using (MySqlCommand cmd = new MySqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@id", bookId);
                    if (updates.Contains("title = @title"))
                        cmd.Parameters.AddWithValue("@title", titlebox.Text.Trim());
                    if (updates.Contains("author = @author"))
                        cmd.Parameters.AddWithValue("@author", authorbox.Text.Trim());
                    if (updates.Contains("genre = @genre"))
                        cmd.Parameters.AddWithValue("@genre", genbox.Text.Trim());
                    if (updates.Contains("publicationyear = @publicationyear"))
                        cmd.Parameters.AddWithValue("@publicationyear", yearbox.Text.Trim());
                    if (updates.Contains("quantity = @quantity"))
                        cmd.Parameters.AddWithValue("@quantity", quantitybox.Text.Trim());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                        ProgressNotification("Book information updated successfully!");
                    else
                        ProgressNotification("Book ID not found or no changes made.");
                }
            }
            homedashboard.LoadData();
            this.Hide();
        }

        public void ProgressNotification(string message)
        {
            Progress?.Invoke(message);
        }
    }
}
