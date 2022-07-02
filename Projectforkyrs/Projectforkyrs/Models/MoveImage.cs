using Projectforkyrs.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projectforkyrs.Models
{
    internal class MoveImage
    {
        private string DestFileName = "../../Resources/";
        private string imagePath;
        private string text;

        public MoveImage(string imagePath, string text)
        {
            this.imagePath = imagePath;
            this.text = text;

        }

        public void MovetoProject()
        {
            try 
            {
                DestFileName += text + ".jpg";

                if (imagePath == null)
                {
                    throw new ArgumentNullException("Вы не добавили картинку");
                }
                else
                {
                    System.IO.File.Copy(imagePath, DestFileName);
                }
            }
            catch (ArgumentNullException ex) 
            { 
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            
            
        }
    }
}
