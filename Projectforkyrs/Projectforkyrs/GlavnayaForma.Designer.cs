namespace Projectforkyrs
{
    partial class GlavnayaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlavnayaForma));
            this.textLabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.registrationbutton = new System.Windows.Forms.Button();
            this.avtorbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textLabel.BackColor = System.Drawing.Color.Transparent;
            this.textLabel.Font = new System.Drawing.Font("Garamond", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.ForeColor = System.Drawing.Color.Black;
            this.textLabel.Location = new System.Drawing.Point(177, 9);
            this.textLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(375, 153);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Книга рецептов";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(685, 9);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 28);
            this.Close.TabIndex = 8;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // registrationbutton
            // 
            this.registrationbutton.AutoSize = true;
            this.registrationbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registrationbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registrationbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.registrationbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.registrationbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.registrationbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrationbutton.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registrationbutton.Location = new System.Drawing.Point(246, 194);
            this.registrationbutton.Margin = new System.Windows.Forms.Padding(4);
            this.registrationbutton.Name = "registrationbutton";
            this.registrationbutton.Size = new System.Drawing.Size(235, 50);
            this.registrationbutton.TabIndex = 9;
            this.registrationbutton.Text = "Регистрация";
            this.registrationbutton.UseVisualStyleBackColor = false;
            this.registrationbutton.Click += new System.EventHandler(this.registrationbutton_Click);
            // 
            // avtorbutton
            // 
            this.avtorbutton.AutoSize = true;
            this.avtorbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.avtorbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.avtorbutton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.avtorbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.avtorbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.avtorbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.avtorbutton.Font = new System.Drawing.Font("Garamond", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.avtorbutton.Location = new System.Drawing.Point(246, 292);
            this.avtorbutton.Margin = new System.Windows.Forms.Padding(4);
            this.avtorbutton.Name = "avtorbutton";
            this.avtorbutton.Size = new System.Drawing.Size(235, 50);
            this.avtorbutton.TabIndex = 10;
            this.avtorbutton.Text = "Авторизация";
            this.avtorbutton.UseVisualStyleBackColor = false;
            this.avtorbutton.Click += new System.EventHandler(this.avtorbutton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Garamond", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 90);
            this.label1.TabIndex = 11;
            this.label1.Text = "Программа разработана в качестве курсового проекта по языку программирования C#.У" +
    "чащейся группы 03-09-31тп, Лашкевич Полиной";
            // 
            // GlavnayaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(724, 541);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avtorbutton);
            this.Controls.Add(this.registrationbutton);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.textLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GlavnayaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GlavnayaForma";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GlavnayaForma_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GlavnayaForma_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Button registrationbutton;
        private System.Windows.Forms.Button avtorbutton;
        private System.Windows.Forms.Label label1;
    }
}