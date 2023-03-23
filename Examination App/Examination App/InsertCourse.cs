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
    public partial class InsertCourse : Form
    {
        Examination_DBEntities1 Entity;

        public InsertCourse()
        {
            InitializeComponent();
            Entity = new Examination_DBEntities1();
            int r = Entity.Courses.Count()+1;
            textBox1.Text = r.ToString();
            textBox1.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           var Result = Entity.Insert_Course(textBox2.Text);
            button1.Enabled= false;
            MessageBox.Show($"{Result} row Affected");


        }
    }
}
