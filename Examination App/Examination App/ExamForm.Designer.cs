namespace Examination_App
{
    partial class ExamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamForm));
            this.time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuestionContent = new System.Windows.Forms.Label();
            this.Current_Question_Label = new System.Windows.Forms.Label();
            this.Questions_List = new System.Windows.Forms.ListBox();
            this.PrevButton = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(669, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(21, 16);
            this.time.TabIndex = 26;
            this.time.Text = "60";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(628, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Time : ";
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.White;
            this.NextButton.Location = new System.Drawing.Point(424, 404);
            this.NextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(125, 38);
            this.NextButton.TabIndex = 24;
            this.NextButton.Text = "Next>>";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.QuestionContent);
            this.panel1.Location = new System.Drawing.Point(12, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 82);
            this.panel1.TabIndex = 23;
            // 
            // QuestionContent
            // 
            this.QuestionContent.AutoSize = true;
            this.QuestionContent.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionContent.ForeColor = System.Drawing.Color.White;
            this.QuestionContent.Location = new System.Drawing.Point(3, 14);
            this.QuestionContent.Name = "QuestionContent";
            this.QuestionContent.Size = new System.Drawing.Size(0, 29);
            this.QuestionContent.TabIndex = 23;
            // 
            // Current_Question_Label
            // 
            this.Current_Question_Label.AutoSize = true;
            this.Current_Question_Label.Location = new System.Drawing.Point(350, 38);
            this.Current_Question_Label.Name = "Current_Question_Label";
            this.Current_Question_Label.Size = new System.Drawing.Size(104, 16);
            this.Current_Question_Label.TabIndex = 22;
            this.Current_Question_Label.Text = "Qustion XX Of 10";
            // 
            // Questions_List
            // 
            this.Questions_List.BackColor = System.Drawing.Color.DarkMagenta;
            this.Questions_List.FormattingEnabled = true;
            this.Questions_List.ItemHeight = 16;
            this.Questions_List.Location = new System.Drawing.Point(644, 167);
            this.Questions_List.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Questions_List.Name = "Questions_List";
            this.Questions_List.Size = new System.Drawing.Size(128, 228);
            this.Questions_List.TabIndex = 21;
            this.Questions_List.SelectedIndexChanged += new System.EventHandler(this.Questions_List_SelectedIndexChanged);
            // 
            // PrevButton
            // 
            this.PrevButton.BackColor = System.Drawing.Color.White;
            this.PrevButton.Location = new System.Drawing.Point(136, 404);
            this.PrevButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(121, 38);
            this.PrevButton.TabIndex = 20;
            this.PrevButton.Text = "<<Prev";
            this.PrevButton.UseVisualStyleBackColor = false;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.Color.Brown;
            this.Submit.Location = new System.Drawing.Point(283, 388);
            this.Submit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(124, 51);
            this.Submit.TabIndex = 27;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(699, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Current_Question_Label);
            this.Controls.Add(this.Questions_List);
            this.Controls.Add(this.PrevButton);
            this.Name = "ExamForm";
            this.Text = "Exam";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Current_Question_Label;
        private System.Windows.Forms.ListBox Questions_List;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Label QuestionContent;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}