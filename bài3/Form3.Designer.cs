namespace bài3
{
    partial class frmCourseList
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
            this.txtCourseID = new TextBox();
            this.txtCourseName = new TextBox();
            numCredits = new NumericUpDown();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numCredits).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 39);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã môn học:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 84);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên môn học:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 39);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Số tín chỉ:";
            label3.UseMnemonic = false;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new Point(120, 31);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new Size(143, 23);
            this.txtCourseID.TabIndex = 3;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new Point(120, 84);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new Size(143, 23);
            this.txtCourseName.TabIndex = 4;
            // 
            // numCredits
            // 
            numCredits.Location = new Point(556, 31);
            numCredits.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numCredits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCredits.Name = "numCredits";
            numCredits.Size = new Size(120, 23);
            numCredits.TabIndex = 5;
            numCredits.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(55, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(315, 168);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(543, 168);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(12, 217);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(664, 150);
            dataGridView1.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "CourseID";
            Column1.HeaderText = "Mã Môn";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "CourseName";
            Column2.HeaderText = "Tên Môn";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Credits";
            Column3.HeaderText = "Số Tín chỉ";
            Column3.Name = "Column3";
            // 
            // frmCourseList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(numCredits);
            Controls.Add(this.txtCourseName);
            Controls.Add(this.txtCourseID);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCourseList";
            Text = "Quản lý Môn học";
            ((System.ComponentModel.ISupportInitialize)numCredits).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numCredits;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}