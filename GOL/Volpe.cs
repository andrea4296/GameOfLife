using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    class Volpe : Animale
    {
        public Volpe(int X = 0, int Y = 0, int Vita = 50, bool Morto = false, Config.ALIMENTATION Alimentation = Config.ALIMENTATION.Carnivoro) 
            : base(X, Y, Vita, Morto, Alimentation) 
        {
        }


    }
}
