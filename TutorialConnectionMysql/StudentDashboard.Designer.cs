namespace TutorialConnectionMysql
{
    partial class StudentDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentDashboard));
            panel1 = new Panel();
            exitbutton = new Button();
            previousbutton = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            namelabel = new Label();
            label2 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            Borrowbutton = new Button();
            label3 = new Label();
            panel5 = new Panel();
            Historybutton = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(exitbutton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 35);
            panel1.TabIndex = 0;
            // 
            // exitbutton
            // 
            exitbutton.BackColor = Color.Transparent;
            exitbutton.Cursor = Cursors.Hand;
            exitbutton.FlatStyle = FlatStyle.Flat;
            exitbutton.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbutton.Location = new Point(1464, 0);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(36, 35);
            exitbutton.TabIndex = 1;
            exitbutton.Text = "X";
            exitbutton.UseVisualStyleBackColor = false;
            exitbutton.Click += exitbutton_Click;
            // 
            // previousbutton
            // 
            previousbutton.BackColor = Color.RosyBrown;
            previousbutton.Cursor = Cursors.Hand;
            previousbutton.FlatStyle = FlatStyle.Flat;
            previousbutton.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previousbutton.Location = new Point(0, 756);
            previousbutton.Name = "previousbutton";
            previousbutton.Size = new Size(93, 44);
            previousbutton.TabIndex = 3;
            previousbutton.Text = "Logout";
            previousbutton.UseVisualStyleBackColor = false;
            previousbutton.Click += logoutbutton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(namelabel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(106, 57);
            panel2.Name = "panel2";
            panel2.Size = new Size(1295, 278);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.wave;
            pictureBox1.Location = new Point(1046, 51);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 131);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            namelabel.ForeColor = Color.White;
            namelabel.Location = new Point(593, 112);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(134, 47);
            namelabel.TabIndex = 2;
            namelabel.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(360, 130);
            label2.Name = "label2";
            label2.Size = new Size(0, 52);
            label2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(360, 47);
            label1.Name = "label1";
            label1.Size = new Size(595, 52);
            label1.TabIndex = 0;
            label1.Text = "HELLO AND WELCOME BACK";
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Controls.Add(Borrowbutton);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(106, 384);
            panel3.Name = "panel3";
            panel3.Size = new Size(639, 366);
            panel3.TabIndex = 2;
            // 
            // Borrowbutton
            // 
            Borrowbutton.BackColor = Color.RosyBrown;
            Borrowbutton.Cursor = Cursors.Hand;
            Borrowbutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Borrowbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            Borrowbutton.FlatStyle = FlatStyle.Flat;
            Borrowbutton.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Borrowbutton.ForeColor = Color.White;
            Borrowbutton.Location = new Point(408, 236);
            Borrowbutton.Name = "Borrowbutton";
            Borrowbutton.Size = new Size(184, 48);
            Borrowbutton.TabIndex = 1;
            Borrowbutton.Text = "View Page";
            Borrowbutton.UseVisualStyleBackColor = false;
            Borrowbutton.Click += Borrowbutton_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(328, 93);
            label3.Name = "label3";
            label3.Size = new Size(284, 131);
            label3.TabIndex = 0;
            label3.Text = "Borrow Books Online";
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Controls.Add(Historybutton);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(762, 387);
            panel5.Name = "panel5";
            panel5.Size = new Size(639, 366);
            panel5.TabIndex = 4;
            // 
            // Historybutton
            // 
            Historybutton.BackColor = Color.RosyBrown;
            Historybutton.Cursor = Cursors.Hand;
            Historybutton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            Historybutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            Historybutton.FlatStyle = FlatStyle.Flat;
            Historybutton.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Historybutton.ForeColor = Color.White;
            Historybutton.Location = new Point(58, 233);
            Historybutton.Name = "Historybutton";
            Historybutton.Size = new Size(184, 48);
            Historybutton.TabIndex = 2;
            Historybutton.Text = "View Page";
            Historybutton.UseVisualStyleBackColor = false;
            Historybutton.Click += Historybutton_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Cambria", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 90);
            label4.Name = "label4";
            label4.Size = new Size(284, 131);
            label4.TabIndex = 2;
            label4.Text = "View Your History";
            // 
            // StudentDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 800);
            Controls.Add(previousbutton);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentDashboard";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button exitbutton;
        private Button previousbutton;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label namelabel;
        private Label label2;
        private Panel panel3;
        private Panel panel5;
        private Button Borrowbutton;
        private Label label3;
        private Button Historybutton;
        private Label label4;
    }
}