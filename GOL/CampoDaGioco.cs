using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GiocoDellaVita
{
    class CampoDaGioco
    {       
        public static int entityCount = 0;
        private Slot[,] Campo;
        Random r = new Random(); 
        public CampoDaGioco(Form f)
        {
            Campo = new Slot[Config.maxX, Config.maxY];
            int index =  0;
            for (int i = 0; i < Config.maxX; i++)
            {
                for (int j = 0; j < Config.maxY; j++)
                {
                    Slot s = new Slot(index, i, j);
                    Campo[i, j] = s;
                    f.Controls.Add(s.pictureBox);
                }
            }
        }
        public bool Load(Config.ESSERIVIVENTI e)
        {
            if (entityCount == Config.maxX * Config.maxY)
                return false;
            
            
            int x = r.Next(0, Config.maxX);
            int y = r.Next(0, Config.maxY);
            while (isEnable(x, y)) 
            {
                x = r.Next(0, Config.maxX);
                y = r.Next(0, Config.maxY);
            }
            Campo[x, y].loadEntity(x, y, e);
            entityCount++;
            return true;
        }
        public bool isEnable(int x, int y)
        {
            return Campo[x, y].Enable();
        }
        public Slot this[int a,int b]
        {
            get { return Campo[a, b]; }
        }
        public void Begin()
        {
            int x = r.Next(0, Config.maxX);
            int y = r.Next(0, Config.maxY);
            while (!isEnable(x, y))
            {
                x = r.Next(0, Config.maxX);
                y = r.Next(0, Config.maxY);
            }
        }
    }
}