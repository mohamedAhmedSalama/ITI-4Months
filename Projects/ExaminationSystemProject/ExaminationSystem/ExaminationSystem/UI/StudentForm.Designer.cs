namespace ExaminationSystem.UI
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            dgv_couses = new DataGridView();
            btn_mycourses = new Button();
            btn_courses = new Button();
            btn_exam = new Button();
            lbl_student = new Label();
            txt_courseName = new TextBox();
            txt_courseDesc = new TextBox();
            txt_courseCreated = new TextBox();
            txt_instructorName = new TextBox();
            lbl_courseId = new Label();
            lbl_courseName = new Label();
            lbl_courseDesc = new Label();
            lbl_dateCreated = new Label();
            lbl_instructorName = new Label();
            btn_addCourse = new Button();
            nud_courseId = new NumericUpDown();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgv_couses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_courseId).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_couses
            // 
            dgv_couses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_couses.Location = new Point(216, 0);
            dgv_couses.Name = "dgv_couses";
            dgv_couses.RowHeadersWidth = 51;
            dgv_couses.Size = new Size(583, 214);
            dgv_couses.TabIndex = 0;
            dgv_couses.RowHeaderMouseDoubleClick += dgv_couses_RowHeaderMouseDoubleClick;
            // 
            // btn_mycourses
            // 
            btn_mycourses.BackColor = Color.Gainsboro;
            btn_mycourses.FlatStyle = FlatStyle.Flat;
            btn_mycourses.Location = new Point(26, 219);
            btn_mycourses.Name = "btn_mycourses";
            btn_mycourses.Size = new Size(160, 49);
            btn_mycourses.TabIndex = 1;
            btn_mycourses.Text = "My Courses";
            btn_mycourses.UseVisualStyleBackColor = false;
            btn_mycourses.Click += btn_mycourses_Click;
            // 
            // btn_courses
            // 
            btn_courses.BackColor = Color.Gainsboro;
            btn_courses.FlatStyle = FlatStyle.Flat;
            btn_courses.Location = new Point(26, 289);
            btn_courses.Name = "btn_courses";
            btn_courses.Size = new Size(160, 49);
            btn_courses.TabIndex = 2;
            btn_courses.Text = "Courses";
            btn_courses.UseVisualStyleBackColor = false;
            btn_courses.Click += btn_courses_Click;
            // 
            // btn_exam
            // 
            btn_exam.BackColor = Color.Gainsboro;
            btn_exam.FlatStyle = FlatStyle.Flat;
            btn_exam.Location = new Point(26, 361);
            btn_exam.Name = "btn_exam";
            btn_exam.Size = new Size(160, 49);
            btn_exam.TabIndex = 3;
            btn_exam.Text = "My Exams";
            btn_exam.UseVisualStyleBackColor = false;
            btn_exam.Click += btn_exam_Click;
            // 
            // lbl_student
            // 
            lbl_student.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_student.ForeColor = SystemColors.ButtonHighlight;
            lbl_student.Location = new Point(12, 9);
            lbl_student.Name = "lbl_student";
            lbl_student.Size = new Size(198, 36);
            lbl_student.TabIndex = 4;
            lbl_student.Text = "label1";
            // 
            // txt_courseName
            // 
            txt_courseName.Location = new Point(328, 327);
            txt_courseName.Name = "txt_courseName";
            txt_courseName.Size = new Size(167, 27);
            txt_courseName.TabIndex = 6;
            // 
            // txt_courseDesc
            // 
            txt_courseDesc.Location = new Point(371, 383);
            txt_courseDesc.Name = "txt_courseDesc";
            txt_courseDesc.Size = new Size(293, 27);
            txt_courseDesc.TabIndex = 7;
            // 
            // txt_courseCreated
            // 
            txt_courseCreated.Location = new Point(651, 270);
            txt_courseCreated.Name = "txt_courseCreated";
            txt_courseCreated.Size = new Size(125, 27);
            txt_courseCreated.TabIndex = 8;
            // 
            // txt_instructorName
            // 
            txt_instructorName.Location = new Point(651, 323);
            txt_instructorName.Name = "txt_instructorName";
            txt_instructorName.Size = new Size(125, 27);
            txt_instructorName.TabIndex = 9;
            // 
            // lbl_courseId
            // 
            lbl_courseId.AutoSize = true;
            lbl_courseId.Location = new Point(224, 277);
            lbl_courseId.Name = "lbl_courseId";
            lbl_courseId.Size = new Size(73, 20);
            lbl_courseId.TabIndex = 10;
            lbl_courseId.Text = "Course ID";
            // 
            // lbl_courseName
            // 
            lbl_courseName.AutoSize = true;
            lbl_courseName.Location = new Point(224, 330);
            lbl_courseName.Name = "lbl_courseName";
            lbl_courseName.Size = new Size(98, 20);
            lbl_courseName.TabIndex = 11;
            lbl_courseName.Text = "Course Name";
            // 
            // lbl_courseDesc
            // 
            lbl_courseDesc.AutoSize = true;
            lbl_courseDesc.Location = new Point(231, 387);
            lbl_courseDesc.Name = "lbl_courseDesc";
            lbl_courseDesc.Size = new Size(134, 20);
            lbl_courseDesc.TabIndex = 12;
            lbl_courseDesc.Text = "Course Description";
            // 
            // lbl_dateCreated
            // 
            lbl_dateCreated.AutoSize = true;
            lbl_dateCreated.Location = new Point(499, 273);
            lbl_dateCreated.Name = "lbl_dateCreated";
            lbl_dateCreated.Size = new Size(146, 20);
            lbl_dateCreated.TabIndex = 13;
            lbl_dateCreated.Text = "Course Date Created";
            // 
            // lbl_instructorName
            // 
            lbl_instructorName.AutoSize = true;
            lbl_instructorName.Location = new Point(501, 326);
            lbl_instructorName.Name = "lbl_instructorName";
            lbl_instructorName.Size = new Size(120, 20);
            lbl_instructorName.TabIndex = 14;
            lbl_instructorName.Text = "Course Instructor";
            // 
            // btn_addCourse
            // 
            btn_addCourse.BackColor = Color.Firebrick;
            btn_addCourse.FlatStyle = FlatStyle.Flat;
            btn_addCourse.ForeColor = SystemColors.ButtonHighlight;
            btn_addCourse.Location = new Point(682, 383);
            btn_addCourse.Name = "btn_addCourse";
            btn_addCourse.Size = new Size(106, 55);
            btn_addCourse.TabIndex = 15;
            btn_addCourse.Text = "Add Course";
            btn_addCourse.UseVisualStyleBackColor = false;
            btn_addCourse.Click += btn_addCourse_Click;
            // 
            // nud_courseId
            // 
            nud_courseId.Location = new Point(323, 275);
            nud_courseId.Name = "nud_courseId";
            nud_courseId.Size = new Size(150, 27);
            nud_courseId.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Firebrick;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lbl_student);
            panel1.Controls.Add(btn_mycourses);
            panel1.Controls.Add(btn_courses);
            panel1.Controls.Add(btn_exam);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 451);
            panel1.TabIndex = 17;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Zoom;
            panel2.Location = new Point(3, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 125);
            panel2.TabIndex = 5;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(nud_courseId);
            Controls.Add(btn_addCourse);
            Controls.Add(lbl_instructorName);
            Controls.Add(lbl_dateCreated);
            Controls.Add(lbl_courseDesc);
            Controls.Add(lbl_courseName);
            Controls.Add(lbl_courseId);
            Controls.Add(txt_instructorName);
            Controls.Add(txt_courseCreated);
            Controls.Add(txt_courseDesc);
            Controls.Add(txt_courseName);
            Controls.Add(dgv_couses);
            Name = "StudentForm";
            Text = "StudentForm";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_couses).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_courseId).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_couses;
        private Button btn_mycourses;
        private Button btn_courses;
        private Button btn_exam;
        private Label lbl_student;
        private TextBox txt_courseName;
        private TextBox txt_courseDesc;
        private TextBox txt_courseCreated;
        private TextBox txt_instructorName;
        private Label lbl_courseId;
        private Label lbl_courseName;
        private Label lbl_courseDesc;
        private Label lbl_dateCreated;
        private Label lbl_instructorName;
        private Button btn_addCourse;
        private NumericUpDown nud_courseId;
        private Panel panel1;
        private Panel panel2;
    }
}