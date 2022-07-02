using MySql.Data.MySqlClient;
using Projectforkyrs.Exceptions;
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
    public partial class LoginForm : Form
    {
        private User _currentUser;
        public LoginForm()
        {

            InitializeComponent();

            LoginBox.Text = "Введите логин";
            LoginBox.ForeColor = Color.Gray;
            this.maskedpassword.AutoSize = false;
            this.maskedpassword.Size = new Size(this.maskedpassword.Size.Width, 65);
        }
        public LoginForm(User currentUser) : this()
        {
            _currentUser = currentUser;
        }

        private void enterlogin_Click(object sender, EventArgs e)
        {
            string loginUser = LoginBox.Text;
            string passUser = maskedpassword.Text;


            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            User currentUser = default;
            try
            {
                using (var connection = db.getConnection())
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand($"SELECT * FROM `customers` WHERE login = '{loginUser}' AND password = '{passUser}'", connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                throw new UserException("Такого пользователя не существует");
                            }
                            while (reader.Read())
                            {
                                currentUser = new User()
                                {
                                    Id = reader.GetInt32("id"),
                                };
                            }
                        }

                    }
                }
                this.Hide();
                Windowsposleavrizacii windowsposleavrizacii = new Windowsposleavrizacii(currentUser);
                windowsposleavrizacii.Show();
            }
            catch(UserException ex)
            {
                MessageBox.Show(ex.Message);
            }
               
                      
                   
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
