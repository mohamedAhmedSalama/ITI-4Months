using ExaminationSystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.UI
{
    public partial class StudentForm : Form
    {
        string FullName;
        int StudId;
        CourseLogic courseLogic;
        StudentCourseLogic studentCourseLogic;
        public StudentForm(string fullname, int id)
        {
            InitializeComponent();

            courseLogic = new CourseLogic();
            studentCourseLogic = new StudentCourseLogic();

            this.FullName = fullname;
            this.StudId = id;

            nud_courseId.Enabled = false;
            txt_courseName.Enabled = false;
            txt_courseDesc.Enabled = false;
            txt_courseCreated.Enabled = false;
            txt_instructorName.Enabled = false;
        }
        private void showCourses()
        {
            lbl_student.Text = $"Welcome, {FullName}";
            dgv_couses.DataSource = courseLogic.getCourses();
            btn_addCourse.Visible = false;
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {
            showCourses();
        }
        private void btn_courses_Click(object sender, EventArgs e)
        {
            showCourses();
        }
        private void btn_mycourses_Click(object sender, EventArgs e)
        {
            dgv_couses.DataSource = studentCourseLogic.getStudentCourses(StudId);
        }



        private void dgv_couses_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_addCourse.Visible = true;

            DataGridViewRow row = dgv_couses.SelectedRows[0];
            nud_courseId.Value = Convert.ToInt32(row.Cells[0].Value);
            txt_courseName.Text = row.Cells[1].Value.ToString();
            txt_courseDesc.Text = row.Cells[2].Value.ToString();
            txt_courseCreated.Text = row.Cells[3].Value.ToString();
            txt_instructorName.Text = row.Cells[4].Value.ToString();
        }

        private void btn_addCourse_Click(object sender, EventArgs e)
        {
            int courseId = Convert.ToInt32(nud_courseId.Value);
            if (studentCourseLogic.AddStudentCourse(StudId, courseId))
            {
                MessageBox.Show("Course added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Course already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            StudentExamsForm form = new StudentExamsForm(StudId);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
