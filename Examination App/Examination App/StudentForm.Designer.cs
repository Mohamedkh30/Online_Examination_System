namespace Examination_App
{
    partial class StudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDlabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Deplabel = new System.Windows.Forms.Label();
            this.SubjectComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ExamBtn = new System.Windows.Forms.Button();
            this.GradeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name :";
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.IDlabel.ForeColor = System.Drawing.Color.White;
            this.IDlabel.Location = new System.Drawing.Point(71, 21);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(60, 20);
            this.IDlabel.TabIndex = 4;
            this.IDlabel.Text = "std_id";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.BackColor = System.Drawing.Color.Transparent;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Namelabel.ForeColor = System.Drawing.Color.White;
            this.Namelabel.Location = new System.Drawing.Point(100, 62);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(90, 20);
            this.Namelabel.TabIndex = 5;
            this.Namelabel.Text = "std_name";
            // 
            // Deplabel
            // 
            this.Deplabel.AutoSize = true;
            this.Deplabel.BackColor = System.Drawing.Color.Transparent;
            this.Deplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.Deplabel.ForeColor = System.Drawing.Color.White;
            this.Deplabel.Location = new System.Drawing.Point(150, 105);
            this.Deplabel.Name = "Deplabel";
            this.Deplabel.Size = new System.Drawing.Size(75, 20);
            this.Deplabel.TabIndex = 6;
            this.Deplabel.Text = "std_dep";
            // 
            // SubjectComboBox
            // 
            this.SubjectComboBox.FormattingEnabled = true;
            this.SubjectComboBox.Location = new System.Drawing.Point(197, 166);
            this.SubjectComboBox.Name = "SubjectComboBox";
            this.SubjectComboBox.Size = new System.Drawing.Size(240, 24);
            this.SubjectComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select Subject :";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(340, 21);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(74, 51);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update Info";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // ExamBtn
            // 
            this.ExamBtn.Location = new System.Drawing.Point(123, 220);
            this.ExamBtn.Name = "ExamBtn";
            this.ExamBtn.Size = new System.Drawing.Size(233, 29);
            this.ExamBtn.TabIndex = 10;
            this.ExamBtn.Text = "Take new Exam";
            this.ExamBtn.UseVisualStyleBackColor = true;
            // 
            // GradeBtn
            // 
            this.GradeBtn.Location = new System.Drawing.Point(123, 281);
            this.GradeBtn.Name = "GradeBtn";
            this.GradeBtn.Size = new System.Drawing.Size(233, 29);
            this.GradeBtn.TabIndex = 11;
            this.GradeBtn.Text = "Show Previous Grade";
            this.GradeBtn.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(471, 361);
            this.Controls.Add(this.GradeBtn);
            this.Controls.Add(this.SubjectComboBox);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExamBtn);
            this.Controls.Add(this.Deplabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Deplabel;
        private System.Windows.Forms.ComboBox SubjectComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ExamBtn;
        private System.Windows.Forms.Button GradeBtn;
    }
}