using Market.BusinessLogic;

namespace Market.Presentation
{
    public partial class LoginForm : Form
    {

        UsersService usersService;
        public LoginForm()
        {
            InitializeComponent();

            usersService = new UsersService();
            txt_password.PasswordChar = '•';
            //txt_password.PasswordChar = '•';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = txt_userName.Text;
            string password = txt_password.Text;
            string role;
            int id;
            if (userName == "")
            {
                MessageBox.Show("Please Enter user name", "NO Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (password == "")
            {
                MessageBox.Show("Please Enter password", "NO Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //MessageBox.Show($"{userName} {password}");
            if (usersService.getUser(userName, password, out role, out id) == true)
            {
                
                role = role.ToLower();
                if (role == "admin")
                {
                    AdminForm adminForm = new AdminForm(userName);
                    adminForm.StartPosition = FormStartPosition.Manual;
                    adminForm.Location = this.Location;
                    this.Hide();
                    adminForm.ShowDialog();
                    this.Show();

                }
                else if (role == "user")
                {
                    UserForm userForm = new UserForm(id);
                    userForm.StartPosition = FormStartPosition.Manual;
                    userForm.Location = this.Location;
                    this.Hide();
                    userForm.ShowDialog();
                    this.Show();
                }
            }
            else
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            txt_userName.Text = string.Empty;
            txt_password.Text = string.Empty;
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterForm form2 = new RegisterForm();
            form2.StartPosition = FormStartPosition.Manual;
            form2.Location = this.Location;
            this.Hide();
            form2.ShowDialog();
            this.Show();
        }



        private void btn_register_MouseMove(object sender, MouseEventArgs e)
        {
            btn_register.BackColor = Color.Blue;
        }

        private void btn_register_MouseLeave(object sender, EventArgs e)
        {
            btn_register.BackColor = Color.DodgerBlue;
        }

        private void btn_login_MouseLeave(object sender, EventArgs e)
        {
            btn_login.BackColor = Color.DodgerBlue;
        }

        private void btn_login_MouseMove(object sender, MouseEventArgs e)
        {
            btn_login.BackColor = Color.Blue;
        }
    }
}
