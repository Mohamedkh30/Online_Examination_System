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
    public partial class NewAccount : Form
    {
        private bool dragging;
        private Point lastLocation;
        private Examination_DBEntities Context;
        Student New_Student;
        Instructor New_Instructor;

        public NewAccount()
        {
            InitializeComponent();
            PositionDropList.Focus();
            dragging = false;

            Context = new Examination_DBEntities();

            try
            {
                var Depts = Context.SelectDepartments();
                foreach (var dept in Depts)
                {
                    DeptBox.Items.Add(dept.Dept_Name);
                }
            }
            catch
            {
                DeptBox.Items.Add("No Department Found!");
            }
        }

        /***************************************************************************************/
        // Create New Account button
        /***************************************************************************************/
        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (PositionDropList.Text == "" || NameBox.Text == "" || DeptBox.Text == "" || EmailBox.Text == "" || PasswordBox.Text == "")
                {
                    MessageBox.Show("Please Enter Valid Information!", "Warning");
                }
                else if (PositionDropList.Text == "Student")
                {
                    New_Student = new Student();
                    New_Student.Department = new Department();
                    New_Student.St_Name = NameBox.Text;
                    New_Student.Department.Dept_Name = DeptBox.Text;
                    New_Student.Email = EmailBox.Text;
                    New_Student.Password = PasswordBox.Text;

                    Context.Students.Add(New_Student);
                }
                else
                {
                    New_Instructor = new Instructor();
                    New_Instructor.Ins_Name = NameBox.Text;
                    New_Instructor.Ins_Email = EmailBox.Text;
                    New_Instructor.Ins_Password = PasswordBox.Text;

                    Context.Instructors.Add(New_Instructor);
                }
                Context.SaveChanges();
                MessageBox.Show("Success!", "Done");
            //}
            //catch
            //{
            //    MessageBox.Show("Failed!", "Warning");
            //}
        }


        private void CreateAccBtn_MouseEnter(object sender, EventArgs e)
        {
            CreateAccBtn.BackColor = Color.Violet;
        }

        private void CreateAccBtn_MouseLeave(object sender, EventArgs e)
        {
            CreateAccBtn.BackColor = Color.DarkMagenta;
        }

        /***************************************************************************************/
        // Close button
        /***************************************************************************************/
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBtn_MouseEnter(object sender, EventArgs e)
        {
            CloseBtn.ForeColor = Color.DarkRed;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.ForeColor = Color.Red;
        }

        /***************************************************************************************/
        // Make the borderless form dragable
        /***************************************************************************************/
        private void NewAccountWin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                lastLocation = e.Location;
            }
        }

        private void NewAccountWin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void NewAccountWin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

    }
}
