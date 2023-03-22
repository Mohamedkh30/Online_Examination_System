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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
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
    }
}
