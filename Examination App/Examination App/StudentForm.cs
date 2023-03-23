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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            Examination_DBEntities context= new Examination_DBEntities();
            var student = context.SelectStudentById(dataContainer.id).First();
            IDlabel.Text = student.St_Id.ToString();
            Namelabel.Text = student.St_Name;
            Deplabel.Text= context.SelectDepartmentById(student.Dept_Id).First().Dept_Name;
            foreach(var dep in  context.GetStudentCourses(student.St_Id))
            {
                SubjectComboBox.Items.Add(dep);
            }

        }

        private void StudentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ExamBtn_Click(object sender, EventArgs e)
        {
            if (SubjectComboBox.Text != "")
            {
                ExamForm examForm = new ExamForm();
                examForm.ShowDialog();
            }
        }

        private void GradeBtn_Click(object sender, EventArgs e)
        {
            GradeForm gradeForm = new GradeForm();
            gradeForm.ShowDialog();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            UpdateData updateDataForm = new UpdateData(dataContainer.id, "Student");
            updateDataForm.ShowDialog();
        }
    }
}
