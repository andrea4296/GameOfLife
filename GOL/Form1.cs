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
    public partial class Form1 : Form
    {
        PlayGround Field;
        public Form1()
        {
            InitializeComponent();           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Field = new PlayGround(this);            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!Field.Load(Config.ESSERIVIVENTI.Fox))
                MessageBox.Show(Config.OverFlowMessage);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Field.Load(Config.ESSERIVIVENTI.Rabbit))
                MessageBox.Show(Config.OverFlowMessage);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Field.Load(Config.ESSERIVIVENTI.Carrot))
                MessageBox.Show(Config.OverFlowMessage);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Field.Begin();
        }

       
    }
}
