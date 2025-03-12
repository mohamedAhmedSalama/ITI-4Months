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
    public partial class StudentExamsForm : Form
    {
        int StudentID;
        int ExamID;
        int examDuration;
        int examMarks;
        int passMarks;
        DateTime startTime;
        StudentExamLogic studentExamLogic;
        public StudentExamsForm(int studentid)
        {
            InitializeComponent();

            studentExamLogic = new StudentExamLogic();
            this.StudentID = studentid;
        }

        private void initForm()
        {
            dgv_exams.DataSource = studentExamLogic.getStudentsExams(StudentID);
            dgv_exams.Columns["ExamID"].Visible = false;
            dgv_exams.Columns["StartTime"].Visible = false;


            btn_startExam.Visible = false;

            txt_courseName.Enabled = false;
            txt_examTitle.Enabled = false;
            txt_instruction.Enabled = false;

            nud_duration.Enabled = false;
            nud_totalMarks.Enabled = false;
            nud_passMarks.Enabled = false;

            dtp_date.Enabled = false;

        }
        private void StudentExamsForm_Load(object sender, EventArgs e)
        {
            initForm();
        }

        private void dgv_exams_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                // Check if a row is selected
                if (dgv_exams.SelectedRows.Count == 0)
                {
                    MessageBox.Show("No row selected.");
                    return;
                }

                // Get the selected row
                DataGridViewRow row = dgv_exams.SelectedRows[0];

                // Safely assign values with null checks and type validation
                txt_courseName.Text = row.Cells["CourseName"]?.Value?.ToString() ?? string.Empty;
                txt_examTitle.Text = row.Cells["ExamTitle"]?.Value?.ToString() ?? string.Empty;
                txt_instruction.Text = row.Cells["ExamInstructions"]?.Value?.ToString() ?? string.Empty;

                // Safely parse DateTime values
                if (row.Cells["Exam_Date"]?.Value is DateTime examDate)
                {
                    dtp_date.Value = examDate;
                }
                else
                {
                    dtp_date.Value = DateTime.Now; // Default value
                }

                // Safely parse integer values
                nud_duration.Value = (row.Cells["ExamDuration"]?.Value as int?) ?? 0;
                nud_totalMarks.Value = (row.Cells["TotalMarks"]?.Value as int?) ?? 0;
                nud_passMarks.Value = (row.Cells["PassMarks"]?.Value as int?) ?? 0;

                // Assign properties with null checks and type validation
                this.ExamID = (row.Cells["ExamID"]?.Value as int?) ?? 0;
                this.examDuration = (row.Cells["ExamDuration"]?.Value as int?) ?? 0;
                this.examMarks = (row.Cells["TotalMarks"]?.Value as int?) ?? 0;
                this.passMarks = (row.Cells["PassMarks"]?.Value as int?) ?? 0;

                // Safely parse DateTime for StartTime
                if (row.Cells["StartTime"]?.Value is DateTime startTime)
                {
                    this.startTime = startTime;
                }
                else
                {
                    this.startTime = DateTime.MinValue; // Default value
                }

                // Show the start exam button
                btn_startExam.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void btn_startExam_Click(object sender, EventArgs e)
        {
            // Check if the exam has not started (startTime is DateTime.MinValue)
            if (startTime == DateTime.MinValue)
            {
                StartExamForm form = new StartExamForm(StudentID, ExamID, examMarks, passMarks, examDuration);
                form.StartPosition = FormStartPosition.Manual;
                form.Location = this.Location;
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("You had Finished this Exam!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_showResults_Click(object sender, EventArgs e)
        {
            StudentResultsForm form = new StudentResultsForm(StudentID);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
