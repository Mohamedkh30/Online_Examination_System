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
    public partial class NewAccount : Form
    {
        //SqlConnection sqlConnection;
        //SqlCommand sqlCommand;
        private bool dragging;
        private Point lastLocation;
        public NewAccount()
        {
            InitializeComponent();
            PositionDropList.Focus();
            //sqlConnection= new SqlConnection("Data Source=AHMED-HAMZA\\SQLEXPRESS;Initial Catalog=Examination_DB_Old;Integrated Security=True");
            //sqlCommand = new SqlCommand();
            //sqlCommand.Connection = sqlConnection;
            //sqlCommand.CommandText = "SELECT * FROM Employee";
            //sqlCommand.CommandType = CommandType.StoredProcedure;

            #region connected mode

            #endregion
            dragging = false;
        }

        /***************************************************************************************/
        // Create New Account button
        /***************************************************************************************/
        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            if (PositionDropList.Text == "" || NameBox.Text == "" || DeptBox.Text == "" || EmailBox.Text == "" || PasswordBox.Text == "")
            {
                MessageBox.Show("Please Enter Valid Information!", "Warning");
            }
        }

        private void CreateAccBtn_MouseEnter(object sender, EventArgs e)
        {
            CreateAccBtn.BackColor = Color.Violet;
        }

        private void CreateAccBtn_MouseLeave(object sender, EventArgs e)
        {
            CreateAccBtn.BackColor = Color.DarkMagenta;
        }

        /***************************************************************************************/
        // Close button
        /***************************************************************************************/
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBtn_MouseEnter(object sender, EventArgs e)
        {
            CloseBtn.ForeColor = Color.DarkRed;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.ForeColor = Color.Red;
        }

        /***************************************************************************************/
        // Make the borderless form dragable
        /***************************************************************************************/
        private void NewAccountWin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = true;
                lastLocation = e.Location;
            }
        }

        private void NewAccountWin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void NewAccountWin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }
    }
}
