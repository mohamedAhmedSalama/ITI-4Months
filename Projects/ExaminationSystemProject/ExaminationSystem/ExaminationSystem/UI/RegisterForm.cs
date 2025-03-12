using ExaminationSystem.BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationSystem.UI
{
    public partial class RegisterForm : Form
    {
        InstructorLogic InstructorLogic;
        StudentLogic StudentLogic;
        public RegisterForm()
        {
            InitializeComponent();
            InstructorLogic = new InstructorLogic();
            StudentLogic = new StudentLogic();
        }

        private void clear()
        {
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_mail.Text = "";
            txt_password.Text = "";
            txt_repassword.Text = "";
        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            cb_role.Items.Add("Student");
            cb_role.Items.Add("Instructor");
            cb_role.SelectedIndex = 0;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string FName = "", LName = "", password = "", mail = "", role = "", rePassword = "";

            FName = txt_fname.Text;
            LName = txt_lname.Text;
            mail = txt_mail.Text;
            password = txt_password.Text;
            rePassword = txt_repassword.Text;
            role = cb_role.SelectedItem.ToString();

            if (FName == "" || LName == "" || mail == "" || password == "" || rePassword == "")
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (password != rePassword)
                {
                    MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (role == "Instructor")
                    {
                        InstructorLogic.AddInstructor(FName, LName, mail, password);
                        MessageBox.Show("Instructor Registered Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        StudentLogic.AddStudent(FName, LName, mail, password);
                        MessageBox.Show("Student Registered Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            clear();
            this.Close();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
