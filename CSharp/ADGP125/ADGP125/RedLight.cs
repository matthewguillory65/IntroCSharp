using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ADGP125
{
    class RedLight : ILight
    {
        public RedLight() { }

        public Stopwatch swr = new Stopwatch();
        private FSM fsm = new FSM();
        public void Enter()
        {
            swr.Reset();
            swr.Start();
        }

        public void RedLightFunction()
        {

        }

        //Sets to GreenLight
        public void GreenLightFunction()
        {
            fsm.currentState = fsm.greenlight;
        }

        public void YellowLightFunction()
        {

        }

        public void Update()
        {
            if (swr.ElapsedMilliseconds >= 60 * 1000)
                Exit();
        }

        public void Exit()
        {
            fsm.currentState = fsm.greenlight;
        }
    }
}
