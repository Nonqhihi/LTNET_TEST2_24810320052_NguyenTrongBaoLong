namespace bài3
{
    partial class frmStudentList
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtStudentID = new TextBox();
            txtFullName = new TextBox();
            dtpDateOfBirth = new DateTimePicker();
            cboFaculty = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvStudents = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 34);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã SV:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 102);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Họ Tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(421, 34);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(421, 97);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Khoa:";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(140, 26);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(129, 23);
            txtStudentID.TabIndex = 4;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(140, 94);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(129, 23);
            txtFullName.TabIndex = 5;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Format = DateTimePickerFormat.Short;
            dtpDateOfBirth.Location = new Point(517, 26);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(162, 23);
            dtpDateOfBirth.TabIndex = 6;
            // 
            // cboFaculty
            // 
            cboFaculty.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFaculty.FormattingEnabled = true;
            cboFaculty.Location = new Point(517, 89);
            cboFaculty.Name = "cboFaculty";
            cboFaculty.Size = new Size(162, 23);
            cboFaculty.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(32, 176);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 34);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(300, 176);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 34);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(576, 176);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvStudents.Location = new Point(162, 283);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new Size(440, 85);
            dgvStudents.TabIndex = 11;
            dgvStudents.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "StudentID";
            Column1.HeaderText = "Mã SV";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "FullName";
            Column2.HeaderText = "Họ và Tên";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "DateOfBirth";
            Column3.HeaderText = "Ngày Sinh";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Faculty";
            Column4.HeaderText = "Khoa";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // frmStudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStudents);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cboFaculty);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(txtFullName);
            Controls.Add(txtStudentID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmStudentList";
            Text = "Quản lý Hồ sơ Sinh viên";
            Load += frmStudentList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtStudentID;
        private TextBox txtFullName;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cboFaculty;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}