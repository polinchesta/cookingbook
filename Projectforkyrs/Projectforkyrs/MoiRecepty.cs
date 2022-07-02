using MySql.Data.MySqlClient;
using OpenQA.Selenium;
using Projectforkyrs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectforkyrs
{
    public partial class MoiRecepty : Form
    {
        private User _currentUser;
        private string path = string.Empty;

        public MoiRecepty()
        {
            InitializeComponent();
        }

        public MoiRecepty(User currentUser) : this()
        {
            _currentUser = currentUser;
        }

        private void MoiRecepty_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            PictureBoxImage.ImageLocation = "../../Resources/" + moi_name1.Text + ".jpg";
            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `lichnye_recepty` WHERE `lichnye_recepty`.`nazvanie` = '{moi_name1.Text}'", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                moi_name1.Text = moi_name1.Text;
                moi_sostav1.Text = reader[2].ToString();
                moi_recept1.Text = reader[3].ToString();
                kalor.Text = reader[4].ToString();
                belki_n.Text = reader[5].ToString();
                ziry_n.Text = reader[6].ToString();
                uglevody_n.Text = reader[7].ToString();
            }


            db.closeConnection();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Windowsposleavrizacii windowsposleavrizacii = new Windowsposleavrizacii(_currentUser);
            windowsposleavrizacii.Show();
        }

        private void LoadComboBox()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand($"SELECT nazvanie FROM `lichnye_recepty` WHERE `lichnye_recepty`.`id_customer` = '{_currentUser.Id}'", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }
            db.closeConnection();


            adapter.SelectCommand = command;
            adapter.Fill(table);

        }
        private void UserPoisk(string name)
        {
            path = @"C:\Users\Полина\Desktop\cookingbook-main\Projectforkyrs\Projectforkyrs\Resources\";
            string item = path + name + ".jpg";

            if (comboBox1.Text ==  name)
            {
                DB dB = new DB();
                dB.openConnection();

                MySqlCommand command = new MySqlCommand($"SELECT * FROM `lichnye_recepty` WHERE `lichnye_recepty`.`nazvanie` = '{name}'", dB.getConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    moi_name1.Text = reader[1].ToString();
                    moi_sostav1.Text = reader[2].ToString();
                    moi_recept1.Text = reader[3].ToString();
                    kalor.Text = reader[4].ToString();
                    belki_n.Text = reader[5].ToString();
                    ziry_n.Text = reader[6].ToString();
                    uglevody_n.Text = reader[7].ToString();
                    try
                    {
                        if (Image.FromFile(item) == null)
                        {
                            throw new FileNotFoundException("Вы не добавили картинку");
                        }
                        else
                        {
                            PictureBoxImage.Image = Image.FromFile(item);
                        }
                    }
                    catch (FileNotFoundException ex) 
                    {
                        MessageBox.Show("Вы не добавили картинку! " + ex.Message, "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    
                    PictureBoxImage.Visible = true;
                    moi_name1.Visible = true;
                    moi_sostav1.Visible = true;
                    moi_recept1.Visible = true;
                    kalor.Visible = true;
                    belki_n.Visible = true;
                    ziry_n.Visible = true;
                    uglevody_n.Visible = true;
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

        Point lastPoint;
        private void MoiRecepty_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MoiRecepty_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonPoisk_Click(object sender, EventArgs e)
        {
            UserPoisk(comboBox1.Text);
        }

        private void Close_MouseLeave_1(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void Close_MouseEnter_1(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }
    }
}
