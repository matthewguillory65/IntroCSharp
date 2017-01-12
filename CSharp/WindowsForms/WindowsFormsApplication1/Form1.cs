using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public int exp = 13;

        public int exp2 = 0;

        public int Lvl = 2;

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;

            Experience();

            if (progressBar1.Value >= 100)
            {
                progressBar1.Value = 0;
                LevelUp();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(progressBar1.Value > 0)
            {
                progressBar1.Value -= 10;
            }
        }

        public void LevelUp()
        {
            textBox1.Text = "Lvl " + Lvl;
                Lvl += 1;
        }

        public class Player
        {
            
        }

        private void Experience()
        {
            textBox2.Text = "Exp: " + exp;
            exp += 13;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value -= 10;
            }
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar3.Value += 10;

            if (progressBar3.Value >= 100)
            {
                progressBar3.Value = 0;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            progressBar2.Value += 10;

            if (progressBar2.Value >= 100)
            {
                progressBar2.Value = 0;
            }
        }
    }
}
