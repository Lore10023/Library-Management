namespace TutorialConnectionMysql
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            checkBox1 = new CheckBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            panel1 = new Panel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            logintext = new Label();
            admin = new RadioButton();
            Stud = new RadioButton();
            newStud = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(649, 552);
            button1.Name = "button1";
            button1.Size = new Size(466, 77);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnLogin_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(857, 490);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += UseSystemPasswordChar_CheckedChange;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(649, 302);
            label1.Name = "label1";
            label1.Size = new Size(120, 27);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(813, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(775, 305);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "name1 name2 ";
            textBox1.Size = new Size(340, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(857, 349);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.GrayText;
            label3.Location = new Point(649, 409);
            label3.Name = "label3";
            label3.Size = new Size(114, 27);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Location = new Point(775, 409);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PasswordChar = '*';
            textBox3.PlaceholderText = "******";
            textBox3.Size = new Size(340, 27);
            textBox3.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Picture3;
            pictureBox2.Location = new Point(787, 454);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 81);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.GrayText;
            label4.Location = new Point(723, 218);
            label4.Name = "label4";
            label4.Size = new Size(317, 36);
            label4.TabIndex = 10;
            label4.Text = "Login to Your Account";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.GrayText;
            label5.Location = new Point(649, 363);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 11;
            label5.Text = "Email";
            // 
            // textBox2
            // 
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Location = new Point(775, 363);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "liliana@....";
            textBox2.Size = new Size(340, 27);
            textBox2.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(logintext);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 696);
            panel1.TabIndex = 13;
            // 
            // label8
            // 
            label8.BackColor = Color.Gray;
            label8.Font = new Font("Cambria", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(3, 560);
            label8.Name = "label8";
            label8.Size = new Size(566, 124);
            label8.TabIndex = 3;
            label8.Text = resources.GetString("label8.Text");
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 320);
            label7.Name = "label7";
            label7.Size = new Size(455, 52);
            label7.TabIndex = 2;
            label7.Text = "to become part of our";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(106, 372);
            label6.Name = "label6";
            label6.Size = new Size(308, 52);
            label6.TabIndex = 1;
            label6.Text = "book universe";
            // 
            // logintext
            // 
            logintext.AutoSize = true;
            logintext.BackColor = Color.Transparent;
            logintext.Font = new Font("Cambria", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logintext.ForeColor = Color.White;
            logintext.Location = new Point(106, 275);
            logintext.Name = "logintext";
            logintext.Size = new Size(271, 52);
            logintext.TabIndex = 0;
            logintext.Text = "Fill the form";
            // 
            // admin
            // 
            admin.AutoSize = true;
            admin.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            admin.Location = new Point(723, 188);
            admin.Name = "admin";
            admin.Size = new Size(70, 21);
            admin.TabIndex = 14;
            admin.TabStop = true;
            admin.Text = "Admin";
            admin.UseVisualStyleBackColor = true;
            // 
            // Stud
            // 
            Stud.AutoSize = true;
            Stud.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Stud.Location = new Point(839, 188);
            Stud.Name = "Stud";
            Stud.Size = new Size(77, 21);
            Stud.TabIndex = 15;
            Stud.TabStop = true;
            Stud.Text = "Student";
            Stud.UseVisualStyleBackColor = true;
            // 
            // newStud
            // 
            newStud.AutoSize = true;
            newStud.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            newStud.Location = new Point(954, 188);
            newStud.Name = "newStud";
            newStud.Size = new Size(109, 21);
            newStud.TabIndex = 16;
            newStud.TabStop = true;
            newStud.Text = "New Student";
            newStud.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1167, 695);
            Controls.Add(newStud);
            Controls.Add(Stud);
            Controls.Add(admin);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox checkBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Panel panel1;
        private Label label6;
        private Label logintext;
        private Label label7;
        private Label label8;
        private RadioButton admin;
        private RadioButton Stud;
        private RadioButton newStud;
    }
}
