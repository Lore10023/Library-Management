using System.Windows.Forms;

namespace TutorialConnectionMysql
{
    partial class AdminDasboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            title2 = new Label();
            namelabel = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            logoutadmin = new Button();
            historyadmin = new Button();
            studentadmin = new Button();
            adminhome = new Button();
            panel2 = new Panel();
            exitbutton = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            studentsForm1 = new StudentsForm();
            historyForm1 = new HistoryForm();
            mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            homeForm11 = new HomeForm1();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Location = new Point(332, 40);
            title.Name = "title";
            title.Size = new Size(0, 20);
            title.TabIndex = 4;
            // 
            // title2
            // 
            title2.BackColor = Color.Transparent;
            title2.Font = new Font("Cambria", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            title2.ForeColor = Color.White;
            title2.Location = new Point(0, 105);
            title2.Name = "title2";
            title2.Size = new Size(260, 81);
            title2.TabIndex = 5;
            title2.Text = "HELLO AND WELCOME BACK";
            // 
            // namelabel
            // 
            namelabel.Font = new Font("Cambria", 18F, FontStyle.Italic, GraphicsUnit.Point, 0);
            namelabel.ForeColor = Color.White;
            namelabel.Location = new Point(3, 189);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(320, 40);
            namelabel.TabIndex = 6;
            namelabel.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wave;
            pictureBox1.Location = new Point(232, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 135);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(logoutadmin);
            panel1.Controls.Add(historyadmin);
            panel1.Controls.Add(studentadmin);
            panel1.Controls.Add(adminhome);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(title2);
            panel1.Controls.Add(namelabel);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 800);
            panel1.TabIndex = 8;
            // 
            // logoutadmin
            // 
            logoutadmin.Cursor = Cursors.Hand;
            logoutadmin.FlatStyle = FlatStyle.Flat;
            logoutadmin.Font = new Font("Cambria", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutadmin.ForeColor = Color.White;
            logoutadmin.Location = new Point(13, 743);
            logoutadmin.Name = "logoutadmin";
            logoutadmin.Size = new Size(128, 45);
            logoutadmin.TabIndex = 11;
            logoutadmin.Text = "Logout";
            logoutadmin.UseVisualStyleBackColor = true;
            logoutadmin.Click += LogOutBtn;
            // 
            // historyadmin
            // 
            historyadmin.Cursor = Cursors.Hand;
            historyadmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            historyadmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            historyadmin.FlatStyle = FlatStyle.Flat;
            historyadmin.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historyadmin.ForeColor = Color.White;
            historyadmin.Location = new Point(13, 580);
            historyadmin.Name = "historyadmin";
            historyadmin.Size = new Size(320, 65);
            historyadmin.TabIndex = 10;
            historyadmin.Text = "History";
            historyadmin.UseVisualStyleBackColor = true;
            historyadmin.Click += historyadmin_Click;
            // 
            // studentadmin
            // 
            studentadmin.Cursor = Cursors.Hand;
            studentadmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            studentadmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            studentadmin.FlatStyle = FlatStyle.Flat;
            studentadmin.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentadmin.ForeColor = Color.White;
            studentadmin.Location = new Point(13, 459);
            studentadmin.Name = "studentadmin";
            studentadmin.Size = new Size(320, 65);
            studentadmin.TabIndex = 9;
            studentadmin.Text = "Students";
            studentadmin.UseVisualStyleBackColor = true;
            studentadmin.Click += studentadmin_Click;
            // 
            // adminhome
            // 
            adminhome.Cursor = Cursors.Hand;
            adminhome.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            adminhome.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            adminhome.FlatStyle = FlatStyle.Flat;
            adminhome.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adminhome.ForeColor = Color.White;
            adminhome.Location = new Point(13, 339);
            adminhome.Name = "adminhome";
            adminhome.Size = new Size(320, 65);
            adminhome.TabIndex = 8;
            adminhome.Text = "Home";
            adminhome.UseVisualStyleBackColor = true;
            adminhome.Click += adminhome_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(exitbutton);
            panel2.Location = new Point(345, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1155, 30);
            panel2.TabIndex = 9;
            // 
            // exitbutton
            // 
            exitbutton.Cursor = Cursors.Hand;
            exitbutton.FlatStyle = FlatStyle.Flat;
            exitbutton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            exitbutton.Location = new Point(1450, 0);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(50, 30);
            exitbutton.TabIndex = 0;
            exitbutton.Text = "x";
            exitbutton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(homeForm11);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(studentsForm1);
            panel3.Controls.Add(historyForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(345, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1155, 800);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1155, 31);
            panel4.TabIndex = 1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1116, 1);
            button1.Name = "button1";
            button1.Size = new Size(39, 29);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            button1.Click += exitBtn;
            // 
            // studentsForm1
            // 
            studentsForm1.Dock = DockStyle.Fill;
            studentsForm1.Location = new Point(0, 0);
            studentsForm1.Name = "studentsForm1";
            studentsForm1.Size = new Size(1155, 800);
            studentsForm1.TabIndex = 2;
            // 
            // historyForm1
            // 
            historyForm1.BackColor = SystemColors.Control;
            historyForm1.Dock = DockStyle.Fill;
            historyForm1.Location = new Point(0, 0);
            historyForm1.Name = "historyForm1";
            historyForm1.Size = new Size(1155, 800);
            historyForm1.TabIndex = 3;
            // 
            // mySqlDataAdapter1
            // 
            mySqlDataAdapter1.DeleteCommand = null;
            mySqlDataAdapter1.InsertCommand = null;
            mySqlDataAdapter1.SelectCommand = null;
            mySqlDataAdapter1.UpdateCommand = null;
            // 
            // homeForm11
            // 
            homeForm11.Dock = DockStyle.Fill;
            homeForm11.Location = new Point(0, 31);
            homeForm11.Name = "homeForm11";
            homeForm11.Size = new Size(1155, 769);
            homeForm11.TabIndex = 4;
            // 
            // AdminDasboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 800);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(title);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDasboard";
            Text = "AdminDasboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label title;
        private Label title2;
        private Label namelabel;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button adminhome;
        private Button logoutadmin;
        private Button historyadmin;
        private Button studentadmin;
        private Panel panel2;
        private Button exitbutton;
        private Panel panel3;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private HomeForm1 homeForm1;
        private Panel panel4;
        private Button button1;
        private StudentsForm studentsForm1;
        private HistoryForm historyForm1;
        private HomeForm1 homeForm11;
    }
}