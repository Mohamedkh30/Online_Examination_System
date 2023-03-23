using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_App
{
    public partial class UpdateData : Form
    {
        private bool dragging;
        private Point lastLocation;
        private Examination_DBEntities Context;
        int ID;
        public UpdateData(int ID, string Position)
        {
            InitializeComponent();

            dragging = false;
            NameBox.Focus();
            Context = new Examination_DBEntities();

            if (Position == "Student")
            {
                Student_Data(ID);
            }
            else
            {
                Instructor_Data(ID);
            }

        }

        private void UpdateDataWin_Load(object sender, EventArgs e)
        {
            //var Depts = Context.Departments.Select(d => d.Dept_Name);
            //foreach (var dept in Depts)
            //{
            //    if (dept != null)
            //    {
            //        DeptBox.Items.Add(dept);
            //    }
            //}
        }

        /***************************************************************************************/
        // Display data
        /***************************************************************************************/
        public void Student_Data(int Stu_Id)
        {
            var Stu = Context.SelectStudentById(Stu_Id).FirstOrDefault();
            IDBox.Text = Stu.St_Id.ToString();
            PosBox.Text = "Student";
            NameBox.Text = Stu.St_Name;
            DeptBox.Text = Context.SelectDepartmentById(Stu.Dept_Id).FirstOrDefault().Dept_Name;
            EmailBox.Text = Stu.Email;
            PasswordBox.Text = Stu.Password;
        }

        public void Instructor_Data(int Ins_ID)
        {
            var Ins = Context.SelectInstructorById(Ins_ID).FirstOrDefault();
            IDBox.Text = Ins.Ins_Id.ToString();
            PosBox.Text = "Instructor";
            NameBox.Text = Ins.Ins_Name;
            DeptBox.Text = "ITI";
            EmailBox.Text = Ins.Ins_Email;
            PasswordBox.Text = Ins.Ins_Password;
        }

        /***************************************************************************************/
        // Update button
        /***************************************************************************************/
        private void UpdateInfoBtn_Click(object sender, EventArgs e)
        {
            ID = int.Parse(IDBox.Text);
            try
            {
                if (PosBox.Text == "Student")
                {
                    var Query = Context.Students.Where(s => s.St_Id == ID).Select(s => s);

                    var student = Query.FirstOrDefault();
                    student.St_Name = NameBox.Text;
                    student.Department.Dept_Name = DeptBox.Text;
                    student.Email = EmailBox.Text;
                    student.Password = PasswordBox.Text;
                }
                else
                {
                    var Query = Context.Instructors.Where(i => i.Ins_Id == ID).Select(i => i);

                    var instructor = Query.FirstOrDefault();
                    instructor.Ins_Name = NameBox.Text;
                    instructor.Ins_Email = EmailBox.Text;
                    instructor.Ins_Password = PasswordBox.Text;
                }

                Context.SaveChanges();
                MessageBox.Show("Success!", "Done");
            }
            catch
            {
                MessageBox.Show("Failed!", "Warning");
            }
        }
        /***************************************************************************************/
        // buttons hover
        /***************************************************************************************/
        private void Btn_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Violet;
        }

        private void Btn_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkMagenta;
        }

        /***************************************************************************************/
        // Delete button
        /***************************************************************************************/
        private void DeleteAccBtn_Click(object sender, EventArgs e)
        {
            try
            {
                ID = int.Parse(IDBox.Text);
                if (PosBox.Text == "Student")
                {
                    var Query = Context.Students.Where(s => s.St_Id == ID).Select(s => s);
                    var student = Query.FirstOrDefault();
                    Context.Students.Remove(student);
                }
                else
                {
                    var Query = Context.Instructors.Where(i => i.Ins_Id == ID).Select(i => i);
                    var instructor = Query.FirstOrDefault();
                    Context.Instructors.Remove(instructor);
                }
                Context.SaveChanges();
                MessageBox.Show("Success!", "Done");
            }
            catch
            {
                MessageBox.Show("Failed!", "Warning");
            }
        }

        /***************************************************************************************/
        // Close button
        /***************************************************************************************/
        private void CloseBtn_MouseEnter(object sender, EventArgs e)
        {
            CloseBtn.ForeColor = Color.DarkRed;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.ForeColor = Color.Red;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /***************************************************************************************/
        // Make the borderless form dragable
        /***************************************************************************************/
        private void UpdateData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                lastLocation = e.Location;
            }
        }

        private void UpdateData_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void UpdateData_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
    }
}
