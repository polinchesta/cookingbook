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
    public partial class Zavtrak : Form
    {
        public Zavtrak()
        {
            InitializeComponent();
        }



        private void bludo1_Click(object sender, EventArgs e)
        {
            zavtrak1.Visible = true;
            zavtrak_sostav1.Visible = true;
            syrniki.Visible = true;
            GetName(bludo1.Text);
        }

        private void Zavtrak_Load(object sender, EventArgs e)
        {
            zavtrak1.Visible = false;
            zavtrak_sostav1.Visible = false;
            syrniki.Visible = false;
        }

        private void GetName(string name)
        {

            DB_zavtrak db = new DB_zavtrak();
            //MySqlCommand command = new MySqlCommand("INSERT INTO `recept_customer` (`nazvanie`, `sostav`) VALUES (@nazvanie, @sostav)", db.getConnection());




            db.openConnection();

            MySqlCommand command = new MySqlCommand($"SELECT * FROM `recept_zavtrak` WHERE `recept_zavtrak`.`nazvanie` = '{name}'", db.getConnection());
            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = zavtrak1.Text;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                zavtrak1.Text = reader[1].ToString();
                zavtrak_sostav1.Text = reader[2].ToString();
            }


            db.closeConnection();
        }

        private void bludo2_Click(object sender, EventArgs e)
        {
            zavtrak1.Visible = true;
            zavtrak_sostav1.Visible = true;
            syrniki.Visible = false;
            GetName(bludo2.Text);
        }
    }
}
