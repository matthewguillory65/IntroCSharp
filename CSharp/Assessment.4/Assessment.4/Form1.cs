using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public void Attacking(Heros H1, Heros H2, Enemy Dragon)
        {
            if (H1.Attack + H2.Attack > Dragon.Attack)
            {
                Dragon.Alive = false;
            }
            if (H1.Attack + H2.Attack < Dragon.Attack)
            {
                H1.Alive = false; H2.Alive = false;
            }
        }
        public void Defending(Heros H1, Heros H2, Enemy Dragon)
        {
            int NewAttack;
            int BothDefense;
            if (H1.Defense + H2.Defense > Dragon.Attack)
            {
                BothDefense = H1.Defense + H2.Defense;
                NewAttack = BothDefense - Dragon.Attack;
                Dragon.Attack = NewAttack;
            }
            if (H1.Defense + H2.Defense < Dragon.Attack)
            {
                H1.Alive = false; H2.Alive = false;
            }
        }

        public void StartTurn()
        {

        }

        public void ChoosePlayers(Heros a, Heros b)
        {

        }

        public void DragonsNameandAttack()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Attacking();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Defending();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //textBox2.Text = ActiveDrogoon.Attack.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            //textBox3.Text = ActiveDrogoon.Defense.ToString();
        }
    }
}
