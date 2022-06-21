using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            LoginBox.Text = "Введите логин";
            LoginBox.ForeColor = Color.Gray;
            this.maskedpassword.AutoSize = false;
            this.maskedpassword.Size = new Size(this.maskedpassword.Size.Width, 64);
        }


        private void enterlogin_Click(object sender, EventArgs e)
        {
            string loginUser = LoginBox.Text;
            string passUser = maskedpassword.Text;


            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `customer` WHERE login = '{loginUser}' AND password = '{passUser}'", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                if (table.Rows[0][1].ToString() == loginUser)
                {
                    if (table.Rows[0][2].ToString() == passUser)
                    {
                        this.Hide();
                        Windowsposleavrizacii windowsposleavrizacii = new Windowsposleavrizacii();
                        windowsposleavrizacii.Show();
                    }
                    else
                        MessageBox.Show("Такого аккаунта нет");
                }
                else
                    MessageBox.Show("Такого аккаунта нет");
            }
            else
                MessageBox.Show("Такого аккаунта нет");

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

        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void reglabel_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void avtorlabel_Click(object sender, EventArgs e)
        {
            this.Close();
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();
        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Введите логин")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = Color.Black;
            }
        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                LoginBox.Text = "Введите логин";
                LoginBox.ForeColor = Color.Gray;
            }
        }
    }
}
