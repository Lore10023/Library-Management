namespace TutorialConnectionMysql
{
    partial class StudentsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            listBoxStud = new ListBox();
            ApproveButton = new Button();
            ApproveStudGridView = new DataGridView();
            panel2 = new Panel();
            deleteStud = new Button();
            AllStudGridView = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ApproveStudGridView).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AllStudGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(listBoxStud);
            panel1.Controls.Add(ApproveButton);
            panel1.Controls.Add(ApproveStudGridView);
            panel1.Location = new Point(46, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 397);
            panel1.TabIndex = 0;
            // 
            // listBoxStud
            // 
            listBoxStud.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxStud.FormattingEnabled = true;
            listBoxStud.ItemHeight = 17;
            listBoxStud.Location = new Point(696, 18);
            listBoxStud.Name = "listBoxStud";
            listBoxStud.SelectionMode = SelectionMode.MultiSimple;
            listBoxStud.Size = new Size(298, 242);
            listBoxStud.TabIndex = 10;
            // 
            // ApproveButton
            // 
            ApproveButton.BackColor = Color.RosyBrown;
            ApproveButton.Cursor = Cursors.Hand;
            ApproveButton.FlatStyle = FlatStyle.Popup;
            ApproveButton.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            ApproveButton.ForeColor = Color.White;
            ApproveButton.Location = new Point(696, 312);
            ApproveButton.Name = "ApproveButton";
            ApproveButton.Size = new Size(298, 71);
            ApproveButton.TabIndex = 9;
            ApproveButton.Text = "Approve";
            ApproveButton.UseVisualStyleBackColor = false;
            ApproveButton.Click += ApproveButton_Click;
            // 
            // ApproveStudGridView
            // 
            ApproveStudGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ApproveStudGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            ApproveStudGridView.BackgroundColor = Color.White;
            ApproveStudGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            ApproveStudGridView.DefaultCellStyle = dataGridViewCellStyle1;
            ApproveStudGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            ApproveStudGridView.Location = new Point(20, 18);
            ApproveStudGridView.Name = "ApproveStudGridView";
            ApproveStudGridView.RightToLeft = RightToLeft.No;
            ApproveStudGridView.RowHeadersWidth = 51;
            ApproveStudGridView.Size = new Size(608, 365);
            ApproveStudGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(deleteStud);
            panel2.Controls.Add(AllStudGridView);
            panel2.Location = new Point(46, 479);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 277);
            panel2.TabIndex = 1;
            // 
            // deleteStud
            // 
            deleteStud.BackColor = Color.RosyBrown;
            deleteStud.Cursor = Cursors.Hand;
            deleteStud.FlatStyle = FlatStyle.Popup;
            deleteStud.Font = new Font("Cambria", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            deleteStud.ForeColor = Color.White;
            deleteStud.Location = new Point(696, 102);
            deleteStud.Name = "deleteStud";
            deleteStud.Size = new Size(298, 71);
            deleteStud.TabIndex = 8;
            deleteStud.Text = "Delete Student";
            deleteStud.UseVisualStyleBackColor = false;
            deleteStud.Click += deleteStud_Click;
            // 
            // AllStudGridView
            // 
            AllStudGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AllStudGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            AllStudGridView.BackgroundColor = Color.White;
            AllStudGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            AllStudGridView.DefaultCellStyle = dataGridViewCellStyle2;
            AllStudGridView.Location = new Point(20, 13);
            AllStudGridView.Name = "AllStudGridView";
            AllStudGridView.RightToLeft = RightToLeft.No;
            AllStudGridView.RowHeadersWidth = 51;
            AllStudGridView.Size = new Size(608, 253);
            AllStudGridView.TabIndex = 1;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "StudentsForm";
            Size = new Size(1155, 770);
            Load += StudentsForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ApproveStudGridView).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AllStudGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView ApproveStudGridView;
        private Panel panel2;
        private DataGridView AllStudGridView;
        private Button ApproveButton;
        private Button deleteStud;
        private ListBox listBoxStud;
    }
}
