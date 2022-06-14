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
               
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
               
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void enterlogin_Click(object sender, EventArgs e)
        {
            String loginUser = LoginBox.Text;
            String passUser = maskedpassword.Text;
        
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `customer` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                Windowsposleavrizacii windowsposleavrizacii = new Windowsposleavrizacii();
                windowsposleavrizacii.Show();
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
        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left) 
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void reglabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void avtorlabel_Click(object sender, EventArgs e)
        {
            this.Hide();
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
