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
    public partial class GradeForm : Form
    {
        public GradeForm()
        {
            InitializeComponent();
            Examination_DBEntities context = new Examination_DBEntities();
            var student = context.SelectStudentById(dataContainer.id).First();
            IDlabel.Text = student.St_Id.ToString();
            Namelabel.Text = student.St_Name;
            Deplabel.Text = context.SelectDepartmentById(student.Dept_Id).First().Dept_Name;



            foreach (var relation in context.SelectStuCrRelationByStu(student.St_Id))
            {
                string crId = relation.Cr_Id.ToString();
                string crName = context.SelectCourseById(relation.Cr_Id).First().Cr_Name;
                string crGrade = relation.Cr_grade.ToString();

                if (crGrade == "")
                {
                    crGrade = "didn't take the exam";
                }

                ListViewItem item = new ListViewItem(new string[] { crId, crName, crGrade} );

                listView1.Items.Add(item);
            }

        }
    }
}
