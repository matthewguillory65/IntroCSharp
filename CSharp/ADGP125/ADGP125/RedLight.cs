using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Diagnostics;

namespace ADGP125
{
    class RedLight : ILight
    {
        public RedLight() { }
        
        public Stopwatch swr = new Stopwatch();
        
        public void Enter()
        {
            swr.Restart();
            //pictureBox1.BackColor = Color.Red;
        }
        public void Update()
        {
            
        }
        public bool Exit(ILight currentState)
        {
            if (swr.ElapsedMilliseconds >= 60 * 1000)
                return true;
            else
                return false;
        }
    }
}
