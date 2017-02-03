using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP125
{
    class FSM
    {
        public FSM() { }
        public ILight currentState;
        public RedLight redlight;
        public GreenLight greenlight;
        public YellowLight yellowlight;

        public void StartMachine(ILight state)
        {
            currentState = state;
            currentState.Enter();
        }

        void Update()
        {

        }
    }
}
