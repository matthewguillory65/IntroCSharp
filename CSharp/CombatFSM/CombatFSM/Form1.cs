using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatFSM
{
    public partial class Form1 : Form
    {
        Party Cloud = new Party();
        Party Tifa = new Party();
        Party Barrett = new Party();

        Party Aeris = new Party();
        Party Vincent = new Party();
        Party Caitsith = new Party();

        Combat combat = new Combat();
        
        public Form1()
        {
            InitializeComponent();
            Party Pa = new Party();
            Player Cloud = new Player();
            Player Tifa = new Player();
            Player Barrett = new Player();
            Player Aeris = new Player();
            Player Vincent = new Player();
            Player Caitsith = new Player();
            Pa.AddPlayer(Cloud);
            Pa.AddPlayer(Tifa);
            Pa.AddPlayer(Barrett);
            Pa.AddPlayer(Aeris);
            Pa.AddPlayer(Vincent);
            Pa.AddPlayer(Caitsith);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void progressBar4_Click(object sender, EventArgs e)
        {

        }
        private void progressBar3_Click(object sender, EventArgs e)
        {

        }
        private void progressBar2_Click(object sender, EventArgs e)
        {

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void progressBar6_Click(object sender, EventArgs e)
        {

        }
        private void progressBar5_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Heal function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            progressBar4.Value += 10;
            if(progressBar4.Value > 100)
            {
                progressBar4.Value = 100;
            }
        }

        /// <summary>
        /// Heal function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
            if(progressBar3.Value > 100)
            {
                progressBar3.Value = 100;
            }
        }

        /// <summary>
        /// Heal function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value > 100)
            {
                progressBar1.Value = 100;
            }
        }

        /// <summary>
        /// Heal function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            progressBar6.Value += 10;
            if (progressBar6.Value > 100)
            {
                progressBar6.Value = 100;
            }
        }

        /// <summary>
        /// Heal function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if (progressBar2.Value > 100)
            {
                progressBar2.Value = 100;
            }
        }

        /// <summary>
        /// Heal Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            progressBar5.Value += 10;
            if (progressBar5.Value > 100)
            {
                progressBar5.Value = 100;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if(progressBar5.Value > 0)
            {
                progressBar5.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0)
            {
                progressBar2.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (progressBar6.Value > 0)
            {
                progressBar6.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value > 0)
            {
                progressBar3.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            if (progressBar4.Value > 0)
            {
                progressBar4.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button15_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0)
            {
                progressBar2.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button13_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value > 0)
            {
                progressBar3.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button14_Click(object sender, EventArgs e)
        {
            if (progressBar4.Value > 0)
            {
                progressBar4.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button16_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button17_Click(object sender, EventArgs e)
        {
            if (progressBar6.Value > 0)
            {
                progressBar6.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button18_Click(object sender, EventArgs e)
        {
            if (progressBar5.Value > 0)
            {
                progressBar5.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button21_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button20_Click(object sender, EventArgs e)
        {
            if (progressBar6.Value > 0)
            {
                progressBar6.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button19_Click(object sender, EventArgs e)
        {
            if (progressBar5.Value > 0)
            {
                progressBar5.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button22_Click(object sender, EventArgs e)
        {
            if (progressBar4.Value > 0)
            {
                progressBar4.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button23_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value > 0)
            {
                progressBar3.Value -= 10;
            }
        }

        /// <summary>
        /// Damage Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button24_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0)
            {
                progressBar2.Value -= 10;
            }
        }

        /// <summary>
        /// Ending of the player's turn
        /// </summary>
        public void EndTurn()
        {
            
        }
    }   
}
