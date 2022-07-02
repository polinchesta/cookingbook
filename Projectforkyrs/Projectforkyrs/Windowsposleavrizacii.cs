using Projectforkyrs.Models;
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
        private readonly User _currentUser;
        public Windowsposleavrizacii()
        {
            InitializeComponent();
            
        }

        public Windowsposleavrizacii(User currentUser) : this()
        {
            _currentUser = currentUser;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            recept recept = new recept(_currentUser);
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
            Poisk poisk = new Poisk(_currentUser);
            poisk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BelarusKuxnya belarusKuxnya = new BelarusKuxnya(_currentUser);
            belarusKuxnya.Show();
        }

        Point lastPoint;
       

        private void Windowsposleavrizacii_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Windowsposleavrizacii_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Receptypolz receptypolz = new Receptypolz(_currentUser);
            receptypolz.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MoiRecepty moiRecepty = new MoiRecepty(_currentUser);
            moiRecepty.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm(_currentUser);
            loginForm.Show();
        }
    }
}
