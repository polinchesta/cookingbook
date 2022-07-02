using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectforkyrs.Exceptions
{
    public class MoveImageException : Exception
    {
        public MoveImageException(string message) : base(message)
        {
        }
    }
}
