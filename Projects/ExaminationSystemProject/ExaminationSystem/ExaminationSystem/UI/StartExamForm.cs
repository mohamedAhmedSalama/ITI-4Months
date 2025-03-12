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
using Timer = System.Windows.Forms.Timer;

namespace ExaminationSystem.UI
{
    public partial class StartExamForm : Form
    {
        public class Answer
        {
            public string AnswerText { get; set; }
            public bool IsCorrect { get; set; }
        }

        int studentID;
        int examID;
        int examDuration;
        int examMarks;

        dynamic stuExam;

        int noOfExamQuestions;
        int currentQuestion;
        bool nextFlag;
        bool prevFlag;
        int studentMarks;
        int passMarks;
        DateTime start;

        List<Answer> answers;

        OptionLogic optionLogic;
        StudentExamLogic studentExamLogic;
        StudentExamSubmissionLogic studentExamSubmissionLogic;

        private Timer examTimer;
        private int remainingTimeInSeconds; // Remaining time in seconds

        public StartExamForm(int studentID, int examID, int examMarks, int passMarks, int examDuration)
        {
            InitializeComponent();

            this.studentID = studentID;
            this.examID = examID;
            this.examDuration = examDuration;
            this.examMarks = examMarks;
            this.passMarks = passMarks;
            start = DateTime.Now;

            optionLogic = new OptionLogic();
            studentExamLogic = new StudentExamLogic();
            studentExamSubmissionLogic = new StudentExamSubmissionLogic();

            stuExam = optionLogic.getQuestionOptions(examID);

            noOfExamQuestions = stuExam.Count;
            currentQuestion = 0;
            nextFlag = false;
            prevFlag = false;
            studentMarks = 0;

            answers = new List<Answer>();
            for (int i = 0; i < noOfExamQuestions; i++)
            {
                answers.Add(new Answer
                {
                    AnswerText = "",
                    IsCorrect = false
                });
            }

            // Initialize the timer
            examTimer = new Timer();
            examTimer.Interval = 1000; // 1 second
            examTimer.Tick += ExamTimer_Tick;

            // Convert exam duration from minutes to seconds
            remainingTimeInSeconds = examDuration * 60;

            // Start the timer
            examTimer.Start();
        }

        private void ExamTimer_Tick(object sender, EventArgs e)
        {
            // Decrement the remaining time
            remainingTimeInSeconds--;

            // Update the timer label
            UpdateTimerLabel();

            // Check if the timer has reached 0
            if (remainingTimeInSeconds <= 0)
            {
                // Stop the timer
                examTimer.Stop();

                // Automatically submit the exam
                btn_submit_Click(null, null);
            }
        }

        private void UpdateTimerLabel()
        {
            // Convert remaining time to minutes and seconds
            int minutes = remainingTimeInSeconds / 60;
            int seconds = remainingTimeInSeconds % 60;

            // Update the label text
            lbl_timer.Text = $"Time Remaining: {minutes:00}:{seconds:00}";
        }

        private void showQuestion()
        {
            if (currentQuestion < noOfExamQuestions)
            {
                lbl_question.Text = $"Q{currentQuestion + 1}- {stuExam[currentQuestion].QuestionText}";
                if (stuExam[currentQuestion].QuestionType == "MCQ")
                {
                    btn_option3.Visible = true;
                    btn_option4.Visible = true;

                    btn_option1.Text = stuExam[currentQuestion].Option1;
                    btn_option2.Text = stuExam[currentQuestion].Option2;
                    btn_option3.Text = stuExam[currentQuestion].Option3;
                    btn_option4.Text = stuExam[currentQuestion].Option4;
                }
                else
                {
                    btn_option3.Visible = false;
                    btn_option4.Visible = false;

                    btn_option1.Text = stuExam[currentQuestion].Option1;
                    btn_option2.Text = stuExam[currentQuestion].Option2;
                }
            }
        }

        private void StartExamForm_Load(object sender, EventArgs e)
        {
            showQuestion();
            UpdateTimerLabel(); // Initialize the timer label
        }

        private void checkAnswer(string value)
        {
            if (value == stuExam[currentQuestion].IsCorrect)
            {
                answers[currentQuestion].AnswerText = value;
                answers[currentQuestion].IsCorrect = true;
            }
            else
            {
                answers[currentQuestion].AnswerText = value;
                answers[currentQuestion].IsCorrect = false;
            }
        }

        private void btn_option1_Click(object sender, EventArgs e)
        {
            string value = btn_option1.Text;
            checkAnswer(value);
        }

        private void btn_option2_Click(object sender, EventArgs e)
        {
            string value = btn_option2.Text;
            checkAnswer(value);
        }

        private void btn_option3_Click(object sender, EventArgs e)
        {
            string value = btn_option3.Text;
            checkAnswer(value);
        }

        private void btn_option4_Click(object sender, EventArgs e)
        {
            string value = btn_option4.Text;
            checkAnswer(value);
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            currentQuestion++;
            if (currentQuestion >= noOfExamQuestions - 1)
            {
                currentQuestion = noOfExamQuestions - 1;
                btn_next.Enabled = false;
                nextFlag = true;
            }
            else
            {
                // Do nothing
            }

            if (prevFlag)
            {
                btn_prev.Enabled = true;
                prevFlag = false;
            }
            showQuestion();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            currentQuestion--;
            if (currentQuestion <= 0)
            {
                currentQuestion = 0;
                btn_prev.Enabled = false;
                prevFlag = true;
            }
            else
            {
                // Do nothing
            }
            if (nextFlag)
            {
                nextFlag = false;
                btn_next.Enabled = true;
            }
            showQuestion();
        }

        private string calculateGrade(int marks, int totalmarks)
        {
            double percentage = ((double)marks / totalmarks) * 100;
            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 80)
            {
                return "B";
            }
            else if (percentage >= 70)
            {
                return "C";
            }
            else if (percentage >= 60)
            {
                return "D";
            }
            else if (percentage >= passMarks)
            {
                return "E";
            }
            else
            {
                return "F (Fail)";
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string grade;
            for (int i = 0; i < noOfExamQuestions; i++)
            {
                if (answers[i].IsCorrect)
                {
                    studentMarks += stuExam[i].Marks;
                }
            }

            for (int i = 0; i < noOfExamQuestions; i++)
            {
                studentExamSubmissionLogic.addStudentExamSubmission(studentID, examID,
                    stuExam[i].QuestionId, answers[i].AnswerText, answers[i].IsCorrect);
            }

            grade = calculateGrade(studentMarks, examMarks);
            studentExamLogic.addStudentExamAfterSubmit(studentID, examID, start, studentMarks, grade);
            MessageBox.Show("Congratulations on finishing Your exam!!\nAfter this form is closed, you can see your score.");
            this.Close();
        }
    }
}