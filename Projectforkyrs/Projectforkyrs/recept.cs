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
    public partial class recept : Form
    {
        public recept()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void enterlogin_Click(object sender, EventArgs e)
        {
            this.Close();
            Windowsposleavrizacii windowsposleavrizacii = new Windowsposleavrizacii();
            windowsposleavrizacii.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) //первый элемент списка
            {
                Zavtrak zavtrak = new Zavtrak();
                zavtrak.Show();
                this.Close();
            }

            if (comboBox1.SelectedIndex == 1) //первый элемент списка
            {
                Obed obed = new Obed();
                obed.Show();
                this.Close();
            }
        }

        
    }
}
