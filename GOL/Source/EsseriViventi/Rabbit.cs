using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    class Rabbit : Animale
    {
        public Rabbit(int X = 0, int Y = 0, int Life = Config.MAX_LIFE, Config.ALIMENTATION Alimentation = Config.ALIMENTATION.Herbivorous)
            : base(X, Y, Life, Alimentation)
        { 
        }
        
    }
}
