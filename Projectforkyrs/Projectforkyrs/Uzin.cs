using MySql.Data.MySqlClient;
using Projectforkyrs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectforkyrs
{
    public partial class Uzin : Form
    {
        private User _currentUser;
        private string path = string.Empty;
        public Uzin()
        {
            InitializeComponent();
            Subscribe();
        }
        public Uzin(User currentUser) : this()
        {
            _currentUser = currentUser;
        }
        private void Subscribe()
        {
            bludo1.MouseEnter += bludo_MouseEnter;
            bludo1.MouseLeave += bludo_MouseLeave;
            bludo2.MouseEnter += bludo_MouseEnter;
            bludo2.MouseLeave += bludo_MouseLeave;
            bludo3.MouseEnter += bludo_MouseEnter;
            bludo3.MouseLeave += bludo_MouseLeave;
            bludo4.MouseEnter += bludo_MouseEnter;
            bludo4.MouseLeave += bludo_MouseLeave;
            bludo5.MouseEnter += bludo_MouseEnter;
            bludo5.MouseLeave += bludo_MouseLeave;
            bludo6.MouseEnter += bludo_MouseEnter;
            bludo6.MouseLeave += bludo_MouseLeave;
            bludo7.MouseEnter += bludo_MouseEnter;
            bludo7.MouseLeave += bludo_MouseLeave;
        }
        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GetName(string name)
        {
            path = @"C:\Users\Полина\Desktop\cookingbook-main\Projectforkyrs\Projectforkyrs\Resources\";
            string item = path + name + ".jpg";
            PictureBoxImage.Image = Image.FromFile(item);
            DB db = new DB();


            db.openConnection();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `recept_uzin` WHERE `recept_uzin`.`nazvanie` = '{name}'", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                uzin1.Text = reader[1].ToString();
                uzin_sostav1.Text = reader[2].ToString();
                uzin_recept1.Text = reader[3].ToString();
                kalor.Text = reader[4].ToString();
                belki_n.Text = reader[5].ToString();
                ziry_n.Text = reader[6].ToString();
                uglevody_n.Text = reader[7].ToString();
            }


            db.closeConnection();
        }
        private void bludo1_Click(object sender, EventArgs e)
        {
            uzin1.Visible = true;
            uzin_sostav1.Visible = true;
            uzin_recept1.Visible = true;
            PictureBoxImage.Visible = true;
            ingred.Visible = true;
            energ.Visible = true;
            kalor.Visible = true;
            ziry.Visible = true;
            ziry_n.Visible = true;
            uglevody.Visible = true;
            uglevody_n.Visible = true;
            belki.Visible = true;
            belki_n.Visible = true;
            recept.Visible = true;
            buttonProsmotr.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            GetName(bludo1.Text);
        }

        private void bludo2_Click(object sender, EventArgs e)
        {
            uzin1.Visible = true;
            uzin_sostav1.Visible = true;
            uzin_recept1.Visible = true;
            PictureBoxImage.Visible = true;
            ingred.Visible = true;
            energ.Visible = true;
            kalor.Visible = true;
            ziry.Visible = true;
            ziry_n.Visible = true;
            uglevody.Visible = true;
            uglevody_n.Visible = true;
            belki.Visible = true;
            belki_n.Visible = true;
            recept.Visible = true;
            buttonProsmotr.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            GetName(bludo2.Text);
        }

        private void bludo_MouseLeave(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.ForeColor = Color.Black;
        }

        private void bludo_MouseEnter(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.ForeColor = Color.DarkBlue;
        }

        private void bludo3_Click(object sender, EventArgs e)
        {
            uzin1.Visible = true;
            uzin_sostav1.Visible = true;
            uzin_recept1.Visible = true;
            PictureBoxImage.Visible = true;
            ingred.Visible = true;
            energ.Visible = true;
            kalor.Visible = true;
            ziry.Visible = true;
            ziry_n.Visible = true;
            uglevody.Visible = true;
            uglevody_n.Visible = true;
            belki.Visible = true;
            belki_n.Visible = true;
            recept.Visible = true;
            buttonProsmotr.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            GetName(bludo3.Text);
        }

        private void bludo4_Click(object sender, EventArgs e)
        {
            uzin1.Visible = true;
            uzin_sostav1.Visible = true;
            uzin_recept1.Visible = true;
            PictureBoxImage.Visible = true;
            ingred.Visible = true;
            energ.Visible = true;
            kalor.Visible = true;
            ziry.Visible = true;
            ziry_n.Visible = true;
            uglevody.Visible = true;
            uglevody_n.Visible = true;
            belki.Visible = true;
            belki_n.Visible = true;
            recept.Visible = true;
            buttonProsmotr.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            GetName(bludo4.Text);
        }

        private void bludo5_Click(object sender, EventArgs e)
        {
            uzin1.Visible = true;
            uzin_sostav1.Visible = true;
            uzin_recept1.Visible = true;
            PictureBoxImage.Visible = true;
            ingred.Visible = true;
            energ.Visible = true;
            kalor.Visible = true;
            ziry.Visible = true;
            ziry_n.Visible = true;
            uglevody.Visible = true;
            uglevody_n.Visible = true;
            belki.Visible = true;
            belki_n.Visible = true;
            recept.Visible = true;
            buttonProsmotr.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            GetName(bludo5.Text);
        }

        private void bludo6_Click(object sender, EventArgs e)
        {
            uzin1.Visible = true;
            uzin_sostav1.Visible = true;
            uzin_recept1.Visible = true;
            PictureBoxImage.Visible = true;
            ingred.Visible = true;
            energ.Visible = true;
            kalor.Visible = true;
            ziry.Visible = true;
            ziry_n.Visible = true;
            uglevody.Visible = true;
            uglevody_n.Visible = true;
            belki.Visible = true;
            belki_n.Visible = true;
            recept.Visible = true;
            buttonProsmotr.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            GetName(bludo6.Text);
        }

        private void bludo7_Click(object sender, EventArgs e)
        {
            uzin1.Visible = true;
            uzin_sostav1.Visible = true;
            uzin_recept1.Visible = true;
            PictureBoxImage.Visible = true;
            ingred.Visible = true;
            energ.Visible = true;
            kalor.Visible = true;
            ziry.Visible = true;
            ziry_n.Visible = true;
            uglevody.Visible = true;
            uglevody_n.Visible = true;
            belki.Visible = true;
            belki_n.Visible = true;
            recept.Visible = true;
            buttonProsmotr.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            GetName(bludo7.Text);
        }

        Point lastPoint;
        private void Uzin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Uzin_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void enterlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            recept recept = new recept(_currentUser);
            recept.Show();
        }

        private void Uzin_Load(object sender, EventArgs e)
        {
            uzin1.Visible = false;
            uzin_sostav1.Visible = false;
            uzin_recept1.Visible = false;
            PictureBoxImage.Visible = false;
            ingred.Visible = false;
            energ.Visible = false;
            kalor.Visible = false;
            ziry.Visible = false;
            ziry_n.Visible = false;
            uglevody.Visible = false;
            uglevody_n.Visible = false;
            belki.Visible = false;
            belki_n.Visible = false;
            recept.Visible = false;
            buttonProsmotr.Visible = false;
            label2.Visible = true;
            label3.Visible = true;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void buttonProsmotr_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Полина\Desktop\cookingbook-main\Projectforkyrs\Projectforkyrs\Resources\Video\" + uzin1.Text + ".mp4";
            Process.Start(path);
        }
    }
}
