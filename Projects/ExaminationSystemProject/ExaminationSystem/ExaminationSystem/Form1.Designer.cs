namespace ExaminationSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txt_mail = new TextBox();
            txt_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_login = new Button();
            btn_register = new Button();
            cb_role = new ComboBox();
            lbl_role = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(207, 103);
            txt_mail.Name = "txt_mail";
            txt_mail.PlaceholderText = "Mail";
            txt_mail.Size = new Size(198, 27);
            txt_mail.TabIndex = 0;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(207, 146);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(198, 27);
            txt_password.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(115, 110);
            label1.Name = "label1";
            label1.Size = new Size(48, 21);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(115, 152);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Firebrick;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(207, 233);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(198, 48);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.Firebrick;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btn_register.ForeColor = SystemColors.ButtonHighlight;
            btn_register.Location = new Point(254, 384);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(105, 44);
            btn_register.TabIndex = 5;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(207, 189);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(198, 28);
            cb_role.TabIndex = 6;
            // 
            // lbl_role
            // 
            lbl_role.AutoSize = true;
            lbl_role.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_role.Location = new Point(115, 196);
            lbl_role.Name = "lbl_role";
            lbl_role.Size = new Size(40, 21);
            lbl_role.TabIndex = 7;
            lbl_role.Text = "Role";
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Font = new Font("Calibri", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(81, 29);
            label3.Name = "label3";
            label3.Size = new Size(369, 50);
            label3.TabIndex = 8;
            label3.Text = "Course Examination System";
            // 
            // label4
            // 
            label4.Location = new Point(221, 338);
            label4.Name = "label4";
            label4.Size = new Size(170, 25);
            label4.TabIndex = 9;
            label4.Text = "You don't have account?";
            // 
            // label5
            // 
            label5.Location = new Point(105, 297);
            label5.Name = "label5";
            label5.Size = new Size(402, 25);
            label5.TabIndex = 10;
            label5.Text = "_________________________________________________________________";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(497, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(185, 140);
            panel1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(677, 450);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl_role);
            Controls.Add(cb_role);
            Controls.Add(btn_register);
            Controls.Add(btn_login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_password);
            Controls.Add(txt_mail);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_mail;
        private TextBox txt_password;
        private Label label1;
        private Label label2;
        private Button btn_login;
        private Button btn_register;
        private ComboBox cb_role;
        private Label lbl_role;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
    }
}
