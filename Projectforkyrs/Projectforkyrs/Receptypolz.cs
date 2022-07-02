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
    public partial class Receptypolz : Form
    {
        private User _currentUser;
        private string _imagePath;
        
        public Receptypolz()
        {
            InitializeComponent();
            this.textBoxRecept.AutoSize = false;
            this.textBoxRecept.Size = new Size(this.textBoxRecept.Size.Width, 33);
            this.textBoxIngred.AutoSize = false;
            this.textBoxIngred.Size = new Size(this.textBoxIngred.Size.Width, 33);
        }

        public Receptypolz(User currentUser) : this()
        {
            _currentUser = currentUser;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void enterregister_Click(object sender, EventArgs e)
        {

            DB db = new DB();

            if (textBoxNazvanie.Text == string.Empty)
            {
                MessageBox.Show("Введите название хотя бы");
            }
            else
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO `lichnye_recepty` (`nazvanie`, `sostav`, `recept`, `Energet`, `belki`, `ziry`, `uglevody`, `id_customer`) VALUES (@nazvanie, @sostav, @recept, @Energet, @belki, @ziry, @uglevody, @id_customer)", db.getConnection());

                command.Parameters.Add("@nazvanie", MySqlDbType.VarChar).Value = textBoxNazvanie.Text;
                command.Parameters.Add("@sostav", MySqlDbType.VarChar).Value = textBoxIngred.Text;
                command.Parameters.Add("@recept", MySqlDbType.VarChar).Value = textBoxRecept.Text;
                command.Parameters.Add("@Energet", MySqlDbType.VarChar).Value = textBoxKalor.Text;
                command.Parameters.Add("@belki", MySqlDbType.VarChar).Value = textBoxBelki.Text;
                command.Parameters.Add("@ziry", MySqlDbType.VarChar).Value = textBoxZiry.Text;
                command.Parameters.Add("@uglevody", MySqlDbType.VarChar).Value = textBoxUglevody.Text;
                command.Parameters.Add("@id_customer", MySqlDbType.VarChar).Value = _currentUser.Id;

                db.openConnection();


                if (command.ExecuteNonQuery() == 1)
                {

                    MessageBox.Show("Рецепт добавлен");
                    MoveImage moveImage = new MoveImage(_imagePath, textBoxNazvanie.Text);
                    moveImage.MovetoProject();
                    MoiRecepty moiRecepty = new MoiRecepty(_currentUser);
                    moiRecepty.moi_name1.Text = textBoxNazvanie.Text;
                    moiRecepty.Show();
                    Close();
                }
                else
                    MessageBox.Show("Рецепт не был добавлен");
                db.closeConnection();
            }

        }

        private void openfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();


            if (ofd.ShowDialog() == DialogResult.OK)
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

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Black;
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.ForeColor = Color.Red;
        }


        Point lastPoint;
        private void Receptypolz_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Receptypolz_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            this.Hide();
            Windowsposleavrizacii windowsposleavrizacii = new Windowsposleavrizacii(_currentUser);
            windowsposleavrizacii.Show();
        }
    }
}
