using MySql.Data.MySqlClient;
using System;
using Projectforkyrs.Models;
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
    public partial class Poisk : Form
    {
        private User _currentUser;
        private string path = string.Empty;
        public Poisk()
        {
            InitializeComponent();
        }
        public Poisk(User currentUser) : this()
        {
            _currentUser = currentUser;
            //textBox1.TextChanged += TextBox1_TextChanged;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            var txtPoisk = (TextBox)sender;
            if (string.IsNullOrEmpty(txtPoisk.Text))
            {
                return;
            }
            UserPoisk(txtPoisk.Text);
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            UserPoisk(textBox1.Text);
            if (comboBoxVybor.SelectedIndex == -1)
            {
                MessageBox.Show("Вы ничего не выбрали!");
            }
        }

        private void UserPoisk(string name)
        {

            path = @"C:\Users\Полина\Desktop\cookingbook-main\Projectforkyrs\Projectforkyrs\Resources\";
            string item = path + name + ".jpg";

            if (comboBoxVybor.SelectedIndex == 0)
            {
                DB dB = new DB();
                dB.openConnection();

                MySqlCommand command = new MySqlCommand($"SELECT * FROM `recept_zavtrak` WHERE `recept_zavtrak`.`nazvanie` = '{name}'", dB.getConnection());
                MySqlDataReader reader = command.ExecuteReader();

                AutoCompleteStringCollection source = new AutoCompleteStringCollection()
                    {
                        "Сырники",
                        "сырники",
                        "Омлет",
                        "омлет",
                        "Творожно-яблочное суфле",
                        "творожно-яблочное суфле",
                        "Творожная запеканка",
                        "творожная запеканка",
                        "Овсянка в банке",
                        "овсянка в банке",
                        "Ленивые вареники",
                        "ленивые вареники ",
                        "Драники",
                        "драники"

                     };
                textBox1.AutoCompleteCustomSource = source;
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                while (reader.Read())
                {
                    named.Text = reader[1].ToString();
                    sostav.Text = reader[2].ToString();
                    recept1.Text = reader[3].ToString();
                    kalor.Text = reader[4].ToString();
                    belki_n.Text = reader[5].ToString();
                    ziry_n.Text = reader[6].ToString();
                    uglevody_n.Text = reader[7].ToString();
                    pictureBoxUser.Image = Image.FromFile(item);
                    named.Visible = true;
                    sostav.Visible = true;
                    recept1.Visible = true;
                    kalor.Visible = true;
                    belki_n.Visible = true;
                    ziry_n.Visible = true;
                    uglevody_n.Visible = true;
                    pictureBoxUser.Visible = true;
                    ingred.Visible = true;
                    ziry.Visible = true;
                    uglevody.Visible = true;
                    belki.Visible = true;
                    recept.Visible = true;
                    energ.Visible = true;
                }
                dB.closeConnection();
            }
            else if (comboBoxVybor.SelectedIndex == 1)
            {
                DB dB = new DB();

                dB.openConnection();

                MySqlCommand command = new MySqlCommand($"SELECT * FROM `recept_obed` WHERE `recept_obed`.`nazvanie` = '{name}'", dB.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                AutoCompleteStringCollection source = new AutoCompleteStringCollection()
                    {
                        "Борщ",
                        "борщ",
                        "Суп Плавленый сыр",
                        "суп Плавленый сыр",
                        "Сырный суп",
                        "сырный суп",
                        "Куриные рулетики",
                        "куриные рулетики",
                        "Картофель запеченный",
                        "картофель запеченный",
                        "Жаркое",
                        "жаркое",
                        "Картошка с курицей",
                        "картошка с курицей"

                     };
                textBox1.AutoCompleteCustomSource = source;
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                while (reader.Read())
                {
                    named.Text = reader[1].ToString();
                    sostav.Text = reader[2].ToString();
                    recept1.Text = reader[3].ToString();
                    kalor.Text = reader[4].ToString();
                    belki_n.Text = reader[5].ToString();
                    ziry_n.Text = reader[6].ToString();
                    uglevody_n.Text = reader[7].ToString();
                    pictureBoxUser.Image = Image.FromFile(item);
                    named.Visible = true;
                    sostav.Visible = true;
                    recept1.Visible = true;
                    kalor.Visible = true;
                    belki_n.Visible = true;
                    ziry_n.Visible = true;
                    uglevody_n.Visible = true;
                    pictureBoxUser.Visible = true;
                    ingred.Visible = true;
                    ziry.Visible = true;
                    uglevody.Visible = true;
                    belki.Visible = true;
                    recept.Visible = true;
                    energ.Visible = true;
                }
                dB.closeConnection();
            }

            else if (comboBoxVybor.SelectedIndex == 2)
            {
                DB dB = new DB();

                dB.openConnection();

                MySqlCommand command = new MySqlCommand($"SELECT * FROM `recept_uzin` WHERE `recept_uzin`.`nazvanie` = '{name}'", dB.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                AutoCompleteStringCollection source = new AutoCompleteStringCollection()
                    {
                        "Сырные лепешки",
                        "сырные лепешки",
                        "Свинина",
                        "свинина",
                        "Хлеб с чесноком",
                        "хлеб с чесноком",
                        "Мясной пирог",
                        "мясной пирог",
                        "Салат",
                        "салат",
                        "Мороженое",
                        "мороженое ",
                        "Горячие бутерброды",
                        "горячие бутерброды"

                     };
                textBox1.AutoCompleteCustomSource = source;
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                while (reader.Read())
                {
                    named.Text = reader[1].ToString();
                    sostav.Text = reader[2].ToString();
                    recept1.Text = reader[3].ToString();
                    kalor.Text = reader[4].ToString();
                    belki_n.Text = reader[5].ToString();
                    ziry_n.Text = reader[6].ToString();
                    uglevody_n.Text = reader[7].ToString();
                    pictureBoxUser.Image = Image.FromFile(item);
                    named.Visible = true;
                    sostav.Visible = true;
                    recept1.Visible = true;
                    kalor.Visible = true;
                    belki_n.Visible = true;
                    ziry_n.Visible = true;
                    uglevody_n.Visible = true;
                    pictureBoxUser.Visible = true;
                    ingred.Visible = true;
                    ziry.Visible = true;
                    uglevody.Visible = true;
                    belki.Visible = true;
                    recept.Visible = true;
                    energ.Visible = true;
                }
                dB.closeConnection();
            }

            else if (comboBoxVybor.SelectedIndex == 3)
            {
                DB dB = new DB();

                dB.openConnection();

                MySqlCommand command = new MySqlCommand($"SELECT * FROM `recept_lanch` WHERE `recept_lanch`.`nazvanie` = '{name}'", dB.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                AutoCompleteStringCollection source = new AutoCompleteStringCollection()
                    {
                        "Смузи",
                        "смузи",
                        "Горячие бутерброды",
                        "горячие бутерброды",
                        "Бананы в глазури",
                        "бананы в глазури",
                        "Квас",
                        "квас",
                        "Тосты",
                        "тосты",
                        "Печёные яблоки",
                        "печёные яблоки",
                        "Гуакамоле",
                        "гуакамоле"

                     };
                textBox1.AutoCompleteCustomSource = source;
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

                while (reader.Read())
                {
                    named.Text = reader[1].ToString();
                    sostav.Text = reader[2].ToString();
                    recept1.Text = reader[3].ToString();
                    kalor.Text = reader[4].ToString();
                    belki_n.Text = reader[5].ToString();
                    ziry_n.Text = reader[6].ToString();
                    uglevody_n.Text = reader[7].ToString();
                    pictureBoxUser.Image = Image.FromFile(item);
                    named.Visible = true;
                    sostav.Visible = true;
                    recept1.Visible = true;
                    kalor.Visible = true;
                    belki_n.Visible = true;
                    ziry_n.Visible = true;
                    uglevody_n.Visible = true;
                    pictureBoxUser.Visible = true;
                    ingred.Visible = true;
                    ziry.Visible = true;
                    uglevody.Visible = true;
                    belki.Visible = true;
                    recept.Visible = true;
                    energ.Visible = true;
                }
                dB.closeConnection();
            }

            else if (comboBoxVybor.SelectedIndex == 4)
            {
                DB dB = new DB();

                dB.openConnection();

                MySqlCommand command = new MySqlCommand($"SELECT * FROM `recept_poldnik` WHERE `recept_poldnik`.`nazvanie` = '{name}'", dB.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
                AutoCompleteStringCollection source = new AutoCompleteStringCollection()
                    {
                        "Смузи",
                        "смузи",
                        "Мороженое",
                        "мороженое",
                        "Сырники",
                        "сырники",
                        "Ленивые вареники",
                        "ленивые вареники",
                        "Тосты",
                        "тосты",
                        "Снек",
                        "снек",
                        "Шпажки",
                        "шпажки"

                     };
                textBox1.AutoCompleteCustomSource = source;
                textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                while (reader.Read())
                {
                    named.Text = reader[1].ToString();
                    sostav.Text = reader[2].ToString();
                    recept1.Text = reader[3].ToString();
                    kalor.Text = reader[4].ToString();
                    belki_n.Text = reader[5].ToString();
                    ziry_n.Text = reader[6].ToString();
                    uglevody_n.Text = reader[7].ToString();
                    pictureBoxUser.Image = Image.FromFile(item);
                    named.Visible = true;
                    sostav.Visible = true;
                    recept1.Visible = true;
                    kalor.Visible = true;
                    belki_n.Visible = true;
                    ziry_n.Visible = true;
                    uglevody_n.Visible = true;
                    pictureBoxUser.Visible = true;
                    ingred.Visible = true;
                    ziry.Visible = true;
                    uglevody.Visible = true;
                    belki.Visible = true;
                    recept.Visible = true;
                    energ.Visible = true;
                }


                dB.closeConnection();
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

        private void enterlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Windowsposleavrizacii windowsposleavrizacii = new Windowsposleavrizacii(_currentUser);
            windowsposleavrizacii.Show();
        }

        Point lastPoint;
        private void Poisk_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Poisk_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }


    }
}
