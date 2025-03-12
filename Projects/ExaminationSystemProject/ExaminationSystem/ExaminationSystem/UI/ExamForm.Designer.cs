namespace ExaminationSystem.UI
{
    partial class ExamForm
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
            txt_questionText = new TextBox();
            cb_questionType = new ComboBox();
            cb_difficultyLevel = new ComboBox();
            nud_marks = new NumericUpDown();
            lbl_question = new Label();
            lbl_type = new Label();
            lbl_level = new Label();
            lbl_marks = new Label();
            btn_AddOptionns = new Button();
            txt_option1 = new TextBox();
            txt_option2 = new TextBox();
            txt_option3 = new TextBox();
            txt_option4 = new TextBox();
            lbl_choice1 = new Label();
            lbl_choice2 = new Label();
            lbl_choice3 = new Label();
            lbl_choice4 = new Label();
            btn_SaveQuestion = new Button();
            btn_SubmitExam = new Button();
            rbtn_correct1 = new RadioButton();
            rbtn_correct2 = new RadioButton();
            rbtn_correct3 = new RadioButton();
            rbtn_correct4 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)nud_marks).BeginInit();
            SuspendLayout();
            // 
            // txt_questionText
            // 
            txt_questionText.Location = new Point(117, 12);
            txt_questionText.Multiline = true;
            txt_questionText.Name = "txt_questionText";
            txt_questionText.Size = new Size(671, 58);
            txt_questionText.TabIndex = 0;
            // 
            // cb_questionType
            // 
            cb_questionType.FormattingEnabled = true;
            cb_questionType.Location = new Point(121, 90);
            cb_questionType.Name = "cb_questionType";
            cb_questionType.Size = new Size(151, 28);
            cb_questionType.TabIndex = 1;
            // 
            // cb_difficultyLevel
            // 
            cb_difficultyLevel.FormattingEnabled = true;
            cb_difficultyLevel.Location = new Point(412, 93);
            cb_difficultyLevel.Name = "cb_difficultyLevel";
            cb_difficultyLevel.Size = new Size(151, 28);
            cb_difficultyLevel.TabIndex = 2;
            // 
            // nud_marks
            // 
            nud_marks.Location = new Point(638, 96);
            nud_marks.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nud_marks.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nud_marks.Name = "nud_marks";
            nud_marks.Size = new Size(150, 27);
            nud_marks.TabIndex = 3;
            nud_marks.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lbl_question
            // 
            lbl_question.AutoSize = true;
            lbl_question.Location = new Point(12, 29);
            lbl_question.Name = "lbl_question";
            lbl_question.Size = new Size(99, 20);
            lbl_question.TabIndex = 4;
            lbl_question.Text = "Question Text";
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Location = new Point(12, 93);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new Size(103, 20);
            lbl_type.TabIndex = 5;
            lbl_type.Text = "Question Type";
            // 
            // lbl_level
            // 
            lbl_level.AutoSize = true;
            lbl_level.Location = new Point(289, 96);
            lbl_level.Name = "lbl_level";
            lbl_level.Size = new Size(107, 20);
            lbl_level.TabIndex = 6;
            lbl_level.Text = "Difficulty Level";
            // 
            // lbl_marks
            // 
            lbl_marks.AutoSize = true;
            lbl_marks.Location = new Point(584, 101);
            lbl_marks.Name = "lbl_marks";
            lbl_marks.Size = new Size(48, 20);
            lbl_marks.TabIndex = 7;
            lbl_marks.Text = "Marks";
            // 
            // btn_AddOptionns
            // 
            btn_AddOptionns.BackColor = Color.Firebrick;
            btn_AddOptionns.FlatStyle = FlatStyle.Flat;
            btn_AddOptionns.ForeColor = SystemColors.ButtonHighlight;
            btn_AddOptionns.Location = new Point(319, 155);
            btn_AddOptionns.Name = "btn_AddOptionns";
            btn_AddOptionns.Size = new Size(182, 48);
            btn_AddOptionns.TabIndex = 8;
            btn_AddOptionns.Text = "Add Options";
            btn_AddOptionns.UseVisualStyleBackColor = false;
            btn_AddOptionns.Click += btn_AddOptionns_Click;
            // 
            // txt_option1
            // 
            txt_option1.Location = new Point(90, 226);
            txt_option1.Name = "txt_option1";
            txt_option1.Size = new Size(125, 27);
            txt_option1.TabIndex = 9;
            // 
            // txt_option2
            // 
            txt_option2.Location = new Point(90, 329);
            txt_option2.Name = "txt_option2";
            txt_option2.Size = new Size(125, 27);
            txt_option2.TabIndex = 11;
            // 
            // txt_option3
            // 
            txt_option3.Location = new Point(376, 230);
            txt_option3.Name = "txt_option3";
            txt_option3.Size = new Size(125, 27);
            txt_option3.TabIndex = 13;
            // 
            // txt_option4
            // 
            txt_option4.Location = new Point(376, 333);
            txt_option4.Name = "txt_option4";
            txt_option4.Size = new Size(125, 27);
            txt_option4.TabIndex = 15;
            // 
            // lbl_choice1
            // 
            lbl_choice1.AutoSize = true;
            lbl_choice1.Location = new Point(12, 229);
            lbl_choice1.Name = "lbl_choice1";
            lbl_choice1.Size = new Size(66, 20);
            lbl_choice1.TabIndex = 17;
            lbl_choice1.Text = "Choice 1";
            // 
            // lbl_choice2
            // 
            lbl_choice2.AutoSize = true;
            lbl_choice2.Location = new Point(12, 336);
            lbl_choice2.Name = "lbl_choice2";
            lbl_choice2.Size = new Size(66, 20);
            lbl_choice2.TabIndex = 18;
            lbl_choice2.Text = "Choice 2";
            // 
            // lbl_choice3
            // 
            lbl_choice3.AutoSize = true;
            lbl_choice3.Location = new Point(304, 233);
            lbl_choice3.Name = "lbl_choice3";
            lbl_choice3.Size = new Size(66, 20);
            lbl_choice3.TabIndex = 19;
            lbl_choice3.Text = "Choice 3";
            // 
            // lbl_choice4
            // 
            lbl_choice4.AutoSize = true;
            lbl_choice4.Location = new Point(304, 336);
            lbl_choice4.Name = "lbl_choice4";
            lbl_choice4.Size = new Size(66, 20);
            lbl_choice4.TabIndex = 20;
            lbl_choice4.Text = "Choice 4";
            // 
            // btn_SaveQuestion
            // 
            btn_SaveQuestion.BackColor = Color.Firebrick;
            btn_SaveQuestion.FlatStyle = FlatStyle.Flat;
            btn_SaveQuestion.ForeColor = SystemColors.ButtonHighlight;
            btn_SaveQuestion.Location = new Point(584, 224);
            btn_SaveQuestion.Name = "btn_SaveQuestion";
            btn_SaveQuestion.Size = new Size(182, 48);
            btn_SaveQuestion.TabIndex = 21;
            btn_SaveQuestion.Text = "Save Question";
            btn_SaveQuestion.UseVisualStyleBackColor = false;
            btn_SaveQuestion.Click += btn_SaveQuestion_Click;
            // 
            // btn_SubmitExam
            // 
            btn_SubmitExam.BackColor = Color.Firebrick;
            btn_SubmitExam.FlatStyle = FlatStyle.Flat;
            btn_SubmitExam.ForeColor = SystemColors.ButtonHighlight;
            btn_SubmitExam.Location = new Point(584, 309);
            btn_SubmitExam.Name = "btn_SubmitExam";
            btn_SubmitExam.Size = new Size(182, 48);
            btn_SubmitExam.TabIndex = 22;
            btn_SubmitExam.Text = "Submit Exam";
            btn_SubmitExam.UseVisualStyleBackColor = false;
            btn_SubmitExam.Click += btn_SubmitExam_Click;
            // 
            // rbtn_correct1
            // 
            rbtn_correct1.AutoSize = true;
            rbtn_correct1.Checked = true;
            rbtn_correct1.Location = new Point(90, 259);
            rbtn_correct1.Name = "rbtn_correct1";
            rbtn_correct1.Size = new Size(130, 24);
            rbtn_correct1.TabIndex = 23;
            rbtn_correct1.TabStop = true;
            rbtn_correct1.Text = "Correct Answer";
            rbtn_correct1.UseVisualStyleBackColor = true;
            // 
            // rbtn_correct2
            // 
            rbtn_correct2.AutoSize = true;
            rbtn_correct2.Location = new Point(90, 362);
            rbtn_correct2.Name = "rbtn_correct2";
            rbtn_correct2.Size = new Size(130, 24);
            rbtn_correct2.TabIndex = 24;
            rbtn_correct2.Text = "Correct Answer";
            rbtn_correct2.UseVisualStyleBackColor = true;
            // 
            // rbtn_correct3
            // 
            rbtn_correct3.AutoSize = true;
            rbtn_correct3.Location = new Point(371, 263);
            rbtn_correct3.Name = "rbtn_correct3";
            rbtn_correct3.Size = new Size(130, 24);
            rbtn_correct3.TabIndex = 25;
            rbtn_correct3.Text = "Correct Answer";
            rbtn_correct3.UseVisualStyleBackColor = true;
            // 
            // rbtn_correct4
            // 
            rbtn_correct4.AutoSize = true;
            rbtn_correct4.Location = new Point(376, 366);
            rbtn_correct4.Name = "rbtn_correct4";
            rbtn_correct4.Size = new Size(130, 24);
            rbtn_correct4.TabIndex = 26;
            rbtn_correct4.Text = "Correct Answer";
            rbtn_correct4.UseVisualStyleBackColor = true;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(rbtn_correct4);
            Controls.Add(rbtn_correct3);
            Controls.Add(rbtn_correct2);
            Controls.Add(rbtn_correct1);
            Controls.Add(btn_SubmitExam);
            Controls.Add(btn_SaveQuestion);
            Controls.Add(lbl_choice4);
            Controls.Add(lbl_choice3);
            Controls.Add(lbl_choice2);
            Controls.Add(lbl_choice1);
            Controls.Add(txt_option4);
            Controls.Add(txt_option3);
            Controls.Add(txt_option2);
            Controls.Add(txt_option1);
            Controls.Add(btn_AddOptionns);
            Controls.Add(lbl_marks);
            Controls.Add(lbl_level);
            Controls.Add(lbl_type);
            Controls.Add(lbl_question);
            Controls.Add(nud_marks);
            Controls.Add(cb_difficultyLevel);
            Controls.Add(cb_questionType);
            Controls.Add(txt_questionText);
            Name = "ExamForm";
            Load += ExamForm_Load;
            ((System.ComponentModel.ISupportInitialize)nud_marks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_questionText;
        private ComboBox cb_questionType;
        private ComboBox cb_difficultyLevel;
        private NumericUpDown nud_marks;
        private Label lbl_question;
        private Label lbl_type;
        private Label lbl_level;
        private Label lbl_marks;
        private Button btn_AddOptionns;
        private TextBox txt_option1;
        private TextBox txt_option2;
        private TextBox txt_option3;
        private TextBox txt_option4;
        private Label lbl_choice1;
        private Label lbl_choice2;
        private Label lbl_choice3;
        private Label lbl_choice4;
        private Button btn_SaveQuestion;
        private Button btn_SubmitExam;
        private RadioButton rbtn_correct1;
        private RadioButton rbtn_correct2;
        private RadioButton rbtn_correct3;
        private RadioButton rbtn_correct4;
    }
}