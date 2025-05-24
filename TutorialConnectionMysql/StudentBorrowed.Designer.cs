namespace TutorialConnectionMysql
{
    partial class StudentBorrowed
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
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            SearchBar = new TextBox();
            Searchbutton = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            exitbutton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(12, 192);
            panel1.Name = "panel1";
            panel1.Size = new Size(1463, 568);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(47, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1380, 513);
            dataGridView1.TabIndex = 0;
            // 
            // SearchBar
            // 
            SearchBar.Location = new Point(13, 107);
            SearchBar.Name = "SearchBar";
            SearchBar.PlaceholderText = "Search";
            SearchBar.Size = new Size(392, 27);
            SearchBar.TabIndex = 1;
            // 
            // Searchbutton
            // 
            Searchbutton.BackColor = Color.RosyBrown;
            Searchbutton.FlatStyle = FlatStyle.Flat;
            Searchbutton.Font = new Font("Cambria", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Searchbutton.ForeColor = Color.White;
            Searchbutton.Location = new Point(390, 107);
            Searchbutton.Name = "Searchbutton";
            Searchbutton.Size = new Size(110, 27);
            Searchbutton.TabIndex = 2;
            Searchbutton.Text = "Search";
            Searchbutton.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Author", "Genre" });
            comboBox1.Location = new Point(739, 112);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(198, 25);
            comboBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(639, 112);
            label1.Name = "label1";
            label1.Size = new Size(83, 23);
            label1.TabIndex = 4;
            label1.Text = "Filter By";
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(exitbutton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1500, 34);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1464, 0);
            button1.Name = "button1";
            button1.Size = new Size(36, 35);
            button1.TabIndex = 7;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // exitbutton
            // 
            exitbutton.BackColor = Color.Transparent;
            exitbutton.Cursor = Cursors.Hand;
            exitbutton.FlatStyle = FlatStyle.Flat;
            exitbutton.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitbutton.Location = new Point(0, 0);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(36, 35);
            exitbutton.TabIndex = 6;
            exitbutton.Text = "<";
            exitbutton.UseVisualStyleBackColor = false;
            exitbutton.Click += exitbutton_Click;
            // 
            // StudentBorrowed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1500, 800);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(Searchbutton);
            Controls.Add(SearchBar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentBorrowed";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentBorrowed";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox SearchBar;
        private Button Searchbutton;
        private ComboBox comboBox1;
        private Label label1;
        private Panel panel2;
        private Button button1;
        private Button exitbutton;
    }
}