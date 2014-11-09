using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    class Config
    {
        public enum ESSERIVIVENTI: int { Carrot, MaxVegetable, Rabbit, Fox }
        public enum ALIMENTATION : int { Herbivorous, Carnivorous, Omnivorous }
        public const int MAX_LIFE = 100;
        public const int MAX_X = 10;
        public const int MAX_Y = 10;
        public const int IMAGE_HEIGHT = 50;
        public const int IMAGE_WEIGHT = 50;
        public static string OverFlowMessage = "Too much objects";
    }
}