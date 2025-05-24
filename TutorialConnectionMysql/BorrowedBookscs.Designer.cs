namespace TutorialConnectionMysql
{
    partial class BorrowedBookscs
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
            previousbutton = new Button();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            searchbar = new TextBox();
            searchbutton = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(previousbutton);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1500, 36);
            panel1.TabIndex = 0;
            // 
            // previousbutton
            // 
            previousbutton.BackColor = Color.Transparent;
            previousbutton.Cursor = Cursors.Hand;
            previousbutton.FlatStyle = FlatStyle.Flat;
            previousbutton.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            previousbutton.Location = new Point(0, 0);
            previousbutton.Name = "previousbutton";
            previousbutton.Size = new Size(36, 35);
            previousbutton.TabIndex = 2;
            previousbutton.Text = "<";
            previousbutton.UseVisualStyleBackColor = false;
            previousbutton.Click += previousbutton_Click;
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
            button1.TabIndex = 3;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.RosyBrown;
            flowLayoutPanel1.Controls.Add(dataGridView1);
            flowLayoutPanel1.Location = new Point(45, 148);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1162, 640);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1146, 626);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // searchbar
            // 
            searchbar.BorderStyle = BorderStyle.FixedSingle;
            searchbar.Cursor = Cursors.IBeam;
            searchbar.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbar.ImeMode = ImeMode.NoControl;
            searchbar.Location = new Point(45, 81);
            searchbar.Multiline = true;
            searchbar.Name = "searchbar";
            searchbar.PlaceholderText = "Search";
            searchbar.Size = new Size(499, 35);
            searchbar.TabIndex = 2;
            // 
            // searchbutton
            // 
            searchbutton.BackColor = Color.RosyBrown;
            searchbutton.Cursor = Cursors.Hand;
            searchbutton.FlatAppearance.MouseDownBackColor = Color.IndianRed;
            searchbutton.FlatAppearance.MouseOverBackColor = Color.IndianRed;
            searchbutton.FlatStyle = FlatStyle.Flat;
            searchbutton.Font = new Font("Cambria", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchbutton.ForeColor = Color.White;
            searchbutton.Location = new Point(541, 81);
            searchbutton.Name = "searchbutton";
            searchbutton.Size = new Size(101, 35);
            searchbutton.TabIndex = 4;
            searchbutton.Text = "Search";
            searchbutton.UseVisualStyleBackColor = false;
            searchbutton.Click += searchbutton_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "All", "Title", "Author", "Genre" });
            comboBox1.Location = new Point(1022, 88);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(934, 88);
            label1.Name = "label1";
            label1.Size = new Size(82, 23);
            label1.TabIndex = 6;
            label1.Text = "Filter by";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.stand1;
            pictureBox1.Location = new Point(1234, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 640);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // BorrowedBookscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 800);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(searchbutton);
            Controls.Add(searchbar);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BorrowedBookscs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowedBookscs";
            Load += BorrowedBookscs_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button previousbutton;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox searchbar;
        private Button searchbutton;
        private ComboBox comboBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
    }
}