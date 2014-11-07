using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiocoDellaVita
{
    class Config
    {
        public enum ESSERIVIVENTI { Carota, MaxVegetable, Coniglio, Volpe }
        public enum ALIMENTATION { Erbivoro, Carnivoro, Onnivoro }
        public const int maxX = 10;
        public const int maxY = 10;
        public const int ImageHeight = 50;
        public const int ImageWeight = 50;
        public static string OverFlowMessage = "Troppi Oggetti";
    }
}