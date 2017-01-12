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
        Person Cloud = new Person();
        Person Tifa = new Person();
        Person Barrett = new Person();

        People Aeris = new People();
        People Vincent = new People();
        People Caitsith = new People();
        
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
                        Cloud.Attack();
                        break;
                    }
                case state.DEFEND:
                    {
                        Cloud.Defend();
                        break;
                    }
                case state.INIT:
                    {
                        Cloud.EndofTurn();
                        break;
                    }
                    break;
            }


        }

        public class Combat
        {
            public void EndofTurn() { }

            public void Attack() { }

            public void Defend() { }
        }

        public class Person : Combat
        {

        }

        public class People : Combat
        {

        }

    }
}
