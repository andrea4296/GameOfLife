using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{  
    class Animale : EssereVivente 
    {
        public Animale()
            : base ()
        {}
        public Animale(int X, int Y, int Vita, bool Morto, Config.ALIMENTATION Alimentation)
            : base(X, Y, Vita, Morto)
        {

        }
        protected Config.ALIMENTATION Alimentation;
        public  bool Eat(Config.ESSERIVIVENTI T)
        {
            if ((Alimentation == Config.ALIMENTATION.Onnivoro) && ((int)type > (int)T))
            {
                return true;
            }
            else if(Alimentation == Config.ALIMENTATION.Carnivoro )
            {

            }

        }

        //public abstract void Move();
    }
}
