using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TutorialConnectionMysql
{
    public partial class BorrowPopUp : Form
    {
        String name;
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        public BorrowPopUp(String title, String studname)
        {
            InitializeComponent();
            titlebox.Text = title;
            name= studname;
        }
        
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetBookId()
        {
            String title = titlebox.Text;
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "select bookId from book where title=@title";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    object result=cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int bookid = Convert.ToInt32(result);
                        return bookid;
                    }
                }
            }
            return -1;
        }

        private int GetStudId()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "select studentId from student where name=@name";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        int studid = Convert.ToInt32(result);
                        return studid;
                    }
                }
            }
            return -1;
        }

        private int ChangeQuantity(int BookId, MySqlConnection con)
        {
            string query2 = "select quantity from book where bookid=@BookID";
            using (MySqlCommand cmd = new MySqlCommand(query2, con))
            {
                cmd.Parameters.AddWithValue("@BookID", BookId);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int quantity = Convert.ToInt32(result);
                    quantity--;
                    return quantity;
                }
            }
            return -1;
        }
        private void DueDate()
        {
            DateTime date = DateTime.Today.Date;
            DateTime maximDate = date.AddMonths(3);
            DateTime student = dateTimePicker1.Value.Date;
            int BookId = GetBookId();
            if (BookId == -1)
            {
                MessageBox.Show("The book does not exists!");
            }
            int StudId = GetStudId();
            if (StudId == -1)
            {
                MessageBox.Show("The student does not exists!");
            }

            if (student > maximDate)
            {
                MessageBox.Show("Sorry but you have exceeded the limit!\nPlease try again.");
            }
            else {
                MessageBox.Show("Thank you for the loan!\nWe hope you enjoy the book.");
                using (MySqlConnection con = new MySqlConnection(connection))
                {
                    string query = "insert into borrowedbook (Studentid,bookid,boorowdate,duedate) values (@studID,@BookID,@BorrowDate,@DueDate)";
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BorrowDate", date.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@DueDate", student.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@BookID", BookId);
                        cmd.Parameters.AddWithValue("@studID", StudId);
                        cmd.ExecuteNonQuery();
                    }

                    int quantityChanged = ChangeQuantity(BookId, con);
                    string query2 = "update book set quantity = @quantityChanged where bookid=@BookID";
                    using (MySqlCommand cmd = new MySqlCommand(query2, con))
                    {
                        cmd.Parameters.AddWithValue("@quantityChanged", quantityChanged);
                        cmd.Parameters.AddWithValue("@BookID", BookId);
                        cmd.ExecuteNonQuery();
                    }
                    if (quantityChanged == 0)
                    {
                        string status = "not in stock";
                        string query3 = "update book set status = @status where bookid=@BookID";
                        using (MySqlCommand cmd = new MySqlCommand(query3, con))
                        {
                            cmd.Parameters.AddWithValue("@status", status);
                            cmd.Parameters.AddWithValue("@BookID", BookId);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                this.Close();
            }
        }

        private void borrowbutton_Click(object sender, EventArgs e)
        {
            DueDate();
        }
    }
}
