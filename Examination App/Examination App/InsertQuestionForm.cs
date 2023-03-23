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
    public partial class InsertQuestionForm : Form
    {
        int Exam_Num;
        Examination_DBEntities1 Entity;
        int result;
        public InsertQuestionForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Exam_Num = 70;

            Entity = new Examination_DBEntities1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             result = Entity.InsertQuestionToExam(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,Exam_Num.ToString());
                MessageBox.Show(result.ToString());
               
          

        }
    }
}
