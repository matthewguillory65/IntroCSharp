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

    }
}
