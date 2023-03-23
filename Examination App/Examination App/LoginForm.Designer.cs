namespace Examination_App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignInBtn = new System.Windows.Forms.Button();
            this.SignUpBtn = new System.Windows.Forms.Button();
            this.StudentRadioButton = new System.Windows.Forms.RadioButton();
            this.InstructorRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailTextBox.Location = new System.Drawing.Point(19, 35);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(148, 20);
            this.EmailTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(19, 84);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(149, 20);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 31);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 123);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // SignInBtn
            // 
            this.SignInBtn.Location = new System.Drawing.Point(19, 161);
            this.SignInBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignInBtn.Name = "SignInBtn";
            this.SignInBtn.Size = new System.Drawing.Size(57, 23);
            this.SignInBtn.TabIndex = 5;
            this.SignInBtn.Text = "Sign In";
            this.SignInBtn.UseVisualStyleBackColor = true;
            this.SignInBtn.Click += new System.EventHandler(this.SignInBtn_Click);
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.Location = new System.Drawing.Point(100, 161);
            this.SignUpBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.Size = new System.Drawing.Size(66, 23);
            this.SignUpBtn.TabIndex = 6;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.UseVisualStyleBackColor = true;
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // StudentRadioButton
            // 
            this.StudentRadioButton.AutoSize = true;
            this.StudentRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.StudentRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.StudentRadioButton.ForeColor = System.Drawing.Color.White;
            this.StudentRadioButton.Location = new System.Drawing.Point(37, 110);
            this.StudentRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentRadioButton.Name = "StudentRadioButton";
            this.StudentRadioButton.Size = new System.Drawing.Size(82, 21);
            this.StudentRadioButton.TabIndex = 7;
            this.StudentRadioButton.TabStop = true;
            this.StudentRadioButton.Text = "Student";
            this.StudentRadioButton.UseVisualStyleBackColor = false;
            // 
            // InstructorRadioButton
            // 
            this.InstructorRadioButton.AutoSize = true;
            this.InstructorRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.InstructorRadioButton.Checked = true;
            this.InstructorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.InstructorRadioButton.ForeColor = System.Drawing.Color.White;
            this.InstructorRadioButton.Location = new System.Drawing.Point(37, 134);
            this.InstructorRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InstructorRadioButton.Name = "InstructorRadioButton";
            this.InstructorRadioButton.Size = new System.Drawing.Size(95, 21);
            this.InstructorRadioButton.TabIndex = 8;
            this.InstructorRadioButton.TabStop = true;
            this.InstructorRadioButton.Text = "Instructor";
            this.InstructorRadioButton.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(341, 203);
            this.Controls.Add(this.InstructorRadioButton);
            this.Controls.Add(this.StudentRadioButton);
            this.Controls.Add(this.SignUpBtn);
            this.Controls.Add(this.SignInBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SignInBtn;
        private System.Windows.Forms.Button SignUpBtn;
        private System.Windows.Forms.RadioButton StudentRadioButton;
        private System.Windows.Forms.RadioButton InstructorRadioButton;
    }
}

