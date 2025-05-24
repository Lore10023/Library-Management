using MySql.Data.MySqlClient;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TutorialConnectionMysql
{
    public partial class Form1 : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;

            bool isvalid = true;

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                isvalid = false;
            }
            else
            {
                isvalid = true;
            }


            if (isvalid == false)
            {
                MessageBox.Show("You need to complete all the fields with valid data.");
            }


            if(isvalid==true && password.Length < 3)
            {
                MessageBox.Show("Password must be at least 3 characters long.");
            }
            if(isvalid==true && !IsValidEmail(email))
            {
                MessageBox.Show("Invalid email format.");
            }


            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();

                if (admin.Checked)
                {
                    string adminQuery = "Select * From adminuser WHERE Username=@name AND PasswordAdmin=@password AND Email=@email";
                    using (MySqlCommand admincmd = new MySqlCommand(adminQuery, conn))
                    {
                        admincmd.Parameters.AddWithValue("@name", name);
                        admincmd.Parameters.AddWithValue("@password", password);
                        admincmd.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader adminreader = admincmd.ExecuteReader())
                        {
                            if (!adminreader.HasRows)
                            {
                                MessageBox.Show("Username or Password is invalid!");
                            }
                            else
                            {
                                AdminDasboard dasboard = new AdminDasboard(name);
                                this.Hide();
                                dasboard.Show();
                            }
                        }
                    }
                }
                else if (Stud.Checked)
                {
                    string stdExist = "Select * from student where Name=@name and Email=@email and PasswordStudent=@password";
                    using (MySqlCommand admincmd = new MySqlCommand(stdExist, conn))
                    {
                        admincmd.Parameters.AddWithValue("@name", name);
                        admincmd.Parameters.AddWithValue("@password", password);
                        admincmd.Parameters.AddWithValue("@email", email);

                        using (MySqlDataReader adminreader = admincmd.ExecuteReader())
                        {
                            if (!adminreader.HasRows)
                            {
                                MessageBox.Show("Username or Password is invalid!");
                            }
                            else
                            {
                                StudentDashboard dashboard = new StudentDashboard(name);
                                this.Hide();
                                dashboard.Show();
                            }
                        }
                    }
                }
                else if (newStud.Checked) {
                    MessageBox.Show("You need an approvement from the librarian!\nPlease try again after you receive it:)");
                    AddStudents(conn, name, password, email);
                }
                else
                {
                    MessageBox.Show("You need to check one of the checkbox!");
                }
                
            }
        }


        static void AddStudents(MySqlConnection con, string name, string password, string email)
        {
            string query = "Insert into student (name,email,passwordstudent) values (@name,@email,@password)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();
        }   

        private void UseSystemPasswordChar_CheckedChange(object sender, EventArgs e)
        {
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
        
        // Simple email pattern checker
        static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }
    }

   
    }
