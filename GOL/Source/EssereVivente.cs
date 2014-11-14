using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    class EssereVivente
    {
        private int Life { set; get; }
        private bool IsDead { set; get; }
        private int X { set; get; }
        private int Y { set; get; }
        protected Config.ALIMENTATION Alimentation;
        public Config.ESSERIVIVENTI Entity;

        public EssereVivente()
        {
        }
        public EssereVivente(int x = 0, int y = 0, int life = 100, bool isDead = false)
        {
            Life = life;
            X = x;
            Y = y;
        }
       public bool CanMove()
       {
           return true;
          /// return (int)Entity < (int)Config.ESSERIVIVENTI.MaxVegetable;//TODO operator >
 
        }
        public void Update()
        {

        }
        

    }
}