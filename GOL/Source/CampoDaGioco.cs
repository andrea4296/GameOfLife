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
        public static Slot[,] Field;
        Random r = new Random();
        public static Label label1 = new Label();
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
            label1.AutoSize = true;
            label1.Location = new Point(638, 214);
            label1.Name = "label1";
            label1.Size = new Size(35, 13);
            label1.TabIndex = 5;
            f.Controls.Add(label1);            
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
            } while (isEnable(x, y));
            Field[x, y].loadEntity(e);
            entityCount++;
            return true;
        }

        public static bool isEnable(int x, int y)
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
            bool flag = true;
            while (flag)
            {            
                int tmpX = 0, tmpY = 0;
                Slot s;
                do
                {
                    tmpX = r.Next(0, Config.MAX_X);
                    tmpY = r.Next(0, Config.MAX_Y);
                } while (!isEnable(tmpX, tmpY));
                s = Field[tmpX, tmpY];
                s.GetNextPos(ref tmpX, ref tmpY);

                if (!(s.eV is Animale) ) {
                    Begin();
                    return;
                }
                if (Field[tmpX, tmpY].eV == null)
                { 
                    Field[tmpX, tmpY].loadEntity(s.removeEntity());
                    return;
                }
                if (((Animale)s.eV).Eat(Field[tmpX, tmpY].eV.Entity))
                    Field[tmpX, tmpY].loadEntity(s.removeEntity());
                /*
                int herbAlive=0, vegetAlive=0,carnAlive=0;
                foreach (Slot q in Field)
                {
                    if (q.eV == null)
                        herbAlive++;
                    else if (q.eV.Entity > Config.ESSERIVIVENTI.MaxVegetable)
                        carnAlive++;
                    else if(q.eV.Entity < Config.ESSERIVIVENTI.MaxVegetable)
                        vegetAlive++;
                }
                if ((herbAlive == 0 && vegetAlive == 0) || (herbAlive == 0 && carnAlive == 0))
                    flag = false;
                 */

            }
        }
    }
}