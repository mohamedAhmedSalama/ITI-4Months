namespace ExaminationSystem.UI
{
    partial class StartExamForm
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
            btn_submit = new Button();
            btn_next = new Button();
            btn_prev = new Button();
            btn_option1 = new Button();
            btn_option2 = new Button();
            btn_option3 = new Button();
            btn_option4 = new Button();
            lbl_question = new Label();
            lbl_timer = new Label();
            SuspendLayout();
            // 
            // btn_submit
            // 
            btn_submit.BackColor = Color.DarkRed;
            btn_submit.FlatStyle = FlatStyle.Flat;
            btn_submit.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            btn_submit.ForeColor = SystemColors.ButtonHighlight;
            btn_submit.Location = new Point(442, 7);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(468, 69);
            btn_submit.TabIndex = 0;
            btn_submit.Text = "Submit/End Exam";
            btn_submit.UseVisualStyleBackColor = false;
            btn_submit.Click += btn_submit_Click;
            // 
            // btn_next
            // 
            btn_next.BackColor = Color.DarkGray;
            btn_next.FlatStyle = FlatStyle.Flat;
            btn_next.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            btn_next.ForeColor = SystemColors.ButtonHighlight;
            btn_next.Location = new Point(981, 7);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(377, 69);
            btn_next.TabIndex = 1;
            btn_next.Text = "Next Question";
            btn_next.UseVisualStyleBackColor = false;
            btn_next.Click += btn_next_Click;
            // 
            // btn_prev
            // 
            btn_prev.BackColor = Color.DarkGray;
            btn_prev.FlatStyle = FlatStyle.Flat;
            btn_prev.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            btn_prev.ForeColor = SystemColors.ButtonHighlight;
            btn_prev.Location = new Point(7, 7);
            btn_prev.Name = "btn_prev";
            btn_prev.Size = new Size(377, 69);
            btn_prev.TabIndex = 2;
            btn_prev.Text = "Prev Question";
            btn_prev.UseVisualStyleBackColor = false;
            btn_prev.Click += btn_prev_Click;
            // 
            // btn_option1
            // 
            btn_option1.BackColor = Color.Firebrick;
            btn_option1.FlatStyle = FlatStyle.Flat;
            btn_option1.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            btn_option1.ForeColor = SystemColors.ButtonHighlight;
            btn_option1.Location = new Point(7, 226);
            btn_option1.Name = "btn_option1";
            btn_option1.Size = new Size(1351, 97);
            btn_option1.TabIndex = 3;
            btn_option1.Text = "Option1";
            btn_option1.UseVisualStyleBackColor = false;
            btn_option1.Click += btn_option1_Click;
            // 
            // btn_option2
            // 
            btn_option2.BackColor = Color.Firebrick;
            btn_option2.FlatStyle = FlatStyle.Flat;
            btn_option2.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            btn_option2.ForeColor = SystemColors.ButtonHighlight;
            btn_option2.Location = new Point(12, 349);
            btn_option2.Name = "btn_option2";
            btn_option2.Size = new Size(1351, 97);
            btn_option2.TabIndex = 4;
            btn_option2.Text = "Option2";
            btn_option2.UseVisualStyleBackColor = false;
            btn_option2.Click += btn_option2_Click;
            // 
            // btn_option3
            // 
            btn_option3.BackColor = Color.Firebrick;
            btn_option3.FlatStyle = FlatStyle.Flat;
            btn_option3.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            btn_option3.ForeColor = SystemColors.ButtonHighlight;
            btn_option3.Location = new Point(22, 476);
            btn_option3.Name = "btn_option3";
            btn_option3.Size = new Size(1351, 97);
            btn_option3.TabIndex = 5;
            btn_option3.Text = "Option3";
            btn_option3.UseVisualStyleBackColor = false;
            btn_option3.Click += btn_option3_Click;
            // 
            // btn_option4
            // 
            btn_option4.BackColor = Color.Firebrick;
            btn_option4.FlatStyle = FlatStyle.Flat;
            btn_option4.Font = new Font("Calibri", 16.2F, FontStyle.Bold);
            btn_option4.ForeColor = SystemColors.ButtonHighlight;
            btn_option4.Location = new Point(12, 594);
            btn_option4.Name = "btn_option4";
            btn_option4.Size = new Size(1351, 97);
            btn_option4.TabIndex = 6;
            btn_option4.Text = "Option4";
            btn_option4.UseVisualStyleBackColor = false;
            btn_option4.Click += btn_option4_Click;
            // 
            // lbl_question
            // 
            lbl_question.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_question.Location = new Point(12, 90);
            lbl_question.Name = "lbl_question";
            lbl_question.Size = new Size(1356, 70);
            lbl_question.TabIndex = 7;
            lbl_question.Text = "label1";
            // 
            // lbl_timer
            // 
            lbl_timer.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_timer.Location = new Point(442, 171);
            lbl_timer.Name = "lbl_timer";
            lbl_timer.Size = new Size(468, 41);
            lbl_timer.TabIndex = 8;
            lbl_timer.Text = "Timer";
            // 
            // StartExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1370, 703);
            Controls.Add(lbl_timer);
            Controls.Add(lbl_question);
            Controls.Add(btn_option4);
            Controls.Add(btn_option3);
            Controls.Add(btn_option2);
            Controls.Add(btn_option1);
            Controls.Add(btn_prev);
            Controls.Add(btn_next);
            Controls.Add(btn_submit);
            Name = "StartExamForm";
            Text = "StartExamForm";
            Load += StartExamForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_submit;
        private Button btn_next;
        private Button btn_prev;
        private Button btn_option1;
        private Button btn_option2;
        private Button btn_option3;
        private Button btn_option4;
        private Label lbl_question;
        private Label lbl_timer;
    }
}