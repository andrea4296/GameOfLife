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
    class PlayGround
    {       
        public static int entityCount = 0;
        private Slot[,] Field;
        Random r = new Random();

        public PlayGround(Form f)
        {
            int index = 0;
            Field = new Slot[Config.MAX_X, Config.MAX_Y];
            for (int i = 0; i < Config.MAX_X; i++)
            {
                for (int j = 0; j < Config.MAX_Y; j++)
                {
                    Slot s = new Slot(index,i, j);
                    Field[i, j] = s;
                    f.Controls.Add(s.pictureBox);
                    index ++;
                }
            }
        }
        public bool Load(Config.ESSERIVIVENTI e)
        {
            if (entityCount == Config.MAX_X * Config.MAX_Y)
                return false;
            int x, y;
           do
            {
                x = r.Next(0, Config.MAX_X);
                y = r.Next(0, Config.MAX_Y);
            } while (isEnable(x, y)) ;
            Field[x, y].loadEntity(e);
            entityCount++;
            return true;
        }
        public bool isEnable(int x, int y)
        {
            if(x>=0 && y >= 0)
           
                return Field[x, y].Enable();

            return false;
            
           
        }
        public Slot this[int a,int b]
        {
            get { return Field[a, b]; }
        }
        public void Begin()
        {
           int x,y;
           Slot s;
           do
           {
               x = r.Next(0, Config.MAX_X);
               y = r.Next(0, Config.MAX_Y);
           } while (!isEnable(x, y));
           s = Field[x, y];
            do
           {
               x = r.Next(-1, 1);
               y = r.Next(-1, 1);
             
           } while (isEnable(s.X+x, s.Y+y));
           s.removeEntity();
          // s = Field[X+x, y+y];
            
        }
    }
}