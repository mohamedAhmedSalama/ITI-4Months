using Market.BusinessLogic;
using Market.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Market.Presentation
{
    public partial class RegisterForm : Form
    {
        UsersService usersService;
        public RegisterForm()
        {
            InitializeComponent();
            usersService = new UsersService();
            txt_password.PasswordChar = '•';
            txt_repassword.PasswordChar = '•';
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            string userName = "", password = "", address = "", mail = "", role = "", rePassword = "";
            int age = 0;
            userName = txt_usrName.Text;
            password = txt_password.Text;
            rePassword = txt_repassword.Text;
            address = txt_address.Text;
            mail = txt_mail.Text;
            role = cb_roles.SelectedItem?.ToString();
            
            if (userName == "" || password == "" || address == "" || mail == "" || role == "")
            {
                MessageBox.Show("Missing Data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                if (password.Equals(rePassword))
                {

                    if (usersService.AddUser(userName, password, address, role, mail) == 1)
                    {
                        MessageBox.Show("User is added Successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("the password should be the same", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btn_login_MouseMove(object sender, MouseEventArgs e)
        {
            btn_login.BackColor = Color.Blue;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.DodgerBlue;
        }

        private void btn_register_MouseMove(object sender, MouseEventArgs e)
        {
            btn_register.BackColor = Color.Blue;
        }

        private void btn_register_MouseLeave(object sender, EventArgs e)
        {
            btn_register.BackColor = Color.DodgerBlue;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
