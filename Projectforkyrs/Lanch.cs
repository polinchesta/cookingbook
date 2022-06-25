using MySql.Data.MySqlClient;
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
    public partial class Lanch : Form
    {
        private string path = string.Empty;
        public Lanch()
        {
            InitializeComponent();
            Subscribe();
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

        private void GetName(string name)
        {
            path = @"C:\Users\Полина\Desktop\cookingbook-main\Projectforkyrs\Projectforkyrs\Resources\";
            string item = path + name + ".jpg";
            PictureBoxImage.Image = Image.FromFile(item);
            DB db = new DB();


            db.openConnection();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `recept_obed` WHERE `recept_obed`.`nazvanie` = '{name}'", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                obed1.Text = reader[1].ToString();
                obed_sostav1.Text = reader[2].ToString();
                obed_recept1.Text = reader[3].ToString();
                kalor.Text = reader[4].ToString();
                belki_n.Text = reader[5].ToString();
                ziry_n.Text = reader[6].ToString();
                uglevody_n.Text = reader[7].ToString();
            }


            db.closeConnection();
        }

        private void bludo1_Click(object sender, EventArgs e)
        {
            obed1.Visible = true;
            obed_sostav1.Visible = true;
            obed_recept1.Visible = true;
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
            GetName(bludo1.Text);
        }

        private void Obed_Load(object sender, EventArgs e)
        {
            obed1.Visible = false;
            obed_sostav1.Visible = false;
            obed_recept1.Visible = false;
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

        private void bludo2_Click(object sender, EventArgs e)
        {
            obed1.Visible = true;
            obed_sostav1.Visible = true;
            obed_recept1.Visible = true;
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
            GetName(bludo2.Text);
        }

        private void bludo4_Click(object sender, EventArgs e)
        {
            obed1.Visible = true;
            obed_sostav1.Visible = true;
            obed_recept1.Visible = true;
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
            GetName(bludo4.Text);
        }

        private void bludo3_Click(object sender, EventArgs e)
        {
            obed1.Visible = true;
            obed_sostav1.Visible = true;
            obed_recept1.Visible = true;
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
            GetName(bludo3.Text);
        }

        private void bludo5_Click(object sender, EventArgs e)
        {
            obed1.Visible = true;
            obed_sostav1.Visible = true;
            obed_recept1.Visible = true;
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
            GetName(bludo5.Text);
        }

        private void bludo6_Click(object sender, EventArgs e)
        {
            obed1.Visible = true;
            obed_sostav1.Visible = true;
            obed_recept1.Visible = true;
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
            GetName(bludo6.Text);
        }

        private void bludo7_Click(object sender, EventArgs e)
        {
            obed1.Visible = true;
            obed_sostav1.Visible = true;
            obed_recept1.Visible = true;
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
            GetName(bludo7.Text);
        }

        Point lastPoint;
        private void Obed_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Obed_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void enterlogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            recept recept = new recept();
            recept.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Полина\Desktop\cookingbook-main\Projectforkyrs\Projectforkyrs\Resources\Video\" + obed1.Text + ".mp4";
            Process.Start(path);
        }
    }
}
