using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ADGP125
{
    class FSM
    {
        public FSM() { }
        public ILight currentState;
        public ILight greenlight;
        public ILight yellowlight;
        public ILight RedLight;
        //public FSM fsm = new FSM();
        
        void Update()
        {
            currentState = RedLight;
        }

        public void Enter(RedLight redlight)
        {
            
        }

        public void StartMachine(ILight state)
        {
            currentState = state;
            currentState.Enter(redlight);
        }
    }
}
