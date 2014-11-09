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
        protected Config.ESSERIVIVENTI Alimentation;
        public EssereVivente()
        {
        }
        public EssereVivente(int x = 0, int y = 0, int life = 100, bool isDead = false)
        {
            Life = life;
            X = x;
            Y = y;
        }

        public void Update()
        {

        }

    }
}