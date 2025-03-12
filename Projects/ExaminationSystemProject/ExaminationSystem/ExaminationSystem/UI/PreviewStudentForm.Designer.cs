namespace ExaminationSystem.UI
{
    partial class PreviewStudentForm
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
            dgv_preview = new DataGridView();
            txt_feedback = new TextBox();
            label1 = new Label();
            btn_ShowAnswers = new Button();
            txt_reload = new Button();
            btn_feedback = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_preview).BeginInit();
            SuspendLayout();
            // 
            // dgv_preview
            // 
            dgv_preview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_preview.Location = new Point(0, 0);
            dgv_preview.Name = "dgv_preview";
            dgv_preview.RowHeadersWidth = 51;
            dgv_preview.Size = new Size(798, 308);
            dgv_preview.TabIndex = 0;
            dgv_preview.RowHeaderMouseDoubleClick += dgv_preview_RowHeaderMouseDoubleClick;
            // 
            // txt_feedback
            // 
            txt_feedback.Location = new Point(105, 362);
            txt_feedback.Name = "txt_feedback";
            txt_feedback.Size = new Size(125, 27);
            txt_feedback.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 365);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 2;
            label1.Text = "FeedBack";
            // 
            // btn_ShowAnswers
            // 
            btn_ShowAnswers.BackColor = Color.Firebrick;
            btn_ShowAnswers.Font = new Font("Segoe UI", 10.2F);
            btn_ShowAnswers.ForeColor = SystemColors.ButtonHighlight;
            btn_ShowAnswers.Location = new Point(423, 354);
            btn_ShowAnswers.Name = "btn_ShowAnswers";
            btn_ShowAnswers.Size = new Size(187, 40);
            btn_ShowAnswers.TabIndex = 3;
            btn_ShowAnswers.Text = "Show Exam Answers";
            btn_ShowAnswers.UseVisualStyleBackColor = false;
            btn_ShowAnswers.Click += btn_ShowAnswers_Click;
            // 
            // txt_reload
            // 
            txt_reload.BackColor = Color.Firebrick;
            txt_reload.Font = new Font("Segoe UI", 10.2F);
            txt_reload.ForeColor = SystemColors.ButtonHighlight;
            txt_reload.Location = new Point(616, 354);
            txt_reload.Name = "txt_reload";
            txt_reload.Size = new Size(169, 40);
            txt_reload.TabIndex = 4;
            txt_reload.Text = "Reload";
            txt_reload.UseVisualStyleBackColor = false;
            txt_reload.Click += txt_reload_Click;
            // 
            // btn_feedback
            // 
            btn_feedback.BackColor = Color.Firebrick;
            btn_feedback.Font = new Font("Segoe UI", 10.2F);
            btn_feedback.ForeColor = SystemColors.ButtonHighlight;
            btn_feedback.Location = new Point(248, 354);
            btn_feedback.Name = "btn_feedback";
            btn_feedback.Size = new Size(169, 40);
            btn_feedback.TabIndex = 5;
            btn_feedback.Text = "Add FeedBack";
            btn_feedback.UseVisualStyleBackColor = false;
            btn_feedback.Click += btn_feedback_Click;
            // 
            // PreviewStudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_feedback);
            Controls.Add(txt_reload);
            Controls.Add(btn_ShowAnswers);
            Controls.Add(label1);
            Controls.Add(txt_feedback);
            Controls.Add(dgv_preview);
            Name = "PreviewStudentForm";
            Text = "PreviewStudentForm";
            Load += PreviewStudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_preview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_preview;
        private TextBox txt_feedback;
        private Label label1;
        private Button btn_ShowAnswers;
        private Button txt_reload;
        private Button btn_feedback;
    }
}