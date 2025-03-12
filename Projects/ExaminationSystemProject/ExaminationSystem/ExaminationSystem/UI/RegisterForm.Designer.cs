namespace ExaminationSystem.UI
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            txt_fname = new TextBox();
            txt_lname = new TextBox();
            txt_mail = new TextBox();
            txt_password = new TextBox();
            txt_repassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            cb_role = new ComboBox();
            label6 = new Label();
            btn_register = new Button();
            btn_login = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // txt_fname
            // 
            txt_fname.Location = new Point(143, 121);
            txt_fname.Name = "txt_fname";
            txt_fname.PlaceholderText = "First Name";
            txt_fname.Size = new Size(151, 27);
            txt_fname.TabIndex = 0;
            // 
            // txt_lname
            // 
            txt_lname.Location = new Point(143, 173);
            txt_lname.Name = "txt_lname";
            txt_lname.PlaceholderText = "Last Name";
            txt_lname.Size = new Size(151, 27);
            txt_lname.TabIndex = 1;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(143, 225);
            txt_mail.Name = "txt_mail";
            txt_mail.PlaceholderText = "EMail";
            txt_mail.Size = new Size(151, 27);
            txt_mail.TabIndex = 2;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(143, 277);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(151, 27);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // txt_repassword
            // 
            txt_repassword.Location = new Point(143, 329);
            txt_repassword.Name = "txt_repassword";
            txt_repassword.PlaceholderText = "ReEnter Password";
            txt_repassword.Size = new Size(151, 27);
            txt_repassword.TabIndex = 4;
            txt_repassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 124);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 177);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 7;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 232);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 284);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 332);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 10;
            label5.Text = "RePassword";
            // 
            // cb_role
            // 
            cb_role.FormattingEnabled = true;
            cb_role.Location = new Point(143, 381);
            cb_role.Name = "cb_role";
            cb_role.Size = new Size(151, 28);
            cb_role.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 384);
            label6.Name = "label6";
            label6.Size = new Size(39, 20);
            label6.TabIndex = 12;
            label6.Text = "Role";
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.Firebrick;
            btn_register.FlatStyle = FlatStyle.Flat;
            btn_register.ForeColor = SystemColors.ButtonHighlight;
            btn_register.Location = new Point(68, 420);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(123, 39);
            btn_register.TabIndex = 13;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Firebrick;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = SystemColors.ButtonHighlight;
            btn_login.Location = new Point(218, 420);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(123, 39);
            btn_login.TabIndex = 14;
            btn_login.Text = "Back To Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(87, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 115);
            panel1.TabIndex = 15;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(402, 476);
            Controls.Add(panel1);
            Controls.Add(btn_login);
            Controls.Add(btn_register);
            Controls.Add(label6);
            Controls.Add(cb_role);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_repassword);
            Controls.Add(txt_password);
            Controls.Add(txt_mail);
            Controls.Add(txt_lname);
            Controls.Add(txt_fname);
            Name = "RegisterForm";
            Text = "RegisterForm";
            Load += RegisterForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_fname;
        private TextBox txt_lname;
        private TextBox txt_mail;
        private TextBox txt_password;
        private TextBox txt_repassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cb_role;
        private Label label6;
        private Button btn_register;
        private Button btn_login;
        private Panel panel1;
    }
}