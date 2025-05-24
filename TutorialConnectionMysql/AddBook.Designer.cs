namespace TutorialConnectionMysql
{
    partial class AddBook
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
            titlu = new Label();
            autor = new Label();
            gen = new Label();
            year = new Label();
            quantity = new Label();
            titlutextbox = new TextBox();
            gentextBox = new TextBox();
            yeartextBox = new TextBox();
            autortextBox = new TextBox();
            quantitytextBox = new TextBox();
            add = new Button();
            SuspendLayout();
            // 
            // titlu
            // 
            titlu.AutoSize = true;
            titlu.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            titlu.Location = new Point(26, 79);
            titlu.Name = "titlu";
            titlu.Size = new Size(47, 23);
            titlu.TabIndex = 0;
            titlu.Text = "Title";
            // 
            // autor
            // 
            autor.AutoSize = true;
            autor.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            autor.Location = new Point(250, 79);
            autor.Name = "autor";
            autor.Size = new Size(68, 23);
            autor.TabIndex = 1;
            autor.Text = "Author";
            // 
            // gen
            // 
            gen.AutoSize = true;
            gen.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gen.Location = new Point(474, 79);
            gen.Name = "gen";
            gen.Size = new Size(59, 23);
            gen.TabIndex = 2;
            gen.Text = "Genre";
            // 
            // year
            // 
            year.AutoSize = true;
            year.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            year.Location = new Point(698, 79);
            year.Name = "year";
            year.Size = new Size(146, 23);
            year.TabIndex = 3;
            year.Text = "Publication Year";
            // 
            // quantity
            // 
            quantity.AutoSize = true;
            quantity.Font = new Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            quantity.Location = new Point(922, 79);
            quantity.Name = "quantity";
            quantity.Size = new Size(83, 23);
            quantity.TabIndex = 4;
            quantity.Text = "Quantity";
            // 
            // titlutextbox
            // 
            titlutextbox.Location = new Point(26, 118);
            titlutextbox.Name = "titlutextbox";
            titlutextbox.Size = new Size(218, 27);
            titlutextbox.TabIndex = 5;
            // 
            // gentextBox
            // 
            gentextBox.Location = new Point(474, 118);
            gentextBox.Name = "gentextBox";
            gentextBox.Size = new Size(218, 27);
            gentextBox.TabIndex = 6;
            // 
            // yeartextBox
            // 
            yeartextBox.Location = new Point(698, 118);
            yeartextBox.Name = "yeartextBox";
            yeartextBox.Size = new Size(218, 27);
            yeartextBox.TabIndex = 7;
            // 
            // autortextBox
            // 
            autortextBox.Location = new Point(250, 118);
            autortextBox.Name = "autortextBox";
            autortextBox.Size = new Size(218, 27);
            autortextBox.TabIndex = 8;
            // 
            // quantitytextBox
            // 
            quantitytextBox.Location = new Point(922, 118);
            quantitytextBox.Name = "quantitytextBox";
            quantitytextBox.Size = new Size(218, 27);
            quantitytextBox.TabIndex = 9;
            // 
            // add
            // 
            add.BackColor = SystemColors.ControlDarkDark;
            add.FlatStyle = FlatStyle.Popup;
            add.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.ForeColor = Color.White;
            add.Location = new Point(1191, 64);
            add.Name = "add";
            add.Size = new Size(129, 51);
            add.TabIndex = 10;
            add.Text = "ADD";
            add.UseVisualStyleBackColor = false;
            add.Click += btnAdding_Click;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1366, 184);
            Controls.Add(add);
            Controls.Add(quantitytextBox);
            Controls.Add(autortextBox);
            Controls.Add(yeartextBox);
            Controls.Add(gentextBox);
            Controls.Add(titlutextbox);
            Controls.Add(quantity);
            Controls.Add(year);
            Controls.Add(gen);
            Controls.Add(autor);
            Controls.Add(titlu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddBook";
            Text = "AddBook";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titlu;
        private Label autor;
        private Label gen;
        private Label year;
        private Label quantity;
        private TextBox titlutextbox;
        private TextBox gentextBox;
        private TextBox yeartextBox;
        private TextBox autortextBox;
        private TextBox quantitytextBox;
        private Button add;
    }
}