using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ADGP125
{
    class RedLight : ILight {
        Stopwatch sw;
        public void Enter()
        {
            sw.Start();
            
        }

        public void Update()
        {
            if (sw.ElapsedMilliseconds >= 60)
                Exit();
        }

        public void Exit()
        {
            
        }

        
    }
}
