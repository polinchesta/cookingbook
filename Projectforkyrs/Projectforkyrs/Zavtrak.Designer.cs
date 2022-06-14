namespace Projectforkyrs
{
    partial class Zavtrak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zavtrak));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bludo1 = new System.Windows.Forms.Label();
            this.bludo2 = new System.Windows.Forms.Label();
            this.zavtrak1 = new System.Windows.Forms.Label();
            this.zavtrak_sostav1 = new System.Windows.Forms.Label();
            this.syrniki = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syrniki)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.bludo2);
            this.panel1.Controls.Add(this.bludo1);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 742);
            this.panel1.TabIndex = 0;
            // 
            // bludo1
            // 
            this.bludo1.AutoSize = true;
            this.bludo1.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.bludo1.Location = new System.Drawing.Point(29, 19);
            this.bludo1.Name = "bludo1";
            this.bludo1.Size = new System.Drawing.Size(128, 30);
            this.bludo1.TabIndex = 0;
            this.bludo1.Text = "Сырники";
            this.bludo1.Click += new System.EventHandler(this.bludo1_Click);
            // 
            // bludo2
            // 
            this.bludo2.AutoSize = true;
            this.bludo2.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.bludo2.Location = new System.Drawing.Point(52, 76);
            this.bludo2.Name = "bludo2";
            this.bludo2.Size = new System.Drawing.Size(88, 30);
            this.bludo2.TabIndex = 1;
            this.bludo2.Text = "Омлет";
            this.bludo2.Click += new System.EventHandler(this.bludo2_Click);
            // 
            // zavtrak1
            // 
            this.zavtrak1.AutoSize = true;
            this.zavtrak1.BackColor = System.Drawing.Color.Transparent;
            this.zavtrak1.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.zavtrak1.Location = new System.Drawing.Point(524, 54);
            this.zavtrak1.Name = "zavtrak1";
            this.zavtrak1.Size = new System.Drawing.Size(106, 30);
            this.zavtrak1.TabIndex = 1;
            this.zavtrak1.Text = "zavtrak1";
            this.zavtrak1.Visible = false;
            // 
            // zavtrak_sostav1
            // 
            this.zavtrak_sostav1.AutoSize = true;
            this.zavtrak_sostav1.BackColor = System.Drawing.Color.Transparent;
            this.zavtrak_sostav1.Font = new System.Drawing.Font("Garamond", 16F, System.Drawing.FontStyle.Bold);
            this.zavtrak_sostav1.Location = new System.Drawing.Point(244, 260);
            this.zavtrak_sostav1.Name = "zavtrak_sostav1";
            this.zavtrak_sostav1.Size = new System.Drawing.Size(189, 30);
            this.zavtrak_sostav1.TabIndex = 2;
            this.zavtrak_sostav1.Text = "zavtrak_sostav1";
            this.zavtrak_sostav1.Visible = false;
            // 
            // syrniki
            // 
            this.syrniki.BackColor = System.Drawing.Color.Transparent;
            this.syrniki.Image = ((System.Drawing.Image)(resources.GetObject("syrniki.Image")));
            this.syrniki.Location = new System.Drawing.Point(209, -2);
            this.syrniki.Name = "syrniki";
            this.syrniki.Size = new System.Drawing.Size(271, 238);
            this.syrniki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.syrniki.TabIndex = 5;
            this.syrniki.TabStop = false;
            // 
            // Zavtrak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 745);
            this.Controls.Add(this.syrniki);
            this.Controls.Add(this.zavtrak_sostav1);
            this.Controls.Add(this.zavtrak1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Zavtrak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zavtrak";
            this.Load += new System.EventHandler(this.Zavtrak_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syrniki)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bludo1;
        private System.Windows.Forms.Label bludo2;
        private System.Windows.Forms.Label zavtrak1;
        private System.Windows.Forms.Label zavtrak_sostav1;
        private System.Windows.Forms.PictureBox syrniki;
    }
}