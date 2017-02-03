using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ADGP125
{
    class GreenLight :ILight
    {
        public GreenLight(FSM fsm) { }
        public Stopwatch swg = new Stopwatch();
        private FSM fsm = new FSM();
        public void Enter()
        {
            swg.Reset();
            swg.Start();
        }

        public void RedLightFunction()
        {

        }

        public void GreenLightFunction()
        {

        }

        //Sets to YellowLight
        public void YellowLightFunction()
        {
            fsm.currentState = fsm.yellowlight;
        }

        public void Update()
        {
            if (swg.ElapsedMilliseconds >= 53 * 1000)
                Exit();
        }

        public void Exit()
        {
            fsm.currentState = fsm.yellowlight;
        }
    }
}
