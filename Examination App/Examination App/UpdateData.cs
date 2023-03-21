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
    public partial class UpdateData : Form
    {
        private bool dragging;
        private Point lastLocation;
        public UpdateData()
        {
            InitializeComponent();

            dragging = false;
            NameBox.Focus();
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
