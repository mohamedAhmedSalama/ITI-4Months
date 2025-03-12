using ExaminationSystem.BusinessLogic;
using ExaminationSystem.UI;

namespace ExaminationSystem
{
    public partial class Form1 : Form
    {
        StudentLogic studentLogic;
        InstructorLogic InstructorLogic;
        
        public Form1()
        {
            InitializeComponent();
            studentLogic = new StudentLogic();
            InstructorLogic = new InstructorLogic();
            txt_password.PasswordChar = '•';
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cb_role.Items.Add("Student");
            cb_role.Items.Add("Instructor");
            cb_role.SelectedIndex = 0;
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txt_mail.Text;
            string password = txt_password.Text;
            string role = cb_role.SelectedItem.ToString();
            string name;
            txt_mail.Text = "";
            txt_password.Text = "";
            int id;
            if (email == "" || password == "")
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (role == "Instructor")
                {
                    if (InstructorLogic.IsInstructor(email, password, out name, out id))
                    {
                        goToInstructorForm(name, id);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (studentLogic.IsStudent(email, password, out name, out id))
                    {
                        goToStudentForm(name, id);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Email or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void goToInstructorForm(string name, int id)
        {
            InstructorForm form = new InstructorForm(name, id);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void goToStudentForm(string name, int id)
        {
            StudentForm form = new StudentForm(name, id);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.StartPosition = FormStartPosition.Manual;
            form.Location = this.Location;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
