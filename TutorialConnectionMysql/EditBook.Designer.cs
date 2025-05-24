namespace TutorialConnectionMysql
{
    partial class EditBook
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
            label5 = new Label();
            bookID = new TextBox();
            titlebox = new TextBox();
            genbox = new TextBox();
            authorbox = new TextBox();
            yearbox = new TextBox();
            quantitybox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            editbtn = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Font = new Font("Cambria", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 20);
            label5.Name = "label5";
            label5.Size = new Size(497, 101);
            label5.TabIndex = 4;
            label5.Text = "Please fill the label with the book ID";
            // 
            // bookID
            // 
            bookID.Location = new Point(177, 75);
            bookID.Name = "bookID";
            bookID.Size = new Size(53, 27);
            bookID.TabIndex = 5;
            // 
            // titlebox
            // 
            titlebox.Location = new Point(206, 157);
            titlebox.Name = "titlebox";
            titlebox.Size = new Size(322, 27);
            titlebox.TabIndex = 6;
            // 
            // genbox
            // 
            genbox.Location = new Point(206, 312);
            genbox.Name = "genbox";
            genbox.Size = new Size(322, 27);
            genbox.TabIndex = 7;
            // 
            // authorbox
            // 
            authorbox.Location = new Point(206, 233);
            authorbox.Name = "authorbox";
            authorbox.Size = new Size(322, 27);
            authorbox.TabIndex = 8;
            // 
            // yearbox
            // 
            yearbox.Location = new Point(206, 390);
            yearbox.Name = "yearbox";
            yearbox.Size = new Size(322, 27);
            yearbox.TabIndex = 9;
            // 
            // quantitybox
            // 
            quantitybox.Location = new Point(206, 468);
            quantitybox.Name = "quantitybox";
            quantitybox.Size = new Size(322, 27);
            quantitybox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(117, 157);
            label1.Name = "label1";
            label1.Size = new Size(57, 27);
            label1.TabIndex = 11;
            label1.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 233);
            label2.Name = "label2";
            label2.Size = new Size(82, 27);
            label2.TabIndex = 12;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(103, 312);
            label3.Name = "label3";
            label3.Size = new Size(71, 27);
            label3.TabIndex = 13;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(76, 465);
            label4.Name = "label4";
            label4.Size = new Size(98, 27);
            label4.TabIndex = 14;
            label4.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(29, 390);
            label6.Name = "label6";
            label6.Size = new Size(171, 27);
            label6.TabIndex = 15;
            label6.Text = "Publication Year";
            // 
            // editbtn
            // 
            editbtn.BackColor = Color.White;
            editbtn.Cursor = Cursors.Hand;
            editbtn.FlatStyle = FlatStyle.Popup;
            editbtn.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            editbtn.ForeColor = Color.RosyBrown;
            editbtn.Location = new Point(246, 526);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(202, 71);
            editbtn.TabIndex = 16;
            editbtn.Text = "Edit Book";
            editbtn.UseVisualStyleBackColor = false;
            editbtn.Click += editbtn_Click;
            // 
            // EditBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(540, 609);
            Controls.Add(editbtn);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(quantitybox);
            Controls.Add(yearbox);
            Controls.Add(authorbox);
            Controls.Add(genbox);
            Controls.Add(titlebox);
            Controls.Add(bookID);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditBook";
            Text = "EditBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox bookID;
        private TextBox titlebox;
        private TextBox genbox;
        private TextBox authorbox;
        private TextBox yearbox;
        private TextBox quantitybox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Button editbtn;
    }
}