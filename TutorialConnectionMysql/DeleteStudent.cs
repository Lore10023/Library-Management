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
    public partial class DeleteStudent : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        private StudentsForm studentsForm;
        public DeleteStudent(StudentsForm stdform)
        {
            InitializeComponent();
            studentsForm = stdform;
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            string input_id = studenttextBox.Text;
            int Id = 0;
            bool isValid = true;
            bool verification = true;
            if (string.IsNullOrEmpty(input_id))
            {
                MessageBox.Show("fill in the box with the student ID you want to delete");
                isValid = false;
                verification = false;
            }
            if (isValid==true && !int.TryParse(input_id, out Id))
            {
                MessageBox.Show("Id must be a number.");
                verification = false;
            }

            if (verification == true)
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string query = "delete from student where StudentId=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@id", Id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student deleted succesfully!");
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Faild to delete the student!");
                    }
                }
                studentsForm.LoadDataTrue();
            }

        }
    }
}
