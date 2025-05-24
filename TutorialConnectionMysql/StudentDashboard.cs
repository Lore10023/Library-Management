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
    public partial class StudentDashboard : Form
    {
        String name1;
        public StudentDashboard(String name)
        {
            InitializeComponent();
            name1 = name;
            namelabel.Text = name1;
        }


        private void exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
        }

        private void Borrowbutton_Click(object sender, EventArgs e)
        {
            BorrowedBookscs borrowedBookscs = new BorrowedBookscs(name1);
            //this.Hide();
            borrowedBookscs.ShowDialog();
        }

        private void Historybutton_Click(object sender, EventArgs e)
        {
            HistoryStudent dashboard = new HistoryStudent(name1);
            dashboard.ShowDialog();
        }
    }
}
