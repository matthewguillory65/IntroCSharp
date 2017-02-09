using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace ADGP125
{
    class GreenLight : ILight
    {
        public GreenLight() { }
        public Stopwatch swg = new Stopwatch();
        
        public void Enter()
        {
            swg.Restart();
            //pictureBox1.Visible == true;
            //pictureBox1.BackColor = Color.Green;
        }
        public void Update()
        {
            
        }

        public bool Exit(ILight currentState)
        {
            if (swg.ElapsedMilliseconds >= 53 * 1000)
                return true;
            else
                return false;
        }
    }
}
