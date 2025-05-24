namespace TutorialConnectionMysql
{
    partial class DeleteStudent
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
            BookId = new Label();
            studenttextBox = new TextBox();
            deletebutton = new Button();
            SuspendLayout();
            // 
            // BookId
            // 
            BookId.AutoSize = true;
            BookId.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            BookId.Location = new Point(97, 95);
            BookId.Name = "BookId";
            BookId.Size = new Size(91, 23);
            BookId.TabIndex = 2;
            BookId.Text = "StudentId";
            // 
            // studenttextBox
            // 
            studenttextBox.Location = new Point(82, 156);
            studenttextBox.Name = "studenttextBox";
            studenttextBox.Size = new Size(125, 27);
            studenttextBox.TabIndex = 3;
            // 
            // deletebutton
            // 
            deletebutton.BackColor = SystemColors.ControlDarkDark;
            deletebutton.FlatStyle = FlatStyle.Popup;
            deletebutton.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deletebutton.ForeColor = Color.White;
            deletebutton.Location = new Point(65, 250);
            deletebutton.Name = "deletebutton";
            deletebutton.Size = new Size(156, 63);
            deletebutton.TabIndex = 4;
            deletebutton.Text = "DELETE";
            deletebutton.UseVisualStyleBackColor = false;
            deletebutton.Click += deletebutton_Click;
            // 
            // DeleteStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(291, 370);
            Controls.Add(deletebutton);
            Controls.Add(studenttextBox);
            Controls.Add(BookId);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteStudent";
            Text = "DeleteStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BookId;
        private TextBox studenttextBox;
        private Button deletebutton;
    }
}