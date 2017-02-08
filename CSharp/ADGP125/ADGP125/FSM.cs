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
        public ILight redLight;

        void Update()
        {
            currentState = redLight;
        }

        public void Enter()
        {
            
        }

        public void StartMachine(ILight state)
        {
            currentState = state;
            currentState.Enter(currentState);
        }
    }
}
