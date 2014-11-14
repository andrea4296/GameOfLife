using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Properties;

namespace GiocoDellaVita
{     
    class Slot
    {
       
        Random r = new Random();
        public PictureBox pictureBox = new PictureBox();
        public EssereVivente eV{set;get;}
        public int X { get; set; }
        public int Y { get; set; }
        private bool isUsed;
        public Slot(int index, int x, int y)
        {          
            
            X = x;
            Y = y;
           
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            
            pictureBox.Location = new Point((x * 48) + 50, (y * 47) + 50);
            pictureBox.Name = "pictureBox" + (index).ToString();
           // pictureBox.MouseHover += new System.EventHandler(pictureBox1_Hover);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(Config.IMAGE_WEIGHT, Config.IMAGE_HEIGHT);            
            pictureBox.Show();
            initSlot();
        }

        public void initSlot()
        {
          
            eV = null;
            isUsed = false;
            pictureBox.BackColor = Color.Green;
            pictureBox.Image = Resources.Field;  
        }
        public Slot()
        {
        } 
        public bool Enable()
        {
            return isUsed;
        }        
        public Config.ESSERIVIVENTI  removeEntity()
        {
            Config.ESSERIVIVENTI e = eV.Entity;
            PlayGround.entityCount -= 1;
           initSlot();
            return e;


        }
        public void loadEntity(Config.ESSERIVIVENTI entity)
        {
           
            isUsed = true;            
            if (entity == Config.ESSERIVIVENTI.Fox)
            {
                pictureBox.Image = Resources.Fox;    
                eV = new Fox(X, Y);                
            }
            else
                if (entity == Config.ESSERIVIVENTI.Rabbit)
                {
                    pictureBox.Image = Resources.FedoRabbit;                  
                    eV = new Rabbit(X, Y);
                }
                else
                {
                    pictureBox.Image = Resources.Carrot;
                    eV = new Carrot(X, Y);
                }
            eV.Entity = entity;
        }
        public void GetNextPos(ref int risX, ref int risY)
        {
            int tmpX, tmpY;
           
           //if (eV.CanMove())
            {
                do
                {
                    tmpX = r.Next(-1, 2) + X;
                    tmpY = r.Next(-1, 2) + Y;
                } while ( ((tmpX <= 0) || (tmpX >= Config.MAX_X)) || ((tmpY <= 0) || (tmpY >= Config.MAX_Y) || (risX == tmpX && risY == tmpY) ) );
                risX = tmpX;
                risY = tmpY;
            }
        }
    }
}
