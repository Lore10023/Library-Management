namespace TutorialConnectionMysql
{
    partial class SearchBook
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            cautare = new Button();
            dataGridView1 = new DataGridView();
            title = new Label();
            titletextBox = new TextBox();
            autor = new Label();
            autortextBox = new TextBox();
            gen = new Label();
            gentextBox = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cautare
            // 
            cautare.BackColor = Color.RosyBrown;
            cautare.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cautare.ForeColor = Color.White;
            cautare.Location = new Point(1041, 513);
            cautare.Name = "cautare";
            cautare.Size = new Size(161, 76);
            cautare.TabIndex = 0;
            cautare.Text = "SEARCH";
            cautare.UseVisualStyleBackColor = false;
            cautare.Click += search_Button;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(12, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(871, 592);
            dataGridView1.TabIndex = 1;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Cambria", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.GrayText;
            title.Location = new Point(921, 47);
            title.Name = "title";
            title.Size = new Size(149, 27);
            title.TabIndex = 2;
            title.Text = "Search by title";
            // 
            // titletextBox
            // 
            titletextBox.Location = new Point(989, 96);
            titletextBox.Name = "titletextBox";
            titletextBox.Size = new Size(339, 27);
            titletextBox.TabIndex = 3;
            // 
            // autor
            // 
            autor.AutoSize = true;
            autor.Font = new Font("Cambria", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            autor.ForeColor = SystemColors.GrayText;
            autor.Location = new Point(921, 181);
            autor.Name = "autor";
            autor.Size = new Size(175, 27);
            autor.TabIndex = 4;
            autor.Text = "Search by author";
            // 
            // autortextBox
            // 
            autortextBox.Location = new Point(989, 235);
            autortextBox.Name = "autortextBox";
            autortextBox.Size = new Size(339, 27);
            autortextBox.TabIndex = 5;
            // 
            // gen
            // 
            gen.AutoSize = true;
            gen.Font = new Font("Cambria", 13.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            gen.ForeColor = SystemColors.GrayText;
            gen.Location = new Point(921, 320);
            gen.Name = "gen";
            gen.Size = new Size(165, 27);
            gen.TabIndex = 6;
            gen.Text = "Search by genre";
            // 
            // gentextBox
            // 
            gentextBox.Location = new Point(989, 370);
            gentextBox.Name = "gentextBox";
            gentextBox.Size = new Size(339, 27);
            gentextBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.owllookingup;
            pictureBox1.Location = new Point(1234, 432);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 123);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // SearchBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1358, 625);
            Controls.Add(pictureBox1);
            Controls.Add(gentextBox);
            Controls.Add(gen);
            Controls.Add(autortextBox);
            Controls.Add(autor);
            Controls.Add(titletextBox);
            Controls.Add(title);
            Controls.Add(dataGridView1);
            Controls.Add(cautare);
            Name = "SearchBook";
            Text = "SearchBook";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cautare;
        private DataGridView dataGridView1;
        private Label title;
        private TextBox titletextBox;
        private Label autor;
        private TextBox autortextBox;
        private Label gen;
        private TextBox gentextBox;
        private PictureBox pictureBox1;
    }
}