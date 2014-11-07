using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    class EssereVivente 
    {
        private int mVita;
        private bool mMorto;
        private int mX;
        private int mY;
        protected Config.ESSERIVIVENTI type;
        public EssereVivente()
        {
        }
        public EssereVivente(int X, int Y, int Vita, bool Morto) 
        {
            mVita = Vita;
            mMorto = Morto;
            mX = X;
            mY = Y;
        }
        public int Vita 
        {
            get { return mVita; }
            set { mVita = value; }
        }
        public bool Morto
        {
            get { return mMorto; }
            set { mMorto = value; }
        }
        /*
        public int X
        {
            get { return mX; }
            set { mX = value; }
        }
        public int Y
        {
            get { return mY; }
            set { mY = value; }
        }
         */
        public void Aggiorna() 
        {

        }

    }
}
