using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Examination_App
{
    public partial class QuestionForm : Form
    {
        int Exam_Num =70 ;
        Examination_DBEntities1 Entity;
        
        public QuestionForm()
        {
            InitializeComponent();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            Entity= new Examination_DBEntities1();
            var Questions = Entity.SelectQuestionByExam(Exam_Num.ToString());
            foreach (var q in Questions)
            {
               
                ListViewItem item = new ListViewItem(q.Q_Id.ToString());
                item.SubItems.Add(q.Q_Content);
                QuestionView.Items.Add( item);


            }
            


        }

      

        private void Insert_Click(object sender, EventArgs e)
        {
            InsertQuestionForm QuestionForm  = new InsertQuestionForm();
            QuestionForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = QuestionView.SelectedItems[0];
            string selectedValue = selectedItem.SubItems[0].Text;
            MessageBox.Show(selectedValue);
            Entity.deleteQuestionfromExam(selectedValue, Exam_Num.ToString());
            QuestionView.Items.Clear();
            var Questions = Entity.SelectQuestionByExam(Exam_Num.ToString());

            foreach (var q in Questions)
            {

                ListViewItem item = new ListViewItem(q.Q_Id.ToString());
                item.SubItems.Add(q.Q_Content);
                QuestionView.Items.Add(item);


            }



        }
    }
}
