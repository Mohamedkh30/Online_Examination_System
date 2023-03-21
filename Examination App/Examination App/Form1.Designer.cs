namespace Examination_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Insert_Course = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delete_Course = new System.Windows.Forms.Button();
            this.Update_Course = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CoursesListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Update_Info = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert_Course
            // 
            this.Insert_Course.BackColor = System.Drawing.Color.White;
            this.Insert_Course.Location = new System.Drawing.Point(173, 387);
            this.Insert_Course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_Course.Name = "Insert_Course";
            this.Insert_Course.Size = new System.Drawing.Size(139, 46);
            this.Insert_Course.TabIndex = 51;
            this.Insert_Course.Text = "Insert Course";
            this.Insert_Course.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(894, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // Delete_Course
            // 
            this.Delete_Course.BackColor = System.Drawing.Color.White;
            this.Delete_Course.Location = new System.Drawing.Point(758, 387);
            this.Delete_Course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_Course.Name = "Delete_Course";
            this.Delete_Course.Size = new System.Drawing.Size(139, 46);
            this.Delete_Course.TabIndex = 50;
            this.Delete_Course.Text = "Delete Course";
            this.Delete_Course.UseVisualStyleBackColor = false;
            // 
            // Update_Course
            // 
            this.Update_Course.BackColor = System.Drawing.Color.White;
            this.Update_Course.Location = new System.Drawing.Point(497, 387);
            this.Update_Course.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_Course.Name = "Update_Course";
            this.Update_Course.Size = new System.Drawing.Size(139, 46);
            this.Update_Course.TabIndex = 49;
            this.Update_Course.Text = "Update Course";
            this.Update_Course.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrchid;
            this.label3.Location = new System.Drawing.Point(28, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Department";
            // 
            // CoursesListView
            // 
            this.CoursesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.CoursesListView.HideSelection = false;
            this.CoursesListView.Location = new System.Drawing.Point(96, 195);
            this.CoursesListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CoursesListView.Name = "CoursesListView";
            this.CoursesListView.Size = new System.Drawing.Size(869, 176);
            this.CoursesListView.TabIndex = 47;
            this.CoursesListView.UseCompatibleStateImageBehavior = false;
            this.CoursesListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Topic";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "No.Of Student";
            this.columnHeader4.Width = 130;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 138);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(291, 22);
            this.textBox3.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Name";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 86);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 22);
            this.textBox2.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrchid;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 42;
            this.label1.Text = "ID:";
            // 
            // Update_Info
            // 
            this.Update_Info.BackColor = System.Drawing.Color.White;
            this.Update_Info.Location = new System.Drawing.Point(812, 119);
            this.Update_Info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Update_Info.Name = "Update_Info";
            this.Update_Info.Size = new System.Drawing.Size(188, 38);
            this.Update_Info.TabIndex = 41;
            this.Update_Info.Text = "Update Info";
            this.Update_Info.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 40);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 22);
            this.textBox1.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.Insert_Course);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Delete_Course);
            this.Controls.Add(this.Update_Course);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CoursesListView);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Update_Info);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert_Course;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Delete_Course;
        private System.Windows.Forms.Button Update_Course;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView CoursesListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_Info;
        private System.Windows.Forms.TextBox textBox1;
    }
}