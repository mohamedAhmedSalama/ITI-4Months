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
    public partial class StudentResultsForm : Form
    {
        int studentID;
        int examID;
        bool flag = true;
        StudentExamLogic studentExamLogic;
        StudentExamSubmissionLogic studentExamSubmissionLogic;
        public StudentResultsForm(int studentid)
        {
            InitializeComponent();

            studentExamLogic = new StudentExamLogic();
            studentExamSubmissionLogic = new StudentExamSubmissionLogic();
            this.studentID = studentid;

            txt_courseName.Enabled = false;
            txt_examTitle.Enabled = false;
            txt_feedback.Enabled = false;
            txt_grade.Enabled = false;
            txt_instruction.Enabled = false;

            nud_duration.Enabled = false;
            nud_passMarks.Enabled = false;
            nud_totalMarks.Enabled = false;
            nud_score.Enabled = false;

            dtp_start.Enabled = false;
            dtp_end.Enabled = false;
            dtp_examDate.Enabled = false;
        }


        private void showResults()
        {
            dgv_results.DataSource = studentExamLogic.getStudentFinishedExams(studentID);
            dgv_results.Columns["ExamID"].Visible = false;

            flag = true;
            btn_stuAnswers.Enabled = false;
        }

        private void StudentResultsForm_Load(object sender, EventArgs e)
        {
            showResults();
        }

        private void dgv_results_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (flag)
            {
                btn_stuAnswers.Enabled = true;

                DataGridViewRow row = dgv_results.SelectedRows[0];
                txt_courseName.Text = row.Cells["CourseName"].Value.ToString();
                txt_examTitle.Text = row.Cells["ExamTitle"].Value.ToString();
                txt_grade.Text = row.Cells["Grade"].Value.ToString();
                txt_instruction.Text = row.Cells["ExamInstructions"].Value.ToString();
                txt_feedback.Text = row.Cells["FeedBack"].Value?.ToString() ?? string.Empty;

                nud_score.Value = (int)row.Cells["Score"].Value;
                nud_duration.Value = (int)row.Cells["ExamDuration"].Value;
                nud_totalMarks.Value = (int)row.Cells["TotalMarks"].Value;
                nud_passMarks.Value = (int)row.Cells["PassMarks"].Value;

                dtp_examDate.Value = (DateTime)row.Cells["Exam_Date"].Value;
                dtp_start.Value = (DateTime)row.Cells["StartTime"].Value;
                dtp_end.Value = (DateTime)row.Cells["EndTime"].Value;

                examID = (int)row.Cells["ExamID"].Value;
            }
        }

        private void btn_stuAnswers_Click(object sender, EventArgs e)
        {
            flag = false;
            string correctAnswer = string.Empty;
            string studentAnswer = string.Empty;

            string option1 = string.Empty;
            string option2 = string.Empty;
            string option3 = string.Empty;
            string option4 = string.Empty;

            int count;
            var result = studentExamSubmissionLogic.getStudentAnswers(studentID, examID);
            count = result.Count;

            // Ensure the DataGridView is properly bound to the data source
            dgv_results.DataSource = result;

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
                option1 = dgv_results.Rows[i].Cells["Option1"].Value?.ToString() ?? string.Empty;
                option2 = dgv_results.Rows[i].Cells["Option2"].Value?.ToString() ?? string.Empty;
                option3 = dgv_results.Rows[i].Cells["Option3"].Value?.ToString() ?? string.Empty;
                option4 = dgv_results.Rows[i].Cells["Option4"].Value?.ToString() ?? string.Empty;

                // Compare studentAnswer with correctAnswer
                if (correctAnswer == studentAnswer)
                {
                    // If the student's answer is correct, highlight the corresponding option in green
                    if (studentAnswer == option1)
                    {
                        dgv_results.Rows[i].Cells["Option1"].Style.BackColor = Color.Green;
                    }
                    else if (studentAnswer == option2)
                    {
                        dgv_results.Rows[i].Cells["Option2"].Style.BackColor = Color.Green;
                    }
                    else if (studentAnswer == option3)
                    {
                        dgv_results.Rows[i].Cells["Option3"].Style.BackColor = Color.Green;
                    }
                    else if (studentAnswer == option4)
                    {
                        dgv_results.Rows[i].Cells["Option4"].Style.BackColor = Color.Green;
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
                            dgv_results.Rows[i].Cells["Option1"].Style.BackColor = Color.Red;
                        }
                        else if (studentAnswer == option2)
                        {
                            dgv_results.Rows[i].Cells["Option2"].Style.BackColor = Color.Red;
                        }
                        else if (studentAnswer == option3)
                        {
                            dgv_results.Rows[i].Cells["Option3"].Style.BackColor = Color.Red;
                        }
                        else if (studentAnswer == option4)
                        {
                            dgv_results.Rows[i].Cells["Option4"].Style.BackColor = Color.Red;
                        }
                    }

                    // Highlight the correct answer in green
                    if (correctAnswer == option1)
                    {
                        dgv_results.Rows[i].Cells["Option1"].Style.BackColor = Color.Green;
                    }
                    else if (correctAnswer == option2)
                    {
                        dgv_results.Rows[i].Cells["Option2"].Style.BackColor = Color.Green;
                    }
                    else if (correctAnswer == option3)
                    {
                        dgv_results.Rows[i].Cells["Option3"].Style.BackColor = Color.Green;
                    }
                    else if (correctAnswer == option4)
                    {
                        dgv_results.Rows[i].Cells["Option4"].Style.BackColor = Color.Green;
                    }
                }
            }
        }

        private void btn_results_Click(object sender, EventArgs e)
        {
            showResults();
        }
    }
}
