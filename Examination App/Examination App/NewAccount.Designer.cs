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
            this.PositionLabel = new System.Windows.Forms.Label();
            this.PositionDropList = new System.Windows.Forms.ComboBox();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DeptLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.CreateAccBtn = new System.Windows.Forms.Button();
            this.DeptBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.BackColor = System.Drawing.Color.Transparent;
            this.PositionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PositionLabel.Location = new System.Drawing.Point(92, 106);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(157, 38);
            this.PositionLabel.TabIndex = 0;
            this.PositionLabel.Text = "Position:";
            // 
            // PositionDropList
            // 
            this.PositionDropList.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PositionDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionDropList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PositionDropList.ForeColor = System.Drawing.Color.Purple;
            this.PositionDropList.FormattingEnabled = true;
            this.PositionDropList.Items.AddRange(new object[] {
            "Student",
            "Instructor"});
            this.PositionDropList.Location = new System.Drawing.Point(350, 108);
            this.PositionDropList.Name = "PositionDropList";
            this.PositionDropList.Size = new System.Drawing.Size(300, 39);
            this.PositionDropList.TabIndex = 1;
            // 
            // IconBox
            // 
            this.IconBox.BackColor = System.Drawing.Color.Transparent;
            this.IconBox.BackgroundImage = global::Examination_App.Properties.Resources.Logo;
            this.IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconBox.Location = new System.Drawing.Point(1, 1);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(128, 88);
            this.IconBox.TabIndex = 2;
            this.IconBox.TabStop = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Red;
            this.CloseBtn.Location = new System.Drawing.Point(735, 1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(63, 54);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "X ";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.MouseEnter += new System.EventHandler(this.CloseBtn_MouseEnter);
            this.CloseBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(100, 327);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(121, 38);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name:";
            // 
            // DeptLabel
            // 
            this.DeptLabel.AutoSize = true;
            this.DeptLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeptLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.DeptLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeptLabel.Location = new System.Drawing.Point(96, 207);
            this.DeptLabel.Name = "DeptLabel";
            this.DeptLabel.Size = new System.Drawing.Size(219, 38);
            this.DeptLabel.TabIndex = 5;
            this.DeptLabel.Text = "Department:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(100, 396);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(116, 38);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.Location = new System.Drawing.Point(100, 466);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(187, 38);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.PasswordBox.ForeColor = System.Drawing.Color.Purple;
            this.PasswordBox.Location = new System.Drawing.Point(350, 468);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(300, 38);
            this.PasswordBox.TabIndex = 8;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.NameBox.ForeColor = System.Drawing.Color.Purple;
            this.NameBox.Location = new System.Drawing.Point(350, 329);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(300, 38);
            this.NameBox.TabIndex = 9;
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.EmailBox.ForeColor = System.Drawing.Color.Purple;
            this.EmailBox.Location = new System.Drawing.Point(350, 398);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(300, 38);
            this.EmailBox.TabIndex = 10;
            // 
            // CreateAccBtn
            // 
            this.CreateAccBtn.BackColor = System.Drawing.Color.DarkMagenta;
            this.CreateAccBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.CreateAccBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateAccBtn.Location = new System.Drawing.Point(325, 570);
            this.CreateAccBtn.Name = "CreateAccBtn";
            this.CreateAccBtn.Size = new System.Drawing.Size(150, 50);
            this.CreateAccBtn.TabIndex = 12;
            this.CreateAccBtn.Text = "Create New Account";
            this.CreateAccBtn.UseVisualStyleBackColor = false;
            this.CreateAccBtn.Click += new System.EventHandler(this.CreateAccBtn_Click);
            this.CreateAccBtn.MouseEnter += new System.EventHandler(this.CreateAccBtn_MouseEnter);
            this.CreateAccBtn.MouseLeave += new System.EventHandler(this.CreateAccBtn_MouseLeave);
            // 
            // DeptBox
            // 
            this.DeptBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeptBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DeptBox.ForeColor = System.Drawing.Color.Purple;
            this.DeptBox.FormattingEnabled = true;
            this.DeptBox.Location = new System.Drawing.Point(350, 209);
            this.DeptBox.Name = "DeptBox";
            this.DeptBox.Size = new System.Drawing.Size(300, 39);
            this.DeptBox.TabIndex = 13;
            // 
            // NewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::Examination_App.Properties.Resources.vecteezy_modern_futuristic_neon_purple_background_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.DeptBox);
            this.Controls.Add(this.CreateAccBtn);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            this.Load += new System.EventHandler(this.NewAccount_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NewAccountWin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NewAccountWin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NewAccountWin_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.ComboBox PositionDropList;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DeptLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Button CreateAccBtn;
        private System.Windows.Forms.ComboBox DeptBox;
    }
}

