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
        public FSM()
        {
            
        }
        public ILight currentState;
        public GreenLight greenlight = new GreenLight();
        public YellowLight yellowlight = new YellowLight();
        public RedLight redlight = new RedLight();
        public void Start()
        {
            currentState = redlight;
            currentState.Enter();
            while (true)
            UpdateP();
        }
        void UpdateP()
        {
            if(currentState.Exit(redlight) == true)
            {
                currentState = greenlight;
            }

            if (currentState.Exit(greenlight) == true)
            {
                currentState = yellowlight;
            }

            if (currentState.Exit(yellowlight) == true)
            {
                currentState = redlight;
            }

            currentState.Update();
        }
        public void StartMachine()
        {
            currentState.Enter();
        }
    }
}
