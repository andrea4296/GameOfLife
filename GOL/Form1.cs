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
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
            t.Interval = 300; 
            t.Tick += new EventHandler(timer_Tick);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            Field.Begin();
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
            t.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Config.GitUrl);
        }
    }
}
