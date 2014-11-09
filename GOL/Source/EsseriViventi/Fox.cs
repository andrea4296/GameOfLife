using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    class Fox : Animale
    {
     
        public Fox(int X, int Y,int Life=Config.MAX_LIFE, Config.ALIMENTATION Alimentation = Config.ALIMENTATION.Carnivorous) 
            : base(X, Y, Life, Alimentation) 
        {
        }


    }
}
