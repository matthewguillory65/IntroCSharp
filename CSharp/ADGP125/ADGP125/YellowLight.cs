using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ADGP125
{
    class YellowLight : ILight
    {
        public YellowLight() { }
        public Stopwatch swy = new Stopwatch();
        private FSM fsm = new FSM();
        public void Enter()
        {
            swy.Restart();
        }

        //Sets to RedLight
        public void RedLightFunction()
        {
            fsm.currentState = fsm.RedLight;
        }

        public void GreenLightFunction()
        {

        }

        public void YellowLightFunction()
        {

        }

        public void Update()
        {
            if (swy.ElapsedMilliseconds >= 7 * 1000)
                Exit();
        }

        public void Exit()
        {
            fsm.currentState = fsm.RedLight;
        }
    }
}
