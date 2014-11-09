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
     
    class Slot
    {
        Random r = new Random();
        public PictureBox pictureBox = new PictureBox();
        public EssereVivente e{set;get;}
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
            pictureBox.Click += new System.EventHandler(pictureBox1_Click);
            pictureBox.Size = new Size(Config.IMAGE_WEIGHT, Config.IMAGE_HEIGHT);
            pictureBox.Show();
            initSlot();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show( X.ToString()+ Y.ToString());
        }
        public void initSlot()
        {
            isUsed = false;
            pictureBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Field;
        }
        public Slot()
        {
        } 
        public bool Enable()
        {
            return isUsed;
        }
        
        public void removeEntity()
        {
            initSlot();
        }
        public void loadEntity( Config.ESSERIVIVENTI entity)
        {
            isUsed = true;
            if (entity == Config.ESSERIVIVENTI.Fox)
            {
                pictureBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Fox;    
                e = new Fox(X, Y);
                
            }
            else
                if (entity == Config.ESSERIVIVENTI.Rabbit)
                {
                    pictureBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Rabbit;                  
                    e = new Rabbit(X, Y);
                }
                else
                {
                    pictureBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Carrot;
                    e = new Carrot(X, Y);
                }     
        }
        public void Move()
        {
            int x = r.Next(0, Config.MAX_X);
            int y = r.Next(0, Config.MAX_Y);
        }
    }
}
