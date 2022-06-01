using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectforkyrs
{
    public partial class zagruzka : Form
    {
        private Form form;
        public zagruzka()
        {
            InitializeComponent();

            timer1.Interval = 500; 
           
            timer1.Tick += timer1_Tick;
        }

        public zagruzka(Form form) :this()
        {
            this.form = form;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.progressBar1.Increment(1);

            //if (progressBar1.Value == progressBar1.Maximum)
            //{

            //}
          

            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                timer1.Stop();
                progressBar1.Invalidate();
                form.Show();
                this.Close();
            }
            else
                this.progressBar1.Increment(5);
        }

        private void zagruzka_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            timer1.Enabled = true;
        }

    }
}
