namespace ExaminationSystem.UI
{
    partial class StudentResultsForm
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
            dgv_results = new DataGridView();
            txt_courseName = new TextBox();
            txt_examTitle = new TextBox();
            dtp_start = new DateTimePicker();
            dtp_end = new DateTimePicker();
            nud_score = new NumericUpDown();
            nud_duration = new NumericUpDown();
            txt_grade = new TextBox();
            dtp_examDate = new DateTimePicker();
            nud_totalMarks = new NumericUpDown();
            nud_passMarks = new NumericUpDown();
            txt_instruction = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txt_feedback = new TextBox();
            btn_stuAnswers = new Button();
            btn_results = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_results).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_score).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_totalMarks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_passMarks).BeginInit();
            SuspendLayout();
            // 
            // dgv_results
            // 
            dgv_results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_results.Location = new Point(0, 0);
            dgv_results.Name = "dgv_results";
            dgv_results.RowHeadersWidth = 51;
            dgv_results.Size = new Size(801, 188);
            dgv_results.TabIndex = 0;
            dgv_results.RowHeaderMouseDoubleClick += dgv_results_RowHeaderMouseDoubleClick;
            // 
            // txt_courseName
            // 
            txt_courseName.Location = new Point(105, 211);
            txt_courseName.Name = "txt_courseName";
            txt_courseName.Size = new Size(125, 27);
            txt_courseName.TabIndex = 1;
            // 
            // txt_examTitle
            // 
            txt_examTitle.Location = new Point(105, 257);
            txt_examTitle.Name = "txt_examTitle";
            txt_examTitle.Size = new Size(125, 27);
            txt_examTitle.TabIndex = 2;
            // 
            // dtp_start
            // 
            dtp_start.Location = new Point(95, 416);
            dtp_start.Name = "dtp_start";
            dtp_start.Size = new Size(250, 27);
            dtp_start.TabIndex = 3;
            // 
            // dtp_end
            // 
            dtp_end.Location = new Point(452, 416);
            dtp_end.Name = "dtp_end";
            dtp_end.Size = new Size(250, 27);
            dtp_end.TabIndex = 4;
            // 
            // nud_score
            // 
            nud_score.Location = new Point(105, 303);
            nud_score.Name = "nud_score";
            nud_score.Size = new Size(150, 27);
            nud_score.TabIndex = 5;
            // 
            // nud_duration
            // 
            nud_duration.Location = new Point(362, 257);
            nud_duration.Name = "nud_duration";
            nud_duration.Size = new Size(150, 27);
            nud_duration.TabIndex = 6;
            // 
            // txt_grade
            // 
            txt_grade.Location = new Point(105, 345);
            txt_grade.Name = "txt_grade";
            txt_grade.Size = new Size(125, 27);
            txt_grade.TabIndex = 7;
            // 
            // dtp_examDate
            // 
            dtp_examDate.Location = new Point(362, 303);
            dtp_examDate.Name = "dtp_examDate";
            dtp_examDate.Size = new Size(250, 27);
            dtp_examDate.TabIndex = 8;
            // 
            // nud_totalMarks
            // 
            nud_totalMarks.Location = new Point(362, 346);
            nud_totalMarks.Name = "nud_totalMarks";
            nud_totalMarks.Size = new Size(150, 27);
            nud_totalMarks.TabIndex = 9;
            // 
            // nud_passMarks
            // 
            nud_passMarks.Location = new Point(629, 204);
            nud_passMarks.Name = "nud_passMarks";
            nud_passMarks.Size = new Size(150, 27);
            nud_passMarks.TabIndex = 10;
            // 
            // txt_instruction
            // 
            txt_instruction.Location = new Point(362, 208);
            txt_instruction.Name = "txt_instruction";
            txt_instruction.Size = new Size(125, 27);
            txt_instruction.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 211);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 13;
            label1.Text = "Course Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 260);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 14;
            label2.Text = "Exam Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 421);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 15;
            label3.Text = "Start Time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(362, 421);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 16;
            label4.Text = "End Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1, 303);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 17;
            label5.Text = "Score";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 348);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 18;
            label6.Text = "Grade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(274, 211);
            label7.Name = "label7";
            label7.Size = new Size(84, 20);
            label7.TabIndex = 19;
            label7.Text = "Instructions";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(274, 308);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 20;
            label8.Text = "Exam Date";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(274, 259);
            label9.Name = "label9";
            label9.Size = new Size(67, 20);
            label9.TabIndex = 21;
            label9.Text = "Duration";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(274, 353);
            label10.Name = "label10";
            label10.Size = new Size(85, 20);
            label10.TabIndex = 22;
            label10.Text = "Total Marks";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(538, 208);
            label11.Name = "label11";
            label11.Size = new Size(79, 20);
            label11.TabIndex = 23;
            label11.Text = "Pass Marks";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(534, 260);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 25;
            label12.Text = "FeedBack";
            // 
            // txt_feedback
            // 
            txt_feedback.Location = new Point(629, 257);
            txt_feedback.Name = "txt_feedback";
            txt_feedback.Size = new Size(125, 27);
            txt_feedback.TabIndex = 24;
            // 
            // btn_stuAnswers
            // 
            btn_stuAnswers.BackColor = Color.Firebrick;
            btn_stuAnswers.FlatStyle = FlatStyle.Flat;
            btn_stuAnswers.ForeColor = SystemColors.ButtonHighlight;
            btn_stuAnswers.Location = new Point(629, 295);
            btn_stuAnswers.Name = "btn_stuAnswers";
            btn_stuAnswers.Size = new Size(155, 47);
            btn_stuAnswers.TabIndex = 26;
            btn_stuAnswers.Text = "Show My Answers";
            btn_stuAnswers.UseVisualStyleBackColor = false;
            btn_stuAnswers.Click += btn_stuAnswers_Click;
            // 
            // btn_results
            // 
            btn_results.BackColor = Color.Firebrick;
            btn_results.FlatStyle = FlatStyle.Flat;
            btn_results.ForeColor = SystemColors.ButtonHighlight;
            btn_results.Location = new Point(629, 353);
            btn_results.Name = "btn_results";
            btn_results.Size = new Size(155, 47);
            btn_results.TabIndex = 27;
            btn_results.Text = "My Results";
            btn_results.UseVisualStyleBackColor = false;
            btn_results.Click += btn_results_Click;
            // 
            // StudentResultsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_results);
            Controls.Add(btn_stuAnswers);
            Controls.Add(label12);
            Controls.Add(txt_feedback);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_instruction);
            Controls.Add(nud_passMarks);
            Controls.Add(nud_totalMarks);
            Controls.Add(dtp_examDate);
            Controls.Add(txt_grade);
            Controls.Add(nud_duration);
            Controls.Add(nud_score);
            Controls.Add(dtp_end);
            Controls.Add(dtp_start);
            Controls.Add(txt_examTitle);
            Controls.Add(txt_courseName);
            Controls.Add(dgv_results);
            Name = "StudentResultsForm";
            Text = "StudentResultsForm";
            Load += StudentResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_results).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_score).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_totalMarks).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_passMarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_results;
        private TextBox txt_courseName;
        private TextBox txt_examTitle;
        private DateTimePicker dtp_start;
        private DateTimePicker dtp_end;
        private NumericUpDown nud_score;
        private NumericUpDown nud_duration;
        private TextBox txt_grade;
        private DateTimePicker dtp_examDate;
        private NumericUpDown nud_totalMarks;
        private NumericUpDown nud_passMarks;
        private TextBox txt_instruction;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txt_feedback;
        private Button btn_stuAnswers;
        private Button btn_results;
    }
}