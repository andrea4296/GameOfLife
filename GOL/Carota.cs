using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    class Carota : EssereVivente
    {
        public Carota(int X = 0, int Y = 0, int Vita = 50, bool Morto = false)
            : base(X, Y, Vita, Morto)
        { 
        }
        public Carota() { }
    }
}
