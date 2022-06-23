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
    public partial class Windowsposleavrizacii : Form
    {
        public Windowsposleavrizacii()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            recept recept = new recept();
            recept.Show();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Poisk poisk = new Poisk();
            poisk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BelarusKuxnya belarusKuxnya = new BelarusKuxnya();
            belarusKuxnya.Show();
        }
    }
}
