using MySql.Data.MySqlClient;
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
    public partial class Receptypolz : Form
    {
        private User _currentUser;
        private string _imagePath;

        public Receptypolz()
        {
            InitializeComponent();
            this.textBoxRecept.AutoSize = false;
            this.textBoxRecept.Size = new Size(this.textBoxRecept.Size.Width, 37);
            this.textBoxIngred.AutoSize = false;
            this.textBoxIngred.Size = new Size(this.textBoxIngred.Size.Width, 37);
        }

        public Receptypolz(User currentUser):this()
        {
            _currentUser = currentUser;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void enterregister_Click(object sender, EventArgs e)
        {
            //var nazvanie = textBoxNazvanie.Text;
            //var ingredient = textBoxIngred.Text;
            //var recept = textBoxUglevody.Text;
            //var kalor = textBoxRecept.Text;
            //var belki = textBoxZiry.Text;
            //var ziry = textBoxBelki.Text;
            //var uglevody = textBoxKalor.Text;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `lichnye_recepty` (`nazvanie`, `sostav`, `recept`, `Energet`, `belki`, `ziry`, `uglevody`, `id_customer`) VALUES (@nazvanie, @sostav, @recept, @Energet, @belki, @ziry, @uglevody, @id_customer)", db.getConnection());


            command.Parameters.Add("@nazvanie", MySqlDbType.VarChar).Value = textBoxNazvanie.Text;
            command.Parameters.Add("@sostav", MySqlDbType.VarChar).Value = textBoxIngred.Text;
            command.Parameters.Add("@recept", MySqlDbType.VarChar).Value = textBoxUglevody.Text;
            command.Parameters.Add("@Energet", MySqlDbType.VarChar).Value = textBoxRecept.Text;
            command.Parameters.Add("@belki", MySqlDbType.VarChar).Value = textBoxZiry.Text;
            command.Parameters.Add("@ziry", MySqlDbType.VarChar).Value = textBoxBelki.Text;
            command.Parameters.Add("@uglevody", MySqlDbType.VarChar).Value = textBoxKalor.Text;
            command.Parameters.Add("@id_customer", MySqlDbType.VarChar).Value = _currentUser.Id;


            db.openConnection();


            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Рецепт добавлен");
                MoveImage moveImage = new MoveImage(_imagePath, textBoxNazvanie.Text);
                moveImage.MovetoProject();
                MoiRecepty moiRecepty = new MoiRecepty();
                moiRecepty.moi_name1.Text = textBoxNazvanie.Text;
                moiRecepty.Show();
                Close();
            }
            else
                MessageBox.Show("Рецепт не был добавлен");

            db.closeConnection();
        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    PictureBoxImage.Image = new Bitmap(ofd.FileName);
                    _imagePath = ofd.FileName;
                }
                catch
                {
                    MessageBox.Show("Невозможно открыть данный файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            ofd.Dispose();
        }
    }
}
