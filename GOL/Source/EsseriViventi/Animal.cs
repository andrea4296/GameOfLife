using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace GiocoDellaVita
{  
    class Animale : EssereVivente 
    {
        protected Config.ALIMENTATION AlimentationType {set;get;}
      
        public Animale(int X, int Y,int Life, Config.ALIMENTATION Alimentation)
            : base(X, Y, Life )
        {


        }
       
        public  bool Eat(Config.ESSERIVIVENTI enemyType)
        {
            if ((int)Entity > (int)enemyType) //TODO operatore >
            {
                switch (AlimentationType)
                {
                    case Config.ALIMENTATION.Carnivorous:
                        if (enemyType > Config.ESSERIVIVENTI.MaxVegetable)
                            return true;
                        break;

                    case Config.ALIMENTATION.Herbivorous:
                        if (enemyType < Config.ESSERIVIVENTI.MaxVegetable)
                            return true;
                        break;

                    case Config.ALIMENTATION.Omnivorous:
                        return true;

                    default:
                        return false;//TODO eccezione  
                }
            }
            return false;
        }
    }
}
