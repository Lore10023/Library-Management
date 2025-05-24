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
    public partial class StudentsForm : UserControl
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        public StudentsForm()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string query = "select StudentId,Name,Email from student where IsApproved=FALSE";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        ApproveStudGridView.DataSource = dt;
                        ApproveStudGridView.Refresh();
                    }

                    TransferIdToList(conn);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor: " + ex.Message);
            }
        }

        public void LoadDataTrue()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();

                    string query = "select StudentId,Name,Email from student where IsApproved=TRUE";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        AllStudGridView.DataSource = dt;
                        AllStudGridView.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroor: " + ex.Message);
            }
        }

        private void TransferIdToList(MySqlConnection conn)
        {
            string query = "select StudentId from student where isapproved = false";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    listBoxStud.Items.Clear();
                    while (reader.Read())
                    {
                        int studID = reader.GetInt32("StudentId");
                        listBoxStud.Items.Add(studID);
                    }
                }
            }
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDataTrue();
        }

        private void ApproveSelectedStud()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                List<int> selectedStud = new List<int>();

                foreach (var item in listBoxStud.SelectedItems)
                {
                    selectedStud.Add(Convert.ToInt32(item));
                }

                if (selectedStud.Count > 0)
                {
                    string query = "update student set isapproved=true where StudentId IN (" + string.Join(",", selectedStud) + ")";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show($"{rowsAffected} students approved successfully.");

                    }
                }
                TransferIdToList(conn);
            }
        }

        private void ApproveButton_Click(object sender, EventArgs e)
        {
            ApproveSelectedStud();
            LoadData();
            LoadDataTrue();
        }

        private void deleteStud_Click(object sender, EventArgs e)
        {
            DeleteStudent student = new DeleteStudent(this);
            student.ShowDialog();
        }
    }
}
