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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            LoginBox.Text = "Введите логин";
            LoginBox.ForeColor = Color.Gray;
            this.maskedpasswordrepeat.AutoSize = false;
            this.maskedpasswordrepeat.Size = new Size(this.maskedpassword.Size.Width, 64);
            this.maskedpassword.AutoSize = false;
            this.maskedpassword.Size = new Size(this.maskedpassword.Size.Width, 64);
        }

        private void enterregister_Click(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (maskedpassword.Text == "")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (maskedpasswordrepeat.Text == "")
            {
                MessageBox.Show("Введите пароль ещё раз");
                return;
            }

            if (maskedpassword.Text != maskedpasswordrepeat.Text)
            {
                MessageBox.Show("Пароли не совпали");
                return;
            }
           

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `customer` (`login`, `password`, `passwordrepeat`) VALUES (@login, @password, @passwordrepeat)", db.getConnection());


            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginBox.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = maskedpassword.Text;
            command.Parameters.Add("@passwordrepeat", MySqlDbType.VarChar).Value = maskedpasswordrepeat.Text;

            db.openConnection();


            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");

            db.closeConnection();

            
        }

        public Boolean isUserExists()
        {

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `customer` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginBox.Text;
            

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;    
            }
                
            else
                return false;
        }

        private void reglabel_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
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

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
        private void RegistrationForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegistrationForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
    }
}
