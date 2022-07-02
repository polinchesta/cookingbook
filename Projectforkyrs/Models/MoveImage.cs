using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            DestFileName += text + ".jpg";
            // To move a file or folder to a new location:
            System.IO.File.Copy(imagePath, DestFileName);
        }
    }
}
