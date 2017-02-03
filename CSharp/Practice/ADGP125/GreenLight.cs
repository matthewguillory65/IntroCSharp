using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ADGP125
{
    public class GreenLight : ILight
    {
        public GreenLight() { }
        Stopwatch swg;
        private FSM Light;
        public void Enter()
        {
            swg.Start();
        }

        public void RedLightFunction()
        {
            
        }

        public void GreenLightFunction()
        {
            
        }

        public void YellowLightFunction()
        {
            Light.currentState = Light.yellowlight;
        }

        public void Update()
        {
            if (swg.ElapsedMilliseconds >= 53 * 1000)
                Exit();
        }

        public void Exit()
        {
            Light.currentState = Light.yellowlight;
        }

        
    }
}
