using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    class Carrot : EssereVivente
    {
        public Carrot(int X, int Y, int Life=Config.MAX_LIFE)
            : base(X, Y, Life)
        { 
        }
        public Carrot() { }
    }
}
