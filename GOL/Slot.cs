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
        public PictureBox pictureBox = new PictureBox();
        public EssereVivente e;
        public int X { get; set; }
        public int Y { get; set; }
        private bool isUsed;
        public Slot(int index, int x, int y)
        {
            isUsed = false;
            X = x;
            Y = y;
            //((System.ComponentModel.ISupportInitialize)(pictureBox)).BeginInit();
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point((x * 48) + 50, (y * 47) + 50);
            pictureBox.Name = "pictureBox" + (index++).ToString();
            pictureBox.Size = new Size(Config.ImageWeight, Config.ImageHeight);
            pictureBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Field;
            //f.pictureBox.Click += new System.EventHandler(f.pictureBox_Click);
            pictureBox.Show();
        }
        public Slot()
        {
        } 
        public bool Enable()
        {
            return isUsed;
        }
        
        public void loadEntity(int x, int y, Config.ESSERIVIVENTI entity)
        {
            isUsed = true;
            if (entity == Config.ESSERIVIVENTI.Volpe)
            {
                pictureBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Fox;    
                e = new Volpe(x, y);
                
            }
            else
                if (entity == Config.ESSERIVIVENTI.Coniglio)
                {
                    pictureBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Rabbit;                  
                    e = new Coniglio(x, y);
                }
                else
                {
                    pictureBox.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Carrot;                   
                    e = new Carota(x, y);
                }     
        }
        //public bool CanMove()
        //{

        //}
    }
}
