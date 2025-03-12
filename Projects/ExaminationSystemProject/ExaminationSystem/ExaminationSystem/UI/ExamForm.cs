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
    public partial class ExamForm : Form
    {
        int ExamID;
        QuestionLogic questionLogic;
        OptionLogic optionLogic;
        StudentExamLogic studentExamLogic;

        int questionID;
        string questionText;
        string questionType;
        string difficultyLevel;
        int examMarks;
        int marks;
        int countMarks;
        bool mcqFlag = false;
        public ExamForm(int examid,int examMarks)
        {
            InitializeComponent();
            cb_questionType.Items.Add("MCQ");
            cb_questionType.Items.Add("True/False");
            cb_difficultyLevel.Items.Add("Easy");
            cb_difficultyLevel.Items.Add("Medium");
            cb_difficultyLevel.Items.Add("Hard");

            questionLogic = new QuestionLogic();
            optionLogic = new OptionLogic();
            studentExamLogic = new StudentExamLogic();

            this.ExamID = examid;
            this.examMarks = examMarks;
            this.countMarks = 0;
        }

        private void hideOptions()
        {
            txt_option1.Visible = false;
            txt_option2.Visible = false;
            txt_option3.Visible = false;
            txt_option4.Visible = false;

            rbtn_correct1.Visible = false;
            rbtn_correct2.Visible = false;
            rbtn_correct3.Visible = false;
            rbtn_correct4.Visible = false;

            lbl_choice1.Visible = false;
            lbl_choice2.Visible = false;
            lbl_choice3.Visible = false;
            lbl_choice4.Visible = false;

            btn_SaveQuestion.Visible = false;
            btn_SubmitExam.Visible = false;
        }


        private void examForm()
        {

            cb_questionType.SelectedIndex = 0;


            cb_difficultyLevel.SelectedIndex = 0;

            txt_questionText.Enabled = true;
            nud_marks.Enabled = true;
            cb_questionType.Enabled = true;
            cb_difficultyLevel.Enabled = true;

            txt_questionText.Text = "";
            nud_marks.Value = 1;

            clearOptions();
            hideOptions();


        }

        private void clearOptions()
        {
            txt_option1.Text = "";
            txt_option2.Text = "";
            txt_option3.Text = "";
            txt_option4.Text = "";
            rbtn_correct1.Checked = true;
            rbtn_correct2.Checked = false;
            rbtn_correct3.Checked = false;
            rbtn_correct4.Checked = false;


        }

        private void AddingOptions()
        {
            txt_questionText.Enabled = false;
            nud_marks.Enabled = false;
            cb_questionType.Enabled = false;
            cb_difficultyLevel.Enabled = false;

            btn_AddOptionns.Visible = true;
            btn_SubmitExam.Visible = true;

        }

        private void showMcqOptions()
        {
            AddingOptions();

            lbl_choice1.Visible = true;
            lbl_choice2.Visible = true;
            lbl_choice3.Visible = true;
            lbl_choice4.Visible = true;

            txt_option1.Visible = true;
            txt_option2.Visible = true;
            txt_option3.Visible = true;
            txt_option4.Visible = true;

            txt_option1.Enabled = true;
            txt_option2.Enabled = true;

            rbtn_correct1.Visible = true;
            rbtn_correct2.Visible = true;
            rbtn_correct3.Visible = true;
            rbtn_correct4.Visible = true;
        }

        private void showTrueFalseOptions()
        {
            AddingOptions();

            lbl_choice1.Visible = true;
            lbl_choice2.Visible = true;

            txt_option1.Visible = true;
            txt_option1.Text = "True";
            txt_option1.Enabled = false;

            txt_option2.Visible = true;
            txt_option2.Text = "False";
            txt_option2.Enabled = false;

            rbtn_correct1.Visible = true;
            rbtn_correct2.Visible = true;
            rbtn_correct3.Visible = false;
            rbtn_correct4.Visible = false;
        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            examForm();
        }



        private void btn_AddOptionns_Click(object sender, EventArgs e)
        {
            questionText = txt_questionText.Text;
            questionType = cb_questionType.Text;
            difficultyLevel = cb_difficultyLevel.Text;
            marks = Convert.ToInt32(nud_marks.Value);

            if (questionText == "")
            {
                MessageBox.Show("Please enter question text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //MessageBox.Show($"{questionID}");
                btn_SaveQuestion.Visible = true;
                if (questionType == "True/False")
                {
                    mcqFlag = false;
                    showTrueFalseOptions();
                }
                else
                {
                    mcqFlag = true;
                    showMcqOptions();
                }
            }
        }

        private void btn_SaveQuestion_Click(object sender, EventArgs e)
        {
            countMarks += marks;
            int restOfMarks = examMarks - countMarks;
            string correctAnswer = "";
            string option1 = txt_option1.Text;
            string option2 = txt_option2.Text;
            string option3 = txt_option3.Text;
            string option4 = txt_option4.Text;
            
            if (restOfMarks < 0)
            {
                MessageBox.Show("Exam is full,Exam will be Submited ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                studentExamLogic.sendExamToAllStudentsInCourse(ExamID);

                this.Close();
                return;
            }
            if (rbtn_correct1.Checked == true)
            {
                correctAnswer = option1;
            }
            else if (rbtn_correct2.Checked == true)
            {
                correctAnswer = option2;
            }
            else if (rbtn_correct3.Checked == true)
            {
                correctAnswer = option3;
            }
            else if (rbtn_correct4.Checked == true)
            {
                correctAnswer = option4;
            }

            if (mcqFlag == true)
            {
                

                if (option1 == "" || option2 == "" || option3 == "" || option4 == "")
                {
                    MessageBox.Show("Please enter question text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                MessageBox.Show($"Question added successfully!!\nQ-{questionText}?\n" +
                    $"1-{option1} \n2-{option2} \n3- {option3} \n4- {option4}\nAnswer: {correctAnswer} \nMarks: {countMarks} of {examMarks}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                

                if (option1 == "" || option2 == "")
                {
                    MessageBox.Show("Please enter question text", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                option3 = null;
                option4 = null;
                MessageBox.Show($"Question added successfully!!\nQ-{questionText}?\n" +
                   $"1-{option1}\n 2-{option2}\nAnswer: {correctAnswer} \nMarks: {countMarks} of {examMarks} ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            questionID = questionLogic.addQuestion(questionText, questionType, difficultyLevel, marks, ExamID);
            optionLogic.addOption(option1, option2, option3, option4, correctAnswer, questionID);
            examForm();

        }

        private void btn_SubmitExam_Click(object sender, EventArgs e)
        {
            if(countMarks < examMarks)
            {
                MessageBox.Show("Please add more questions to complete the exam", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Exam is submitted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            studentExamLogic.sendExamToAllStudentsInCourse(ExamID);
            
            this.Close();
        }
    }
}
