namespace Projectforkyrs
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.enterregister = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.reglabel = new System.Windows.Forms.Label();
            this.VvodParolya = new System.Windows.Forms.Label();
            this.VvodParolyaRepeat = new System.Windows.Forms.Label();
            this.maskedpasswordrepeat = new System.Windows.Forms.MaskedTextBox();
            this.maskedpassword = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // enterregister
            // 
            this.enterregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enterregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterregister.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.enterregister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enterregister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.enterregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterregister.Font = new System.Drawing.Font("Garamond", 19.24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterregister.Location = new System.Drawing.Point(197, 473);
            this.enterregister.Margin = new System.Windows.Forms.Padding(4);
            this.enterregister.Name = "enterregister";
            this.enterregister.Size = new System.Drawing.Size(353, 53);
            this.enterregister.TabIndex = 13;
            this.enterregister.Text = "Зарегистрироваться";
            this.enterregister.UseVisualStyleBackColor = false;
            this.enterregister.Click += new System.EventHandler(this.enterregister_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(50, 247);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 105);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(176, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 80);
            this.label1.TabIndex = 8;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown_1);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseMove_1);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(683, 9);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 28);
            this.Close.TabIndex = 14;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Close_MouseEnter);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Times New Roman", 22.2F);
            this.LoginBox.Location = new System.Drawing.Point(197, 105);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(368, 78);
            this.LoginBox.TabIndex = 10;
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            this.LoginBox.Leave += new System.EventHandler(this.LoginBox_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(50, 373);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 79);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // reglabel
            // 
            this.reglabel.AutoSize = true;
            this.reglabel.BackColor = System.Drawing.Color.Transparent;
            this.reglabel.Cursor = System.Windows.Forms.Cursors.Help;
            this.reglabel.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold);
            this.reglabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.reglabel.Location = new System.Drawing.Point(242, 530);
            this.reglabel.Name = "reglabel";
            this.reglabel.Size = new System.Drawing.Size(250, 30);
            this.reglabel.TabIndex = 17;
            this.reglabel.Text = "Уже есть аккаунт?";
            this.reglabel.Click += new System.EventHandler(this.reglabel_Click);
            // 
            // VvodParolya
            // 
            this.VvodParolya.AutoSize = true;
            this.VvodParolya.BackColor = System.Drawing.Color.Transparent;
            this.VvodParolya.Font = new System.Drawing.Font("Century Schoolbook", 9.8F, System.Drawing.FontStyle.Bold);
            this.VvodParolya.ForeColor = System.Drawing.SystemColors.Highlight;
            this.VvodParolya.Location = new System.Drawing.Point(193, 223);
            this.VvodParolya.Name = "VvodParolya";
            this.VvodParolya.Size = new System.Drawing.Size(0, 21);
            this.VvodParolya.TabIndex = 18;
            // 
            // VvodParolyaRepeat
            // 
            this.VvodParolyaRepeat.AutoSize = true;
            this.VvodParolyaRepeat.BackColor = System.Drawing.Color.Transparent;
            this.VvodParolyaRepeat.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold);
            this.VvodParolyaRepeat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.VvodParolyaRepeat.Location = new System.Drawing.Point(193, 348);
            this.VvodParolyaRepeat.Name = "VvodParolyaRepeat";
            this.VvodParolyaRepeat.Size = new System.Drawing.Size(281, 29);
            this.VvodParolyaRepeat.TabIndex = 19;
            this.VvodParolyaRepeat.Text = "Введите пароль ещё раз";
            // 
            // maskedpasswordrepeat
            // 
            this.maskedpasswordrepeat.Font = new System.Drawing.Font("Times New Roman", 22.2F);
            this.maskedpasswordrepeat.Location = new System.Drawing.Point(197, 373);
            this.maskedpasswordrepeat.Name = "maskedpasswordrepeat";
            this.maskedpasswordrepeat.Size = new System.Drawing.Size(368, 50);
            this.maskedpasswordrepeat.TabIndex = 20;
            this.maskedpasswordrepeat.UseSystemPasswordChar = true;
            this.maskedpasswordrepeat.ValidatingType = typeof(int);
            // 
            // maskedpassword
            // 
            this.maskedpassword.Font = new System.Drawing.Font("Times New Roman", 22.2F);
            this.maskedpassword.Location = new System.Drawing.Point(197, 247);
            this.maskedpassword.Name = "maskedpassword";
            this.maskedpassword.Size = new System.Drawing.Size(368, 50);
            this.maskedpassword.TabIndex = 21;
            this.maskedpassword.UseSystemPasswordChar = true;
            this.maskedpassword.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(192, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 22;
            this.label2.Text = "Введите пароль";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(722, 572);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedpassword);
            this.Controls.Add(this.maskedpasswordrepeat);
            this.Controls.Add(this.VvodParolyaRepeat);
            this.Controls.Add(this.VvodParolya);
            this.Controls.Add(this.reglabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.enterregister);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationForm_MouseMove_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button enterregister;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label reglabel;
        private System.Windows.Forms.Label VvodParolya;
        private System.Windows.Forms.Label VvodParolyaRepeat;
        private System.Windows.Forms.MaskedTextBox maskedpasswordrepeat;
        private System.Windows.Forms.MaskedTextBox maskedpassword;
        private System.Windows.Forms.Label label2;
    }
}