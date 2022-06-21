namespace Projectforkyrs
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.enterlogin = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Label();
            this.avtorlabel = new System.Windows.Forms.Label();
            this.maskedpassword = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(125, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(51, 159);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Times New Roman", 22.2F);
            this.LoginBox.Location = new System.Drawing.Point(177, 159);
            this.LoginBox.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(368, 78);
            this.LoginBox.TabIndex = 3;
            this.LoginBox.Enter += new System.EventHandler(this.LoginBox_Enter);
            this.LoginBox.Leave += new System.EventHandler(this.LoginBox_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 298);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // enterlogin
            // 
            this.enterlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enterlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterlogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.enterlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enterlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.enterlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterlogin.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterlogin.Location = new System.Drawing.Point(187, 418);
            this.enterlogin.Margin = new System.Windows.Forms.Padding(4);
            this.enterlogin.Name = "enterlogin";
            this.enterlogin.Size = new System.Drawing.Size(235, 49);
            this.enterlogin.TabIndex = 6;
            this.enterlogin.Text = "Войти";
            this.enterlogin.UseVisualStyleBackColor = false;
            this.enterlogin.Click += new System.EventHandler(this.enterlogin_Click);
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(680, 9);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 28);
            this.Close.TabIndex = 7;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // avtorlabel
            // 
            this.avtorlabel.AutoSize = true;
            this.avtorlabel.BackColor = System.Drawing.Color.Transparent;
            this.avtorlabel.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold);
            this.avtorlabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.avtorlabel.Location = new System.Drawing.Point(172, 471);
            this.avtorlabel.Name = "avtorlabel";
            this.avtorlabel.Size = new System.Drawing.Size(255, 30);
            this.avtorlabel.TabIndex = 8;
            this.avtorlabel.Text = "Ещё нет аккаунта?";
            this.avtorlabel.Click += new System.EventHandler(this.avtorlabel_Click);
            // 
            // maskedpassword
            // 
            this.maskedpassword.Font = new System.Drawing.Font("Times New Roman", 22.2F);
            this.maskedpassword.Location = new System.Drawing.Point(177, 298);
            this.maskedpassword.Name = "maskedpassword";
            this.maskedpassword.Size = new System.Drawing.Size(368, 50);
            this.maskedpassword.TabIndex = 22;
            this.maskedpassword.UseSystemPasswordChar = true;
            this.maskedpassword.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(172, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Введите пароль";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(719, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maskedpassword);
            this.Controls.Add(this.avtorlabel);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.enterlogin);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button enterlogin;
        private new System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label avtorlabel;
        private System.Windows.Forms.MaskedTextBox maskedpassword;
        private System.Windows.Forms.Label label2;
    }
}

