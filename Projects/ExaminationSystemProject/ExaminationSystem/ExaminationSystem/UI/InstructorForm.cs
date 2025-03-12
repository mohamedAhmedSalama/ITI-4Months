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
    public partial class InstructorForm : Form
    {
        string FullName;
        int InstId;
        bool flag;
        bool flagStudentEnrolled = false;
        int ExamId = -1;
        int examMarks;
        int studentID;
        int courseID;
        CourseLogic courseLogic;
        ExamLogic examLogic;

        public InstructorForm(string fullname, int id)
        {
            InitializeComponent();
            nud_examId.Enabled = false;
            courseLogic = new CourseLogic();
            examLogic = new ExamLogic();
            this.FullName = fullname;
            this.InstId = id;
            flag = false;
        }

        private void hideExamOptions()
        {
            lbl_course.Visible = false;
            lbl_examId.Visible = false;
            lbl_examTitle.Visible = false;
            lbl_examDuration.Visible = false;
            lbl_instructions.Visible = false;
            lbl_totalMars.Visible = false;
            lbl_passMarks.Visible = false;
            lbl_date.Visible = false;

            cb_course.Visible = false;

            nud_duration.Visible = false;
            nud_examId.Visible = false;
            nud_passMarks.Visible = false;
            nud_totalMarks.Visible = false;

            txt_instruction.Visible = false;
            txt_title.Visible = false;

            dtp_date.Visible = false;
        }

        private void showExamOptions()
        {
            lbl_course.Visible = true;
            lbl_examId.Visible = true;
            lbl_examTitle.Visible = true;
            lbl_examDuration.Visible = true;
            lbl_instructions.Visible = true;
            lbl_totalMars.Visible = true;
            lbl_passMarks.Visible = true;
            lbl_date.Visible = true;

            cb_course.Visible = true;

            nud_duration.Visible = true;
            nud_examId.Visible = true;
            nud_passMarks.Visible = true;
            nud_totalMarks.Visible = true;

            txt_instruction.Visible = true;
            txt_title.Visible = true;

            dtp_date.Visible = true;
        }
        private void showCourses()
        {
            flagStudentEnrolled = false;
            dgv_Instructor.DataSource = courseLogic.getInstructorCourses(InstId);
            flag = false;
            btn_ExamQuestions.Visible = false;
            btn_previewStudent.Visible = false;
            btn_addExam.Visible = false;

            hideExamOptions();
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            lbl_inst.Text = "Welcome! Mr/" + FullName;
            showCourses();

        }

        private void btn_InstCourses_Click(object sender, EventArgs e)
        {
            showCourses();
        }

        private void btn_studentCourses_Click(object sender, EventArgs e)
        {
            btn_addExam.Visible = false;
            btn_ExamQuestions.Visible = false;
            btn_previewStudent.Visible = false;
            dgv_Instructor.DataSource = courseLogic.getStudentsInInstructorCourses(InstId);
            flag = false;
            flagStudentEnrolled = true;
            hideExamOptions();
        }

        private void btn_exam_Click(object sender, EventArgs e)
        {
            showExamOptions();
            btn_ExamQuestions.Visible = false;
            btn_addExam.Visible = true ;
            btn_previewStudent.Visible = false;

            flagStudentEnrolled = false;
            flag = true;
            dgv_Instructor.DataSource = examLogic.getInstructorExams(InstId);

            cb_course.DataSource = courseLogic.getInstructorCourse2(InstId);
            cb_course.DisplayMember = "CourseName";
            cb_course.ValueMember = "CourseId";
        }

        private void btn_addExam_Click(object sender, EventArgs e)
        {
            string title = txt_title.Text;
            string instruction = txt_instruction.Text;
            DateTime date = dtp_date.Value;
            int duration = Convert.ToInt32(nud_duration.Value);
            int totalMarks = Convert.ToInt32(nud_totalMarks.Value);
            int passMarks = Convert.ToInt32(nud_passMarks.Value);
            string courseName = (string)cb_course.Text;
            
            if (title == "" || instruction == "" || date == null || duration == 0 || totalMarks == 0 || passMarks == 0 || courseName == "")
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            else
            {
                int courseId = courseLogic.getCourseIDByName(courseName);
                examLogic.AddExam(title, instruction, date, duration, totalMarks, passMarks, courseId);
                MessageBox.Show("exam added successfully");
                return;
            }
        }

        private void dgv_Instructor_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (flag)
            {
                DataGridViewRow row = dgv_Instructor.SelectedRows[0];
                cb_course.SelectedValue = (int)row.Cells["CourseId"].Value;
                nud_examId.Value = (int)row.Cells["ExamId"].Value;
                ExamId = (int)nud_examId.Value;
                txt_title.Text = row.Cells["ExamTitle"].Value.ToString();
                nud_duration.Value = (int)row.Cells["ExamDuration"].Value;
                nud_totalMarks.Value = (int)row.Cells["TotalMarks"].Value;
                examMarks = (int)row.Cells["TotalMarks"].Value;
                nud_passMarks.Value = (int)row.Cells["PassMarks"].Value;
                txt_instruction.Text = row.Cells["Instructions"].Value.ToString();
                dtp_date.Value = (DateTime)row.Cells["ExamDate"].Value;
                btn_addExam.Visible = false;
                //btn_updateExam.Visible = true;
                //btn_deleteExam.Visible = true;
                btn_ExamQuestions.Visible = true;


            }
            else
            {
                btn_ExamQuestions.Visible = false;
            }
            if(flagStudentEnrolled)
            {
                btn_previewStudent.Visible = true;
                DataGridViewRow row = dgv_Instructor.SelectedRows[0];
                studentID = (int)row.Cells["StudentId"].Value;
                courseID = (int)row.Cells["CourseId"].Value;
            }
        }

        private void btn_ExamQuestions_Click(object sender, EventArgs e)
        {
            ExamForm form = new ExamForm(ExamId, examMarks);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_previewStudent_Click(object sender, EventArgs e)
        {
            PreviewStudentForm form = new PreviewStudentForm(studentID, courseID);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
