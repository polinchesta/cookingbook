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
    public partial class GlavnayaForma : Form
    {
        public GlavnayaForma()
        {
            InitializeComponent();
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }

        Point lastPoint;
        private void GlavnayaForma_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void GlavnayaForma_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
