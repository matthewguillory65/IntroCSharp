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
        public Stopwatch stopWatch = new Stopwatch();
        public void Start()
        {
            currentState = redlight;
            currentState.Enter();
            while (true)
            UpdateP();
        }
        void UpdateP()
        {
            if (redlight.Update())
            {
                redlight.Exit(currentState = greenlight);
                greenlight.Enter();
            }

            if (greenlight.Update())
            {
                greenlight.Exit(currentState = yellowlight);
                currentState.Enter();
            }

            if(yellowlight.Update())
            {
                yellowlight.Exit(currentState = redlight);
                currentState.Enter();
            }
        }
        public void StartMachine()
        {
            currentState.Enter();
        }
    }
}
