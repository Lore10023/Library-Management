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
    public partial class HistoryForm : UserControl
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";

        public HistoryForm()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "select studentid,bookid,boorowdate,returndate,duedate,status from borrowedbook";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    HistoryGridView.DataSource = dt;
                }
            }
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

