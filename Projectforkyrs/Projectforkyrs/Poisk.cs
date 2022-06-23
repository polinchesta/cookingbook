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
    public partial class Poisk : Form
    {
        private string path = string.Empty;
        public Poisk()
        {
            InitializeComponent();
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            UserPoisk(textBox1.Text);
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
                DB dB_Obed = new DB();

                dB_Obed.openConnection();

                MySqlCommand command = new MySqlCommand($"SELECT * FROM `recept_obed` WHERE `recept_obed`.`nazvanie` = '{name}'", dB_Obed.getConnection());
                MySqlDataReader reader = command.ExecuteReader();
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


                dB_Obed.closeConnection();
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
            Windowsposleavrizacii windowsposleavrizacii = new Windowsposleavrizacii();
            windowsposleavrizacii.Show();
        }
    }
}
