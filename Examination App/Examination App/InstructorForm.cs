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
    public partial class InstructorForm : Form
    {
        private Examination_DBEntities Context;
        public InstructorForm(int ID)
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;

            Context = new Examination_DBEntities();
            var Ins = Context.SelectInstructorById(ID).FirstOrDefault();
            InsID.Text = Ins.Ins_Id.ToString();
            InsName.Text = Ins.Ins_Name;

            this.BackgroundImageLayout = ImageLayout.Stretch;

            var Details = Context.SelectForInstructorForm(ID);

            foreach (var detail in Details)
            {
                ListViewItem row = new ListViewItem();
                row.Text = detail.ID.ToString();
                row.SubItems.Add(detail.Course_Name);
                row.SubItems.Add(detail.Topic_Name);
                var Students = Context.Stu_Courses.Where(c => c.Cr_Id == detail.ID).Select(s => s.St_Id).Count();
                row.SubItems.Add(Students.ToString());

                CoursesListView.Items.Add(row);
            }
        }

        private void Insert_Course_Click(object sender, EventArgs e)
        {
            TopicForm Topic_Form = new TopicForm();
            Topic_Form.ShowDialog();
        }

        private void Update_Info_Click(object sender, EventArgs e)
        {
            ExamForm Exam_Form = new ExamForm();
            Exam_Form.ShowDialog();
        }

        private void InstructorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
