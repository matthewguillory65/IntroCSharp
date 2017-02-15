using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment4
{
    public partial class Form1 : Form
    {

        public enum PlayerState
        {
            INIT = 0,
            RED = 1,
            YELLOW = 2,
            GREEN = 3,
            OFF = 9000,
        }

        //class StateTransition
        //{
        //    readonly PlayerState CurrentState;

        //    public StateTransition(PlayerState currentState)
        //    {
        //        CurrentState = currentState;
        //    }
        //}

        public Form1()
        {
            InitializeComponent();
            FSM<PlayerState> PFSM = new FSM<PlayerState>();
            PFSM.Update();
            
            PFSM.AddTransition(PlayerState.INIT, PlayerState.RED);
            PFSM.AddTransition(PlayerState.RED, PlayerState.GREEN);
            PFSM.AddTransition(PlayerState.GREEN, PlayerState.YELLOW);
            PFSM.AddTransition(PlayerState.YELLOW, PlayerState.RED);
            PFSM.AddTransition(PlayerState.RED, PlayerState.OFF);
                        

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
