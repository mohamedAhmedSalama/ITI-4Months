namespace ExaminationSystem.UI
{
    partial class StudentExamsForm
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
            dgv_exams = new DataGridView();
            txt_courseName = new TextBox();
            txt_examTitle = new TextBox();
            txt_instruction = new TextBox();
            lbl_CourseName = new Label();
            lbl_ExamTitle = new Label();
            lbl_intructions = new Label();
            dtp_date = new DateTimePicker();
            nud_duration = new NumericUpDown();
            nud_totalMarks = new NumericUpDown();
            nud_passMarks = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btn_startExam = new Button();
            btn_showResults = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_exams).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_totalMarks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_passMarks).BeginInit();
            SuspendLayout();
            // 
            // dgv_exams
            // 
            dgv_exams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_exams.Location = new Point(0, 0);
            dgv_exams.Name = "dgv_exams";
            dgv_exams.RowHeadersWidth = 51;
            dgv_exams.Size = new Size(800, 188);
            dgv_exams.TabIndex = 0;
            dgv_exams.RowHeaderMouseDoubleClick += dgv_exams_RowHeaderMouseDoubleClick;
            // 
            // txt_courseName
            // 
            txt_courseName.Location = new Point(187, 225);
            txt_courseName.Name = "txt_courseName";
            txt_courseName.Size = new Size(125, 27);
            txt_courseName.TabIndex = 1;
            // 
            // txt_examTitle
            // 
            txt_examTitle.Location = new Point(187, 297);
            txt_examTitle.Name = "txt_examTitle";
            txt_examTitle.Size = new Size(125, 27);
            txt_examTitle.TabIndex = 2;
            // 
            // txt_instruction
            // 
            txt_instruction.Location = new Point(187, 375);
            txt_instruction.Name = "txt_instruction";
            txt_instruction.Size = new Size(125, 27);
            txt_instruction.TabIndex = 3;
            // 
            // lbl_CourseName
            // 
            lbl_CourseName.AutoSize = true;
            lbl_CourseName.Location = new Point(48, 228);
            lbl_CourseName.Name = "lbl_CourseName";
            lbl_CourseName.Size = new Size(98, 20);
            lbl_CourseName.TabIndex = 4;
            lbl_CourseName.Text = "Course Name";
            // 
            // lbl_ExamTitle
            // 
            lbl_ExamTitle.AutoSize = true;
            lbl_ExamTitle.Location = new Point(48, 304);
            lbl_ExamTitle.Name = "lbl_ExamTitle";
            lbl_ExamTitle.Size = new Size(78, 20);
            lbl_ExamTitle.TabIndex = 5;
            lbl_ExamTitle.Text = "Exam Title";
            // 
            // lbl_intructions
            // 
            lbl_intructions.AutoSize = true;
            lbl_intructions.Location = new Point(48, 378);
            lbl_intructions.Name = "lbl_intructions";
            lbl_intructions.Size = new Size(124, 20);
            lbl_intructions.TabIndex = 6;
            lbl_intructions.Text = "Exam Instructions";
            // 
            // dtp_date
            // 
            dtp_date.Location = new Point(456, 225);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(250, 27);
            dtp_date.TabIndex = 7;
            // 
            // nud_duration
            // 
            nud_duration.Location = new Point(456, 271);
            nud_duration.Name = "nud_duration";
            nud_duration.Size = new Size(150, 27);
            nud_duration.TabIndex = 8;
            // 
            // nud_totalMarks
            // 
            nud_totalMarks.Location = new Point(456, 338);
            nud_totalMarks.Name = "nud_totalMarks";
            nud_totalMarks.Size = new Size(150, 27);
            nud_totalMarks.TabIndex = 9;
            // 
            // nud_passMarks
            // 
            nud_passMarks.Location = new Point(456, 393);
            nud_passMarks.Name = "nud_passMarks";
            nud_passMarks.Size = new Size(150, 27);
            nud_passMarks.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 225);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 11;
            label1.Text = "Exam Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 279);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 12;
            label2.Text = "Exam Duration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 338);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 13;
            label3.Text = "Total Marks";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(335, 400);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 14;
            label4.Text = "Pass Marks";
            // 
            // btn_startExam
            // 
            btn_startExam.BackColor = Color.Firebrick;
            btn_startExam.FlatStyle = FlatStyle.Flat;
            btn_startExam.ForeColor = SystemColors.ButtonHighlight;
            btn_startExam.Location = new Point(655, 289);
            btn_startExam.Name = "btn_startExam";
            btn_startExam.Size = new Size(117, 43);
            btn_startExam.TabIndex = 15;
            btn_startExam.Text = "Start Exam";
            btn_startExam.UseVisualStyleBackColor = false;
            btn_startExam.Click += btn_startExam_Click;
            // 
            // btn_showResults
            // 
            btn_showResults.BackColor = Color.Firebrick;
            btn_showResults.FlatStyle = FlatStyle.Flat;
            btn_showResults.ForeColor = SystemColors.ButtonHighlight;
            btn_showResults.Location = new Point(655, 373);
            btn_showResults.Name = "btn_showResults";
            btn_showResults.Size = new Size(117, 43);
            btn_showResults.TabIndex = 16;
            btn_showResults.Text = "My Results";
            btn_showResults.UseVisualStyleBackColor = false;
            btn_showResults.Click += btn_showResults_Click;
            // 
            // StudentExamsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_showResults);
            Controls.Add(btn_startExam);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nud_passMarks);
            Controls.Add(nud_totalMarks);
            Controls.Add(nud_duration);
            Controls.Add(dtp_date);
            Controls.Add(lbl_intructions);
            Controls.Add(lbl_ExamTitle);
            Controls.Add(lbl_CourseName);
            Controls.Add(txt_instruction);
            Controls.Add(txt_examTitle);
            Controls.Add(txt_courseName);
            Controls.Add(dgv_exams);
            Name = "StudentExamsForm";
            Text = "StudentExamsForm";
            Load += StudentExamsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_exams).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_totalMarks).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_passMarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_exams;
        private TextBox txt_courseName;
        private TextBox txt_examTitle;
        private TextBox txt_instruction;
        private Label lbl_CourseName;
        private Label lbl_ExamTitle;
        private Label lbl_intructions;
        private DateTimePicker dtp_date;
        private NumericUpDown nud_duration;
        private NumericUpDown nud_totalMarks;
        private NumericUpDown nud_passMarks;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btn_startExam;
        private Button btn_showResults;
    }
}