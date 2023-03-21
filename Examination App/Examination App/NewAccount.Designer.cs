namespace Examination_App
{
    partial class NewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAccount));
            this.CreateAccBtn = new System.Windows.Forms.Button();
            this.DeptBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.DeptLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.PositionDropList = new System.Windows.Forms.ComboBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateAccBtn
            // 
            this.CreateAccBtn.BackColor = System.Drawing.Color.DarkMagenta;
            this.CreateAccBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CreateAccBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateAccBtn.Location = new System.Drawing.Point(441, 716);
            this.CreateAccBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CreateAccBtn.Name = "CreateAccBtn";
            this.CreateAccBtn.Size = new System.Drawing.Size(200, 62);
            this.CreateAccBtn.TabIndex = 25;
            this.CreateAccBtn.Text = "Create New Account";
            this.CreateAccBtn.UseVisualStyleBackColor = false;
            this.CreateAccBtn.Click += new System.EventHandler(this.CreateAccBtn_Click);
            // 
            // DeptBox
            // 
            this.DeptBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.DeptBox.ForeColor = System.Drawing.Color.Purple;
            this.DeptBox.Location = new System.Drawing.Point(475, 398);
            this.DeptBox.Margin = new System.Windows.Forms.Padding(4);
            this.DeptBox.Name = "DeptBox";
            this.DeptBox.Size = new System.Drawing.Size(399, 55);
            this.DeptBox.TabIndex = 24;
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.EmailBox.ForeColor = System.Drawing.Color.Purple;
            this.EmailBox.Location = new System.Drawing.Point(475, 493);
            this.EmailBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(399, 55);
            this.EmailBox.TabIndex = 23;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.NameBox.ForeColor = System.Drawing.Color.Purple;
            this.NameBox.Location = new System.Drawing.Point(475, 291);
            this.NameBox.Margin = new System.Windows.Forms.Padding(4);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(399, 55);
            this.NameBox.TabIndex = 22;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.PasswordBox.ForeColor = System.Drawing.Color.Purple;
            this.PasswordBox.Location = new System.Drawing.Point(475, 584);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(399, 55);
            this.PasswordBox.TabIndex = 21;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.Location = new System.Drawing.Point(141, 588);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(215, 48);
            this.PasswordLabel.TabIndex = 20;
            this.PasswordLabel.Text = "Password:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(141, 501);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(138, 48);
            this.EmailLabel.TabIndex = 19;
            this.EmailLabel.Text = "Email:";
            // 
            // DeptLabel
            // 
            this.DeptLabel.AutoSize = true;
            this.DeptLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.DeptLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeptLabel.Location = new System.Drawing.Point(141, 398);
            this.DeptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeptLabel.Name = "DeptLabel";
            this.DeptLabel.Size = new System.Drawing.Size(250, 48);
            this.DeptLabel.TabIndex = 18;
            this.DeptLabel.Text = "Department:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(136, 295);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(143, 48);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Name:";
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Red;
            this.CloseBtn.Location = new System.Drawing.Point(988, 15);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(84, 67);
            this.CloseBtn.TabIndex = 16;
            this.CloseBtn.Text = "X ";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.MouseEnter += new System.EventHandler(this.CloseBtn_MouseEnter);
            this.CloseBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            // 
            // IconBox
            // 
            this.IconBox.BackColor = System.Drawing.Color.Transparent;
            this.IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconBox.Image = ((System.Drawing.Image)(resources.GetObject("IconBox.Image")));
            this.IconBox.Location = new System.Drawing.Point(9, 15);
            this.IconBox.Margin = new System.Windows.Forms.Padding(4);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(171, 108);
            this.IconBox.TabIndex = 15;
            this.IconBox.TabStop = false;
            // 
            // PositionDropList
            // 
            this.PositionDropList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PositionDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionDropList.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.PositionDropList.ForeColor = System.Drawing.Color.Purple;
            this.PositionDropList.FormattingEnabled = true;
            this.PositionDropList.Location = new System.Drawing.Point(475, 141);
            this.PositionDropList.Margin = new System.Windows.Forms.Padding(4);
            this.PositionDropList.Name = "PositionDropList";
            this.PositionDropList.Size = new System.Drawing.Size(399, 56);
            this.PositionDropList.TabIndex = 14;
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.BackColor = System.Drawing.Color.Transparent;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PositionLabel.Location = new System.Drawing.Point(131, 144);
            this.PositionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(182, 48);
            this.PositionLabel.TabIndex = 13;
            this.PositionLabel.Text = "Position:";
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1065, 801);
            this.Controls.Add(this.CreateAccBtn);
            this.Controls.Add(this.DeptBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.DeptLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.IconBox);
            this.Controls.Add(this.PositionDropList);
            this.Controls.Add(this.PositionLabel);
            this.Name = "NewAccount";
            this.Text = "NewAccount";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewAccountWin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewAccountWin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewAccountWin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateAccBtn;
        private System.Windows.Forms.TextBox DeptBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label DeptLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.ComboBox PositionDropList;
        private System.Windows.Forms.Label PositionLabel;
    }
}