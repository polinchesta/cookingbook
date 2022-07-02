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
    public partial class MoiRecepty : Form
    {

        public MoiRecepty()
        {
            InitializeComponent();
        }

        private void MoiRecepty_Load(object sender, EventArgs e)
        {
            PictureBoxImage.ImageLocation = "../../Resources/" + moi_name1.Text + ".jpg";
            DB db = new DB();

            //Receptypolz rec = new Receptypolz();

            db.openConnection();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `lichnye_recepty` WHERE `lichnye_recepty`.`nazvanie` = '{moi_name1.Text}'", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                moi_name1.Text = moi_name1.Text;
                moi_sostav1.Text = reader[2].ToString();
                moi_recept1.Text = reader[4].ToString();
                kalor.Text = reader[3].ToString();
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
            Windowsposleavrizacii windowsposleavrizacii = new Windowsposleavrizacii();
            windowsposleavrizacii.Show();
        }
    }
}
