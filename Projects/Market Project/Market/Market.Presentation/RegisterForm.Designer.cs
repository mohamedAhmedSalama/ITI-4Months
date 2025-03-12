namespace Market.Presentation
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
            label1 = new Label();
            txt_usrName = new TextBox();
            txt_password = new TextBox();
            label2 = new Label();
            txt_address = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txt_mail = new TextBox();
            label5 = new Label();
            btn_register = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            btn_login = new Button();
            txt_repassword = new TextBox();
            label8 = new Label();
            cb_roles = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 24);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // txt_usrName
            // 
            txt_usrName.Location = new Point(78, 36);
            txt_usrName.Name = "txt_usrName";
            txt_usrName.Size = new Size(243, 27);
            txt_usrName.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(78, 93);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(243, 27);
            txt_password.TabIndex = 3;
            txt_password.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 119, 182);
            label2.Location = new Point(12, 66);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txt_address
            // 
            txt_address.Location = new Point(78, 232);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(243, 27);
            txt_address.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 119, 182);
            label3.Location = new Point(12, 194);
            label3.Name = "label3";
            label3.Size = new Size(86, 24);
            label3.TabIndex = 4;
            label3.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 119, 182);
            label4.Location = new Point(12, 263);
            label4.Name = "label4";
            label4.Size = new Size(52, 24);
            label4.TabIndex = 6;
            label4.Text = "Role";
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(78, 355);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(243, 27);
            txt_mail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 119, 182);
            label5.Location = new Point(12, 328);
            label5.Name = "label5";
            label5.Size = new Size(64, 24);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.DodgerBlue;
            btn_register.Location = new Point(114, 388);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(119, 50);
            btn_register.TabIndex = 10;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            btn_register.MouseLeave += btn_register_MouseLeave;
            btn_register.MouseMove += btn_register_MouseMove;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 119, 182);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btn_login);
            panel1.Location = new Point(385, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 459);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(175, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(86, 232);
            label6.Name = "label6";
            label6.Size = new Size(271, 93);
            label6.TabIndex = 10;
            label6.Text = "To Keep Connected with us please  login with your personal info";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(86, 47);
            label7.Name = "label7";
            label7.Size = new Size(255, 43);
            label7.TabIndex = 9;
            label7.Text = "Welcome Back !";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DodgerBlue;
            btn_login.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            btn_login.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btn_login.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btn_login.Location = new Point(150, 388);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(105, 50);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            btn_login.MouseLeave += btn_login_MouseLeave;
            btn_login.MouseMove += btn_login_MouseMove;
            // 
            // txt_repassword
            // 
            txt_repassword.Location = new Point(78, 165);
            txt_repassword.Name = "txt_repassword";
            txt_repassword.Size = new Size(243, 27);
            txt_repassword.TabIndex = 13;
            txt_repassword.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Book Antiqua", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 119, 182);
            label8.Location = new Point(-2, 138);
            label8.Name = "label8";
            label8.Size = new Size(181, 24);
            label8.TabIndex = 12;
            label8.Text = "Confirm Password";
            // 
            // cb_roles
            // 
            cb_roles.FormattingEnabled = true;
            cb_roles.Items.AddRange(new object[] { "user", "admin" });
            cb_roles.Location = new Point(78, 297);
            cb_roles.Name = "cb_roles";
            cb_roles.Size = new Size(243, 28);
            cb_roles.TabIndex = 12;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(cb_roles);
            Controls.Add(txt_repassword);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(btn_register);
            Controls.Add(txt_mail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_address);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(txt_usrName);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_usrName;
        private TextBox txt_password;
        private Label label2;
        private TextBox txt_address;
        private Label label3;
        private Label label4;
        private TextBox txt_mail;
        private Label label5;
        private Button btn_register;
        private Panel panel1;
        private Label label6;
        private Label label7;
        private Button btn_login;
        private PictureBox pictureBox1;
        private TextBox txt_repassword;
        private Label label8;
        private ComboBox cb_roles;
    }
}