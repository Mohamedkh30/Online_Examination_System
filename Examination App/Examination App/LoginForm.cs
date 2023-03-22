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
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            NewAccount signUpForm = new NewAccount();
            signUpForm.ShowDialog();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {
            //Examination_DBEntities context = new Examination_DBEntities();

            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            if (StudentRadioButton.Checked)
            {

            }
            else if (InstructorRadioButton.Checked)
            {
                //string msg = context.AuthInstructor(email, password).ToString();
                //MessageBox.Show(msg);
            }
        }
    }
}
