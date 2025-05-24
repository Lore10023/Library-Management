namespace TutorialConnectionMysql
{
    partial class BorrowPopUp
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
            borrowbutton = new Button();
            cancelbtn = new Button();
            label1 = new Label();
            titlebox = new Label();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // borrowbutton
            // 
            borrowbutton.BackColor = Color.RosyBrown;
            borrowbutton.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            borrowbutton.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            borrowbutton.FlatStyle = FlatStyle.Flat;
            borrowbutton.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            borrowbutton.ForeColor = Color.White;
            borrowbutton.Location = new Point(252, 484);
            borrowbutton.Name = "borrowbutton";
            borrowbutton.Size = new Size(239, 75);
            borrowbutton.TabIndex = 0;
            borrowbutton.Text = "Borrow";
            borrowbutton.UseVisualStyleBackColor = false;
            borrowbutton.Click += borrowbutton_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.BackColor = Color.RosyBrown;
            cancelbtn.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            cancelbtn.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelbtn.ForeColor = Color.White;
            cancelbtn.Location = new Point(7, 484);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(239, 75);
            cancelbtn.TabIndex = 2;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(503, 93);
            label1.TabIndex = 3;
            label1.Text = "Are you sure you want to borrow this book?";
            // 
            // titlebox
            // 
            titlebox.AutoSize = true;
            titlebox.BackColor = Color.White;
            titlebox.Font = new Font("Cambria", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titlebox.Location = new Point(16, 54);
            titlebox.Name = "titlebox";
            titlebox.Size = new Size(107, 40);
            titlebox.TabIndex = 4;
            titlebox.Text = "label2";
            titlebox.TextAlign = ContentAlignment.TopCenter;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(213, 191);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(252, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(30, 291);
            label2.Name = "label2";
            label2.Size = new Size(176, 23);
            label2.TabIndex = 6;
            label2.Text = "Select the due date:";
            // 
            // label3
            // 
            label3.BackColor = Color.White;
            label3.Font = new Font("Cambria", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(16, 236);
            label3.Name = "label3";
            label3.Size = new Size(218, 41);
            label3.TabIndex = 7;
            label3.Text = "The maximum period for a book is at most three months!";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(titlebox);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(12, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 364);
            panel1.TabIndex = 8;
            // 
            // BorrowPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cancelbtn);
            Controls.Add(borrowbutton);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowPopUp";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button borrowbutton;
        private Button cancelbtn;
        private Label label1;
        private Label titlebox;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Panel panel1;
    }
}