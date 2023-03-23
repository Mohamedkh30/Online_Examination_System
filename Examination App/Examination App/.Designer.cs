namespace Examination_App
{
    partial class UpdateData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateData));
            this.DeptBox = new System.Windows.Forms.ComboBox();
            this.PosBox = new System.Windows.Forms.TextBox();
            this.PosLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.CloseBtn = new System.Windows.Forms.Label();
            this.UpdateInfoBtn = new System.Windows.Forms.Button();
            this.DeleteAccBtn = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.DeptLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.IconBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeptBox
            // 
            this.DeptBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeptBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DeptBox.ForeColor = System.Drawing.Color.Purple;
            this.DeptBox.FormattingEnabled = true;
            this.DeptBox.Location = new System.Drawing.Point(332, 346);
            this.DeptBox.Name = "DeptBox";
            this.DeptBox.Size = new System.Drawing.Size(350, 33);
            this.DeptBox.TabIndex = 45;
            // 
            // PosBox
            // 
            this.PosBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PosBox.Cursor = System.Windows.Forms.Cursors.No;
            this.PosBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.PosBox.ForeColor = System.Drawing.Color.Purple;
            this.PosBox.Location = new System.Drawing.Point(332, 200);
            this.PosBox.Name = "PosBox";
            this.PosBox.ReadOnly = true;
            this.PosBox.Size = new System.Drawing.Size(350, 45);
            this.PosBox.TabIndex = 44;
            // 
            // PosLabel
            // 
            this.PosLabel.AutoSize = true;
            this.PosLabel.BackColor = System.Drawing.Color.Transparent;
            this.PosLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PosLabel.Location = new System.Drawing.Point(95, 203);
            this.PosLabel.Name = "PosLabel";
            this.PosLabel.Size = new System.Drawing.Size(157, 38);
            this.PosLabel.TabIndex = 43;
            this.PosLabel.Text = "Position:";
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.IDBox.Cursor = System.Windows.Forms.Cursors.No;
            this.IDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.IDBox.ForeColor = System.Drawing.Color.Purple;
            this.IDBox.Location = new System.Drawing.Point(332, 129);
            this.IDBox.Name = "IDBox";
            this.IDBox.ReadOnly = true;
            this.IDBox.Size = new System.Drawing.Size(350, 45);
            this.IDBox.TabIndex = 42;
            // 
            // CloseBtn
            // 
            this.CloseBtn.AutoSize = true;
            this.CloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.CloseBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 35.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Red;
            this.CloseBtn.Location = new System.Drawing.Point(737, -1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(63, 54);
            this.CloseBtn.TabIndex = 40;
            this.CloseBtn.Text = "X ";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            this.CloseBtn.MouseEnter += new System.EventHandler(this.CloseBtn_MouseEnter);
            this.CloseBtn.MouseLeave += new System.EventHandler(this.CloseBtn_MouseLeave);
            // 
            // UpdateInfoBtn
            // 
            this.UpdateInfoBtn.BackColor = System.Drawing.Color.DarkMagenta;
            this.UpdateInfoBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.UpdateInfoBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateInfoBtn.Location = new System.Drawing.Point(132, 587);
            this.UpdateInfoBtn.Name = "UpdateInfoBtn";
            this.UpdateInfoBtn.Size = new System.Drawing.Size(150, 50);
            this.UpdateInfoBtn.TabIndex = 39;
            this.UpdateInfoBtn.Text = "Update info.";
            this.UpdateInfoBtn.UseVisualStyleBackColor = false;
            this.UpdateInfoBtn.Click += new System.EventHandler(this.UpdateInfoBtn_Click);
            this.UpdateInfoBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.UpdateInfoBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // DeleteAccBtn
            // 
            this.DeleteAccBtn.BackColor = System.Drawing.Color.DarkMagenta;
            this.DeleteAccBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.DeleteAccBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteAccBtn.Location = new System.Drawing.Point(482, 587);
            this.DeleteAccBtn.Name = "DeleteAccBtn";
            this.DeleteAccBtn.Size = new System.Drawing.Size(150, 50);
            this.DeleteAccBtn.TabIndex = 38;
            this.DeleteAccBtn.Text = "Delete Account";
            this.DeleteAccBtn.UseVisualStyleBackColor = false;
            this.DeleteAccBtn.Click += new System.EventHandler(this.DeleteAccBtn_Click);
            this.DeleteAccBtn.MouseEnter += new System.EventHandler(this.Btn_MouseEnter);
            this.DeleteAccBtn.MouseLeave += new System.EventHandler(this.Btn_MouseLeave);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.Location = new System.Drawing.Point(95, 477);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(187, 38);
            this.PasswordLabel.TabIndex = 37;
            this.PasswordLabel.Text = "Password:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
            this.EmailLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailLabel.Location = new System.Drawing.Point(95, 410);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(116, 38);
            this.EmailLabel.TabIndex = 36;
            this.EmailLabel.Text = "Email:";
            // 
            // DeptLabel
            // 
            this.DeptLabel.AutoSize = true;
            this.DeptLabel.BackColor = System.Drawing.Color.Transparent;
            this.DeptLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.DeptLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeptLabel.Location = new System.Drawing.Point(95, 344);
            this.DeptLabel.Name = "DeptLabel";
            this.DeptLabel.Size = new System.Drawing.Size(219, 38);
            this.DeptLabel.TabIndex = 35;
            this.DeptLabel.Text = "Department:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F);
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(95, 279);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(121, 38);
            this.NameLabel.TabIndex = 34;
            this.NameLabel.Text = "Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.Transparent;
            this.IDLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IDLabel.Location = new System.Drawing.Point(95, 132);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(61, 38);
            this.IDLabel.TabIndex = 33;
            this.IDLabel.Text = "ID:";
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.EmailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EmailBox.ForeColor = System.Drawing.Color.Purple;
            this.EmailBox.Location = new System.Drawing.Point(332, 418);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(350, 30);
            this.EmailBox.TabIndex = 32;
            // 
            // NameBox
            // 
            this.NameBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.NameBox.ForeColor = System.Drawing.Color.Purple;
            this.NameBox.Location = new System.Drawing.Point(332, 287);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(350, 30);
            this.NameBox.TabIndex = 31;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.PasswordBox.ForeColor = System.Drawing.Color.Purple;
            this.PasswordBox.Location = new System.Drawing.Point(332, 485);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(350, 30);
            this.PasswordBox.TabIndex = 30;
            // 
            // IconBox
            // 
            this.IconBox.BackColor = System.Drawing.Color.Transparent;
            this.IconBox.BackgroundImage = global::Examination_App.Properties.Resources.Logo;
            this.IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IconBox.Location = new System.Drawing.Point(0, 0);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(128, 88);
            this.IconBox.TabIndex = 41;
            this.IconBox.TabStop = false;
            // 
            // UpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Examination_App.Properties.Resources.vecteezy_modern_futuristic_neon_purple_background_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.DeptBox);
            this.Controls.Add(this.PosBox);
            this.Controls.Add(this.PosLabel);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.UpdateInfoBtn);
            this.Controls.Add(this.DeleteAccBtn);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.DeptLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.IconBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateData";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UpdateData_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpdateData_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.UpdateData_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DeptBox;
        private System.Windows.Forms.TextBox PosBox;
        private System.Windows.Forms.Label PosLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Label CloseBtn;
        private System.Windows.Forms.Button UpdateInfoBtn;
        private System.Windows.Forms.Button DeleteAccBtn;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label DeptLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.PictureBox IconBox;
    }
}