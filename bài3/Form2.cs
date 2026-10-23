using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bài3
{
    public partial class frmStudentList : Form
    {
        private BindingList<StudentModel> studentList;


        public frmStudentList()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ Mã SV và Họ tên!");
                return;
            }

            if (studentList.Any(s => s.StudentID == txtStudentID.Text))
            {
                MessageBox.Show("Mã Sinh viên đã tồn tại!");
                return;
            }

            studentList.Add(new StudentModel
            {
                StudentID = txtStudentID.Text,
                FullName = txtFullName.Text,
                DateOfBirth = dtpDateOfBirth.Value.Date,
                Faculty = cboFaculty.SelectedItem.ToString()
            });
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var student = studentList.FirstOrDefault(s => s.StudentID == txtStudentID.Text);
            if (student != null)
            {
                student.FullName = txtFullName.Text;
                student.DateOfBirth = dtpDateOfBirth.Value.Date;
                student.Faculty = cboFaculty.SelectedItem.ToString();
                dgvStudents.Refresh();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var student = studentList.FirstOrDefault(s => s.StudentID == txtStudentID.Text);
            if (student != null)
            {
                studentList.Remove(student);
                ClearInputs();
            }
        }

        private void frmStudentList_Load(object sender, EventArgs e)
        {
            cboFaculty.Items.AddRange(new string[] { "Công nghệ Thông tin", "Kinh tế", "Ngoại ngữ" });
            cboFaculty.SelectedIndex = 0;

            studentList = new BindingList<StudentModel>();
            dgvStudents.DataSource = studentList;
        }
        private void ClearInputs()
        {
            txtStudentID.Clear();
            txtFullName.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            cboFaculty.SelectedIndex = 0;
            txtStudentID.ReadOnly = false;
        }
        public class StudentModel
        {
            public string StudentID { get; set; }
            public string FullName { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string Faculty { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudents.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells["StudentID"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                if (row.Cells["DateOfBirth"].Value != null)
                    dtpDateOfBirth.Value = Convert.ToDateTime(row.Cells["DateOfBirth"].Value);
                cboFaculty.SelectedItem = row.Cells["Faculty"].Value?.ToString();

                txtStudentID.ReadOnly = true;
            }
        }
    }
}
