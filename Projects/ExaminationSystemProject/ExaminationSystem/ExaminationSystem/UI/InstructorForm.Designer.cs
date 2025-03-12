namespace ExaminationSystem.UI
{
    partial class InstructorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstructorForm));
            dgv_Instructor = new DataGridView();
            btn_InstCourses = new Button();
            btn_studentCourses = new Button();
            btn_exam = new Button();
            lbl_inst = new Label();
            btn_addExam = new Button();
            cb_course = new ComboBox();
            txt_title = new TextBox();
            nud_duration = new NumericUpDown();
            nud_passMarks = new NumericUpDown();
            nud_totalMarks = new NumericUpDown();
            dtp_date = new DateTimePicker();
            lbl_course = new Label();
            lbl_examTitle = new Label();
            lbl_examDuration = new Label();
            lbl_totalMars = new Label();
            lbl_passMarks = new Label();
            lbl_date = new Label();
            txt_instruction = new TextBox();
            lbl_instructions = new Label();
            btn_ExamQuestions = new Button();
            nud_examId = new NumericUpDown();
            lbl_examId = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_previewStudent = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_Instructor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_passMarks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_totalMarks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_examId).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_Instructor
            // 
            dgv_Instructor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Instructor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_Instructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Instructor.Location = new Point(211, -2);
            dgv_Instructor.Name = "dgv_Instructor";
            dgv_Instructor.RowHeadersWidth = 51;
            dgv_Instructor.Size = new Size(987, 253);
            dgv_Instructor.TabIndex = 0;
            dgv_Instructor.RowHeaderMouseDoubleClick += dgv_Instructor_RowHeaderMouseDoubleClick;
            // 
            // btn_InstCourses
            // 
            btn_InstCourses.BackColor = Color.Gainsboro;
            btn_InstCourses.FlatStyle = FlatStyle.Flat;
            btn_InstCourses.ForeColor = SystemColors.ActiveCaptionText;
            btn_InstCourses.Location = new Point(12, 266);
            btn_InstCourses.Name = "btn_InstCourses";
            btn_InstCourses.Size = new Size(190, 51);
            btn_InstCourses.TabIndex = 1;
            btn_InstCourses.Text = "My Courses";
            btn_InstCourses.UseVisualStyleBackColor = false;
            btn_InstCourses.Click += btn_InstCourses_Click;
            // 
            // btn_studentCourses
            // 
            btn_studentCourses.BackColor = Color.Gainsboro;
            btn_studentCourses.FlatStyle = FlatStyle.Flat;
            btn_studentCourses.ForeColor = SystemColors.ActiveCaptionText;
            btn_studentCourses.Location = new Point(12, 349);
            btn_studentCourses.Name = "btn_studentCourses";
            btn_studentCourses.Size = new Size(190, 51);
            btn_studentCourses.TabIndex = 2;
            btn_studentCourses.Text = "Students Enrolled";
            btn_studentCourses.UseVisualStyleBackColor = false;
            btn_studentCourses.Click += btn_studentCourses_Click;
            // 
            // btn_exam
            // 
            btn_exam.BackColor = Color.Gainsboro;
            btn_exam.FlatStyle = FlatStyle.Flat;
            btn_exam.ForeColor = SystemColors.ActiveCaptionText;
            btn_exam.Location = new Point(12, 428);
            btn_exam.Name = "btn_exam";
            btn_exam.Size = new Size(190, 51);
            btn_exam.TabIndex = 3;
            btn_exam.Text = "Exams";
            btn_exam.UseVisualStyleBackColor = false;
            btn_exam.Click += btn_exam_Click;
            // 
            // lbl_inst
            // 
            lbl_inst.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_inst.ForeColor = SystemColors.ButtonHighlight;
            lbl_inst.Location = new Point(12, 26);
            lbl_inst.Name = "lbl_inst";
            lbl_inst.Size = new Size(200, 37);
            lbl_inst.TabIndex = 4;
            lbl_inst.Text = "label1";
            // 
            // btn_addExam
            // 
            btn_addExam.BackColor = Color.Firebrick;
            btn_addExam.ForeColor = SystemColors.ButtonHighlight;
            btn_addExam.Location = new Point(914, 328);
            btn_addExam.Name = "btn_addExam";
            btn_addExam.Size = new Size(190, 51);
            btn_addExam.TabIndex = 5;
            btn_addExam.Text = "Add Exam";
            btn_addExam.UseVisualStyleBackColor = false;
            btn_addExam.Click += btn_addExam_Click;
            // 
            // cb_course
            // 
            cb_course.FormattingEnabled = true;
            cb_course.Location = new Point(343, 264);
            cb_course.Name = "cb_course";
            cb_course.Size = new Size(151, 28);
            cb_course.TabIndex = 8;
            // 
            // txt_title
            // 
            txt_title.Location = new Point(343, 319);
            txt_title.Name = "txt_title";
            txt_title.Size = new Size(125, 27);
            txt_title.TabIndex = 9;
            // 
            // nud_duration
            // 
            nud_duration.Location = new Point(343, 371);
            nud_duration.Name = "nud_duration";
            nud_duration.Size = new Size(150, 27);
            nud_duration.TabIndex = 10;
            // 
            // nud_passMarks
            // 
            nud_passMarks.Location = new Point(665, 386);
            nud_passMarks.Name = "nud_passMarks";
            nud_passMarks.Size = new Size(150, 27);
            nud_passMarks.TabIndex = 11;
            // 
            // nud_totalMarks
            // 
            nud_totalMarks.Location = new Point(665, 321);
            nud_totalMarks.Name = "nud_totalMarks";
            nud_totalMarks.Size = new Size(150, 27);
            nud_totalMarks.TabIndex = 12;
            // 
            // dtp_date
            // 
            dtp_date.Location = new Point(665, 444);
            dtp_date.Name = "dtp_date";
            dtp_date.Size = new Size(250, 27);
            dtp_date.TabIndex = 13;
            dtp_date.Value = new DateTime(2025, 2, 15, 0, 0, 0, 0);
            // 
            // lbl_course
            // 
            lbl_course.AutoSize = true;
            lbl_course.Location = new Point(249, 272);
            lbl_course.Name = "lbl_course";
            lbl_course.Size = new Size(54, 20);
            lbl_course.TabIndex = 14;
            lbl_course.Text = "Course";
            // 
            // lbl_examTitle
            // 
            lbl_examTitle.AutoSize = true;
            lbl_examTitle.Location = new Point(249, 328);
            lbl_examTitle.Name = "lbl_examTitle";
            lbl_examTitle.Size = new Size(78, 20);
            lbl_examTitle.TabIndex = 15;
            lbl_examTitle.Text = "Exam Title";
            // 
            // lbl_examDuration
            // 
            lbl_examDuration.AutoSize = true;
            lbl_examDuration.Location = new Point(249, 386);
            lbl_examDuration.Name = "lbl_examDuration";
            lbl_examDuration.Size = new Size(67, 20);
            lbl_examDuration.TabIndex = 16;
            lbl_examDuration.Text = "Duration";
            // 
            // lbl_totalMars
            // 
            lbl_totalMars.AutoSize = true;
            lbl_totalMars.Location = new Point(572, 328);
            lbl_totalMars.Name = "lbl_totalMars";
            lbl_totalMars.Size = new Size(85, 20);
            lbl_totalMars.TabIndex = 17;
            lbl_totalMars.Text = "Total Marks";
            // 
            // lbl_passMarks
            // 
            lbl_passMarks.AutoSize = true;
            lbl_passMarks.Location = new Point(572, 393);
            lbl_passMarks.Name = "lbl_passMarks";
            lbl_passMarks.Size = new Size(79, 20);
            lbl_passMarks.TabIndex = 18;
            lbl_passMarks.Text = "Pass Marks";
            // 
            // lbl_date
            // 
            lbl_date.AutoSize = true;
            lbl_date.Location = new Point(572, 451);
            lbl_date.Name = "lbl_date";
            lbl_date.Size = new Size(81, 20);
            lbl_date.TabIndex = 19;
            lbl_date.Text = "Exam Date";
            // 
            // txt_instruction
            // 
            txt_instruction.Location = new Point(343, 432);
            txt_instruction.Name = "txt_instruction";
            txt_instruction.Size = new Size(125, 27);
            txt_instruction.TabIndex = 20;
            // 
            // lbl_instructions
            // 
            lbl_instructions.AutoSize = true;
            lbl_instructions.Location = new Point(253, 439);
            lbl_instructions.Name = "lbl_instructions";
            lbl_instructions.Size = new Size(84, 20);
            lbl_instructions.TabIndex = 21;
            lbl_instructions.Text = "Instructions";
            // 
            // btn_ExamQuestions
            // 
            btn_ExamQuestions.BackColor = Color.Firebrick;
            btn_ExamQuestions.ForeColor = SystemColors.ButtonHighlight;
            btn_ExamQuestions.Location = new Point(914, 264);
            btn_ExamQuestions.Name = "btn_ExamQuestions";
            btn_ExamQuestions.Size = new Size(190, 51);
            btn_ExamQuestions.TabIndex = 22;
            btn_ExamQuestions.Text = "Exam Questions";
            btn_ExamQuestions.UseVisualStyleBackColor = false;
            btn_ExamQuestions.Click += btn_ExamQuestions_Click;
            // 
            // nud_examId
            // 
            nud_examId.Location = new Point(665, 265);
            nud_examId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nud_examId.Name = "nud_examId";
            nud_examId.RightToLeft = RightToLeft.No;
            nud_examId.Size = new Size(150, 27);
            nud_examId.TabIndex = 23;
            // 
            // lbl_examId
            // 
            lbl_examId.AutoSize = true;
            lbl_examId.Location = new Point(572, 272);
            lbl_examId.Name = "lbl_examId";
            lbl_examId.Size = new Size(64, 20);
            lbl_examId.TabIndex = 24;
            lbl_examId.Text = "Exam ID";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btn_InstCourses);
            panel1.Controls.Add(btn_studentCourses);
            panel1.Controls.Add(btn_exam);
            panel1.Controls.Add(lbl_inst);
            panel1.Location = new Point(0, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(211, 491);
            panel1.TabIndex = 25;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Firebrick;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(33, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(130, 125);
            panel2.TabIndex = 5;
            // 
            // btn_previewStudent
            // 
            btn_previewStudent.BackColor = Color.Firebrick;
            btn_previewStudent.ForeColor = SystemColors.ButtonHighlight;
            btn_previewStudent.Location = new Point(914, 393);
            btn_previewStudent.Name = "btn_previewStudent";
            btn_previewStudent.Size = new Size(190, 51);
            btn_previewStudent.TabIndex = 26;
            btn_previewStudent.Text = "Preview Student";
            btn_previewStudent.UseVisualStyleBackColor = false;
            btn_previewStudent.Click += btn_previewStudent_Click;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1198, 486);
            Controls.Add(btn_previewStudent);
            Controls.Add(panel1);
            Controls.Add(lbl_examId);
            Controls.Add(nud_examId);
            Controls.Add(btn_ExamQuestions);
            Controls.Add(lbl_instructions);
            Controls.Add(txt_instruction);
            Controls.Add(lbl_date);
            Controls.Add(lbl_passMarks);
            Controls.Add(lbl_totalMars);
            Controls.Add(lbl_examDuration);
            Controls.Add(lbl_examTitle);
            Controls.Add(lbl_course);
            Controls.Add(dtp_date);
            Controls.Add(nud_totalMarks);
            Controls.Add(nud_passMarks);
            Controls.Add(nud_duration);
            Controls.Add(txt_title);
            Controls.Add(cb_course);
            Controls.Add(btn_addExam);
            Controls.Add(dgv_Instructor);
            Name = "InstructorForm";
            Text = "InstructorForm";
            Load += InstructorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Instructor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_duration).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_passMarks).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_totalMarks).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_examId).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Instructor;
        private Button btn_InstCourses;
        private Button btn_studentCourses;
        private Button btn_exam;
        private Label lbl_inst;
        private Button btn_addExam;
        private ComboBox cb_course;
        private TextBox txt_title;
        private NumericUpDown nud_duration;
        private NumericUpDown nud_passMarks;
        private NumericUpDown nud_totalMarks;
        private DateTimePicker dtp_date;
        private Label lbl_course;
        private Label lbl_examTitle;
        private Label lbl_examDuration;
        private Label lbl_totalMars;
        private Label lbl_passMarks;
        private Label lbl_date;
        private TextBox txt_instruction;
        private Label lbl_instructions;
        private Button btn_ExamQuestions;
        private NumericUpDown nud_examId;
        private Label lbl_examId;
        private Panel panel1;
        private Panel panel2;
        private Button btn_previewStudent;
    }
}