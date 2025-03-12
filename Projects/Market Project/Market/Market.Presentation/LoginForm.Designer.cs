namespace Market.Presentation
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            txt_userName = new TextBox();
            btn_login = new Button();
            btn_register = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            txt_password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 119, 182);
            label1.Location = new Point(510, 139);
            label1.Name = "label1";
            label1.Size = new Size(113, 24);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 119, 182);
            label2.Location = new Point(510, 228);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(519, 173);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(195, 27);
            txt_userName.TabIndex = 3;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DodgerBlue;
            btn_login.Location = new Point(552, 357);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(105, 38);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            btn_login.MouseLeave += btn_login_MouseLeave;
            btn_login.MouseMove += btn_login_MouseMove;
            // 
            // btn_register
            // 
            btn_register.BackColor = Color.DodgerBlue;
            btn_register.FlatAppearance.BorderColor = Color.DeepSkyBlue;
            btn_register.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btn_register.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 255, 128);
            btn_register.Location = new Point(150, 360);
            btn_register.Name = "btn_register";
            btn_register.Size = new Size(105, 38);
            btn_register.TabIndex = 5;
            btn_register.Text = "Register";
            btn_register.UseVisualStyleBackColor = false;
            btn_register.Click += btn_register_Click;
            btn_register.MouseLeave += btn_register_MouseLeave;
            btn_register.MouseMove += btn_register_MouseMove;
            // 
            // label3
            // 
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Segoe Script", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 119, 182);
            label3.Location = new Point(421, 43);
            label3.Name = "label3";
            label3.Size = new Size(384, 65);
            label3.TabIndex = 6;
            label3.Text = "________Login________";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(150, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(80, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 119, 182);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btn_register);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(420, 459);
            panel1.TabIndex = 8;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(70, 246);
            label6.Name = "label6";
            label6.Size = new Size(271, 72);
            label6.TabIndex = 10;
            label6.Text = "Register if You still don't have account";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(78, 195);
            label5.Name = "label5";
            label5.Size = new Size(255, 43);
            label5.TabIndex = 9;
            label5.Text = "Create Account !";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe Script", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(99, 46);
            label4.Name = "label4";
            label4.Size = new Size(213, 43);
            label4.TabIndex = 8;
            label4.Text = "My Market";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(519, 265);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(198, 27);
            txt_password.TabIndex = 9;
            txt_password.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_password);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(btn_login);
            Controls.Add(txt_userName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "LoginForm";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_userName;
        private Button btn_login;
        private Button btn_register;
        private Label label3;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_password;
    }
}
