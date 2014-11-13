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
            pictureBox.MouseHover += new System.EventHandler(pictureBox1_Hover);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Size = new Size(Config.IMAGE_WEIGHT, Config.IMAGE_HEIGHT);            
            pictureBox.Show();
            initSlot();
        }
        private void pictureBox1_Hover(object sender, EventArgs e)
        {
            if (Enable())
            {
                if (eV.TypeElement == Config.ESSERIVIVENTI.Fox)
                    PlayGround.label1.Text = "Fox";
                else
                    if (eV.TypeElement == Config.ESSERIVIVENTI.Rabbit)
                        PlayGround.label1.Text = "Rabbit";
                    else
                        if (eV.TypeElement == Config.ESSERIVIVENTI.Carrot)
                            PlayGround.label1.Text = "Carrot";
            }
            else
                PlayGround.label1.Text = "";
        }
        public void initSlot()
        {
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
            initSlot();
            return eV.TypeElement;
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
            eV.TypeElement = entity;
        }
        public void Move(ref int tmpX, ref int tmpY)
        {
            if (eV.CanMove())
            {
                do
                {
                    tmpX = r.Next(-1, 2) + X;
                    tmpY = r.Next(-1, 2) + Y;
                } while ( ((tmpX <= 0) || (tmpX >= Config.MAX_X)) || ((tmpY <= 0) || (tmpY >= Config.MAX_Y)) );
                
            }
        }
    }
}
