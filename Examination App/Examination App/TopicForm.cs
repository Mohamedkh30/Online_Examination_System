using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examination_App
{
    public partial class TopicForm : Form
    {
        Examination_DBEntities1 Entity;
        ObjectResult<SelectCourseById_Result> courseList;
        SelectCourseById_Result CurrentCourse;
        List <int> NotAvillableIDs;
        public TopicForm()
        {
            InitializeComponent();
            CourseID = 4;
            Entity= new Examination_DBEntities1();
            courseList = Entity.SelectCourseById(CourseID);
            NotAvillableIDs = new List<int>();

            foreach (var c in courseList)
            {
                CurrentCourse = c;
            }
            var Topics =  Entity.SelectCourseTopics(4);
            foreach ( var topic in Topics )
            {
                this.TopicList.Items.Add(topic);
                TopicList.Text = topic; 
            }
            textBox1.Text = textBox4.Text = CourseID.ToString();
            textBox2.Text = CurrentCourse.Cr_Name;
            textBox1.Enabled= false;
            textBox2.Enabled = false;


            foreach ( Course c in Entity.Courses)
            {
                NotAvillableIDs.Add(c.Cr_Id);
            }
            
        }


        public int CourseID { set; get; }
        private void button1_Click(object sender, EventArgs e)
        {
           

                var Result = Entity.UpdateCourseName(int.Parse(textBox1.Text), textBox3.Text);
            if (Result>0)
            {
               textBox2.Text = textBox3.Text;
                textBox3.Text = "";
            MessageBox.Show($"{Result} row Affected");

            }
            else
            {
                MessageBox.Show($"Invalid Data");

            }

        }
    }
}
//Linux Essentials