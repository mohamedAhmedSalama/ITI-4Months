using ExaminationSystem.BusinessLogic;
using ExaminationSystem.Models;
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
    public partial class PreviewStudentForm : Form
    {
        int studentID;
        int CourseID;
        int ExamID;
        bool flagExam = true;
        StudentExamSubmissionLogic studentExamSubmissionLogic;
        StudentExamLogic studentExamLogic;
        public PreviewStudentForm(int studenid, int courseid)
        {
            InitializeComponent();
            studentExamSubmissionLogic = new StudentExamSubmissionLogic();
            studentExamLogic = new StudentExamLogic();
            this.studentID = studenid;
            this.CourseID = courseid;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void previewStudent()
        {
            dgv_preview.DataSource = studentExamSubmissionLogic.getStudentsExamsAssigned(studentID, CourseID);
            txt_feedback.Enabled = false;
            btn_feedback.Enabled = false;
            btn_ShowAnswers.Enabled = false;
            flagExam = true;
        }

        private void PreviewStudentForm_Load(object sender, EventArgs e)
        {
            previewStudent();
        }

        private void dgv_preview_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (flagExam)
            {
                DataGridViewRow row = dgv_preview.SelectedRows[0];
                ExamID = (int)row.Cells["ExamId"].Value;
                btn_ShowAnswers.Enabled = true;
            }
        }

        private void btn_ShowAnswers_Click(object sender, EventArgs e)
        {
            btn_feedback.Enabled = true;
            flagExam = false;
            txt_feedback.Enabled = true;
            string correctAnswer = string.Empty;
            string studentAnswer = string.Empty;

            string option1 = string.Empty;
            string option2 = string.Empty;
            string option3 = string.Empty;
            string option4 = string.Empty;

            int count;
            var result = studentExamSubmissionLogic.getStudentAnswers(studentID, ExamID);
            count = result.Count;

            // Ensure the DataGridView is properly bound to the data source
            dgv_preview.DataSource = result;

            for (int i = 0; i < count; i++)
            {
                // Check if result[i] is null
                if (result[i] == null)
                {
                    continue; // Skip this iteration if result[i] is null
                }

                // Retrieve correctAnswer and studentAnswer
                correctAnswer = result[i].IsCorrect; // Ensure IsCorrect is a string or convert it to string
                studentAnswer = result[i].YourAnswer; // Ensure YourAnswer is a string or convert it to string

                // Retrieve option values with null checks
                option1 = dgv_preview.Rows[i].Cells["Option1"].Value?.ToString() ?? string.Empty;
                option2 = dgv_preview.Rows[i].Cells["Option2"].Value?.ToString() ?? string.Empty;
                option3 = dgv_preview.Rows[i].Cells["Option3"].Value?.ToString() ?? string.Empty;
                option4 = dgv_preview.Rows[i].Cells["Option4"].Value?.ToString() ?? string.Empty;

                // Compare studentAnswer with correctAnswer
                if (correctAnswer == studentAnswer)
                {
                    // If the student's answer is correct, highlight the corresponding option in green
                    if (studentAnswer == option1)
                    {
                        dgv_preview.Rows[i].Cells["Option1"].Style.BackColor = Color.Green;
                    }
                    else if (studentAnswer == option2)
                    {
                        dgv_preview.Rows[i].Cells["Option2"].Style.BackColor = Color.Green;
                    }
                    else if (studentAnswer == option3)
                    {
                        dgv_preview.Rows[i].Cells["Option3"].Style.BackColor = Color.Green;
                    }
                    else if (studentAnswer == option4)
                    {
                        dgv_preview.Rows[i].Cells["Option4"].Style.BackColor = Color.Green;
                    }
                }
                else
                {
                    // If the student's answer is incorrect
                    if (studentAnswer == "")
                    {
                        // If the student didn't answer, do nothing
                    }
                    else
                    {
                        // Highlight the student's incorrect answer in red
                        if (studentAnswer == option1)
                        {
                            dgv_preview.Rows[i].Cells["Option1"].Style.BackColor = Color.Red;
                        }
                        else if (studentAnswer == option2)
                        {
                            dgv_preview.Rows[i].Cells["Option2"].Style.BackColor = Color.Red;
                        }
                        else if (studentAnswer == option3)
                        {
                            dgv_preview.Rows[i].Cells["Option3"].Style.BackColor = Color.Red;
                        }
                        else if (studentAnswer == option4)
                        {
                            dgv_preview.Rows[i].Cells["Option4"].Style.BackColor = Color.Red;
                        }
                    }

                    // Highlight the correct answer in green
                    if (correctAnswer == option1)
                    {
                        dgv_preview.Rows[i].Cells["Option1"].Style.BackColor = Color.Green;
                    }
                    else if (correctAnswer == option2)
                    {
                        dgv_preview.Rows[i].Cells["Option2"].Style.BackColor = Color.Green;
                    }
                    else if (correctAnswer == option3)
                    {
                        dgv_preview.Rows[i].Cells["Option3"].Style.BackColor = Color.Green;
                    }
                    else if (correctAnswer == option4)
                    {
                        dgv_preview.Rows[i].Cells["Option4"].Style.BackColor = Color.Green;
                    }
                }
            }
        }

        private void btn_feedback_Click(object sender, EventArgs e)
        {
            string feedback = txt_feedback.Text;
            if (feedback == "")
            {
                MessageBox.Show("Please enter Feedback!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            studentExamLogic.giveFeedback(studentID, ExamID, feedback);
            MessageBox.Show(" Feedback is sent!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txt_reload_Click(object sender, EventArgs e)
        {
            previewStudent();
        }
    }
}
