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
        Party1 Cloud = new Party1();
        Party1 Tifa = new Party1();
        Party1 Barrett = new Party1();

        Party2 Aeris = new Party2();
        Party2 Vincent = new Party2();
        Party2 Caitsith = new Party2();

        Combat combat = new Combat();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public enum state : int
        {
            INIT = 0,
            ATTACK = 1,
            DEFEND = 2,
        }

        public void SetState(state state)
        {
            switch(state)
            {
                case state.ATTACK:
                    {
                        combat.Attack();
                        break;
                    }
                case state.DEFEND:
                    {
                        combat.Defend();
                        break;
                    }
                case state.INIT:
                    {
                        combat.EndofTurn();
                        break;
                    }
            }


        }

        public class Combat
        {
            public int health;

            public bool alive;

            public void EndofTurn() { }

            public void Attack() { }

            public void Defend() { }
        }

        public class Party1 : Combat
        {

        }

        public class Party2 : Combat
        {

        }

        private void progressBar4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar4.Value += 10;
        }

        private void progressBar3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar3.Value += 10;
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(progressBar5.Value > 0)
            {
                progressBar5.Value -= 10;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

private void progressBar6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            progressBar6.Value += 10;
        }
       
 private void progressBar5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0)
            {
                progressBar2.Value -= 10;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (progressBar6.Value > 0)
            {
                progressBar6.Value -= 10;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value -= 10;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            progressBar2.Value += 10;
            if(progressBar2.Value >= 100)
            {
                progressBar2.Value = 100;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value > 0)
            {
                progressBar3.Value -= 10;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (progressBar4.Value > 0)
            {
                progressBar4.Value -= 10;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            progressBar5.Value += 10;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (progressBar2.Value > 0)
            {
                progressBar2.Value -= 10;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (progressBar3.Value > 0)
            {
                progressBar3.Value -= 10;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (progressBar4.Value > 0)
            {
                progressBar4.Value -= 10;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value -= 10;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (progressBar6.Value > 0)
            {
                progressBar6.Value -= 10;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (progressBar5.Value > 0)
            {
                progressBar5.Value -= 10;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
            {
                progressBar1.Value -= 10;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (progressBar6.Value > 0)
            {
                progressBar6.Value -= 10;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (progressBar5.Value > 0)
            {
                progressBar5.Value -= 10;
            }
        }
    }
}
