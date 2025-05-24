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
    public partial class AdminDasboard : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";
        public AdminDasboard(string username)
        {
            InitializeComponent();
            namelabel.Text = username;
        }
        private void LogOutBtn(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void exitBtn(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adminhome_Click(object sender, EventArgs e)
        {
            homeForm11.Visible = true;
            studentsForm1.Visible = false;
            historyForm1.Visible = false;
        }

        private void studentadmin_Click(object sender, EventArgs e)
        {
            homeForm11.Visible = false;
            studentsForm1.Visible = true;
            historyForm1.Visible = false;
        }

        private void historyadmin_Click(object sender, EventArgs e)
        {
            homeForm11.Visible = false;
            studentsForm1.Visible = false;
            historyForm1.Visible = true;
        }
    }
}
