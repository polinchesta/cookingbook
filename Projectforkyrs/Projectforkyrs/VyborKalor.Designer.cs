namespace Projectforkyrs
{
    partial class VyborKalor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VyborKalor));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.enterlogin = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Название = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Калорийность = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Белки = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Жиры = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Углеводы = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(151, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(397, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Перейти к таблице калорийности";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 65);
            this.label1.TabIndex = 17;
            this.label1.Text = "Выберите продукты калорийность, которых хотите узнать";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Молочные продукты",
            "Рыба и морепродукты",
            "Зерновые культуры",
            "Бобовые культуры",
            "Овощи",
            "Фрукты"});
            this.comboBox1.Location = new System.Drawing.Point(190, 194);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(332, 37);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.Text = "Выберайте продукты";
            // 
            // enterlogin
            // 
            this.enterlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enterlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterlogin.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.enterlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.enterlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.enterlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterlogin.Font = new System.Drawing.Font("Garamond", 15F, System.Drawing.FontStyle.Bold);
            this.enterlogin.Location = new System.Drawing.Point(527, 428);
            this.enterlogin.Margin = new System.Windows.Forms.Padding(4);
            this.enterlogin.Name = "enterlogin";
            this.enterlogin.Size = new System.Drawing.Size(131, 41);
            this.enterlogin.TabIndex = 15;
            this.enterlogin.Text = "Назад";
            this.enterlogin.UseVisualStyleBackColor = false;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(667, 9);
            this.Close.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 28);
            this.Close.TabIndex = 14;
            this.Close.Text = "X";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Название,
            this.Калорийность,
            this.Белки,
            this.Жиры,
            this.Углеводы});
            this.dataGridView1.Location = new System.Drawing.Point(12, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 454);
            this.dataGridView1.TabIndex = 19;
            // 
            // Название
            // 
            this.Название.HeaderText = "Название";
            this.Название.MinimumWidth = 6;
            this.Название.Name = "Название";
            this.Название.ReadOnly = true;
            this.Название.Width = 125;
            // 
            // Калорийность
            // 
            this.Калорийность.HeaderText = "Калорийность (ккал)";
            this.Калорийность.MinimumWidth = 6;
            this.Калорийность.Name = "Калорийность";
            this.Калорийность.ReadOnly = true;
            this.Калорийность.Width = 125;
            // 
            // Белки
            // 
            this.Белки.HeaderText = "Белки(гр.)";
            this.Белки.MinimumWidth = 6;
            this.Белки.Name = "Белки";
            this.Белки.ReadOnly = true;
            this.Белки.Width = 125;
            // 
            // Жиры
            // 
            this.Жиры.HeaderText = "Жиры(гр.)";
            this.Жиры.MinimumWidth = 6;
            this.Жиры.Name = "Жиры";
            this.Жиры.ReadOnly = true;
            this.Жиры.Width = 125;
            // 
            // Углеводы
            // 
            this.Углеводы.HeaderText = "Углеводы(гр.)";
            this.Углеводы.MinimumWidth = 6;
            this.Углеводы.Name = "Углеводы";
            this.Углеводы.ReadOnly = true;
            this.Углеводы.Width = 125;
            // 
            // VyborKalor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(706, 505);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.enterlogin);
            this.Controls.Add(this.Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VyborKalor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VyborKalor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button enterlogin;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Название;
        private System.Windows.Forms.DataGridViewTextBoxColumn Калорийность;
        private System.Windows.Forms.DataGridViewTextBoxColumn Белки;
        private System.Windows.Forms.DataGridViewTextBoxColumn Жиры;
        private System.Windows.Forms.DataGridViewTextBoxColumn Углеводы;
    }
}