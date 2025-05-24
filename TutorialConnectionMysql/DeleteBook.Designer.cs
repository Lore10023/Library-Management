namespace TutorialConnectionMysql
{
    partial class DeleteBook
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
            deletebutton = new Button();
            BookId = new Label();
            bookIdtextBox = new TextBox();
            SuspendLayout();
            // 
            // deletebutton
            // 
            deletebutton.BackColor = SystemColors.ControlDarkDark;
            deletebutton.FlatStyle = FlatStyle.Popup;
            deletebutton.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebutton.ForeColor = Color.White;
            deletebutton.Location = new Point(63, 270);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(156, 63);
            deletebutton.TabIndex = 0;
            deletebutton.Text = "DELETE";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += btnDelete_Click;
            // 
            // BookId
            // 
            BookId.AutoSize = true;
            BookId.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BookId.Location = new Point(77, 108);
            BookId.Name = "BookId";
            BookId.Size = new Size(68, 23);
            BookId.TabIndex = 1;
            BookId.Text = "BookId";
            // 
            // bookIdtextBox
            // 
            bookIdtextBox.Location = new Point(77, 163);
            bookIdtextBox.Name = "bookIdtextBox";
            bookIdtextBox.Size = new Size(125, 27);
            bookIdtextBox.TabIndex = 2;
            // 
            // DeleteBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(291, 370);
            Controls.Add(bookIdtextBox);
            Controls.Add(BookId);
            Controls.Add(deletebutton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteBook";
            Text = "DeleteBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deletebutton;
        private Label BookId;
        private TextBox bookIdtextBox;
    }
}