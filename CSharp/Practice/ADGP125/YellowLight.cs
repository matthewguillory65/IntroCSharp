using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ADGP125
{
    public class YellowLight : ILight
    {
        public YellowLight() { }
        Stopwatch swy;
        private FSM Light;
        public void Enter()
        {
            swy.Start();
        }

        public void RedLightFunction()
        {
            Light.currentState = Light.redlight;
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
            Light.currentState = Light.redlight;
        }

        
    }
}
