using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            EmailTextBox.Text = "sara.ahmed@example.com";
            PasswordTextBox.Text = "Password123";
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            NewAccount signUpForm = new NewAccount();
            signUpForm.ShowDialog();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            Examination_DBEntities context = new Examination_DBEntities();

            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            if (StudentRadioButton.Checked)
            {
                var msg = context.AuthStudent(email, password).First();
                if (msg == "Login Successful")
                {

                    dataContainer.id = context.SelectStudentByEmail(email).First().St_Id;
                    StudentForm studentForm = new StudentForm();
                    studentForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
            else if (InstructorRadioButton.Checked)
            {
                var msg = context.AuthInstructor(email, password).First();
                if (msg == "Login Successful")
                {
                    InstructorForm instructorForm = new InstructorForm();
                    instructorForm.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show(msg);
                }
            }
        }
    }
}
