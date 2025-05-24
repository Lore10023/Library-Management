using MySql.Data.MySqlClient;
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
    public partial class HistoryStudent : Form
    {
        private string connection = "server=localhost;database=librarymanagement;uid=root;pwd=programITnou24;";

        string name_stud;
        public HistoryStudent(String name)
        {
            InitializeComponent();
            name_stud = name;
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private int GetIdStud(MySqlConnection conn)
        {
            string query = "select studentid from student where name=@name_stud";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name_stud", name_stud);
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    int StudID = Convert.ToInt32(result);
                    return StudID;
                }
            }
            return -1;
        }

        private void JustLoadDataGrid1()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "select b.bookid,b2.title,b2.author,b.BoorowDate,b.DueDate from borrowedbook b join book b2 on b2.bookid=b.bookid where studentid=@StudID and returndate is null";
                int StudID = GetIdStud(conn);
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudID", StudID);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }
        private void LoadDataGrid1()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "select b.bookid,b2.title,b2.author,b.BoorowDate,b.DueDate from borrowedbook b join book b2 on b2.bookid=b.bookid where studentid=@StudID and returndate is null";
                int StudID = GetIdStud(conn);
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudID", StudID);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Text = "Return";
                    btn.Name = "btnReturn";
                    btn.HeaderText = "Returned";
                    btn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btn);
                }
            }
        }

        private void PrintInData2()
        {
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                conn.Open();
                string query = "select b2.title,b2.author,b.BoorowDate,b.returndate,b.DueDate,b.status from borrowedbook b join book b2 on b2.bookid=b.bookid where studentid=@StudID and returndate is not null";
                int StudID = GetIdStud(conn);
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StudID", StudID);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView2.DataSource = dt;
                }
            }
        }

        private void UpdateBorrowedBook(MySqlConnection conn, string status,DateTime returndate,int bookid)
        {
            string query = "update borrowedbook b"+
                " join(select id from borrowedbook where bookid=@bookid and returndate is null limit 1) "+
                "as sub on b.id=sub.id set b.status=@status, b.returndate=@returndate";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@returndate", returndate);
                cmd.Parameters.AddWithValue("@bookid", bookid);

                cmd.ExecuteNonQuery();
            }
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
                    quantity++;
                    return quantity;
                }
            }
            return -1;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int bookid;
            string status;
            DateTime borrowdate;
            DateTime duedate;
            DateTime current_date;
            if (e.RowIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "btnReturn")
            {
                var row = dataGridView1.Rows[e.RowIndex];
                borrowdate = Convert.ToDateTime(row.Cells["boorowdate"].Value);
                duedate = Convert.ToDateTime(row.Cells["duedate"].Value);
                current_date = DateTime.Today.Date;
                bookid = Convert.ToInt32(row.Cells["bookid"].Value);
                if (current_date>=borrowdate && current_date <= duedate)
                {
                    status = "in time";
                }
                else
                {
                    status = "not in time";
                }

                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    conn.Open();
                    UpdateBorrowedBook(conn, status, current_date, bookid);
                    int quantity=ChangeQuantity(bookid, conn);
                    string query2 = "update book set quantity = @quantityChanged where bookid=@BookID";
                    using (MySqlCommand cmd = new MySqlCommand(query2, conn))
                    {
                        cmd.Parameters.AddWithValue("@quantityChanged", quantity);
                        cmd.Parameters.AddWithValue("@BookID", bookid);
                        cmd.ExecuteNonQuery();
                    }
                    if (quantity != 0)
                    {
                        string status1 = "in library";
                        string query3 = "update book set status = @status where bookid=@BookID";
                        using (MySqlCommand cmd = new MySqlCommand(query3, conn))
                        {
                            cmd.Parameters.AddWithValue("@status", status1);
                            cmd.Parameters.AddWithValue("@BookID", bookid);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            PrintInData2();
            JustLoadDataGrid1();
            
        }

        private void HistoryStudent_Load(object sender, EventArgs e)
        {
            LoadDataGrid1();
            PrintInData2();
        }
    }
}
