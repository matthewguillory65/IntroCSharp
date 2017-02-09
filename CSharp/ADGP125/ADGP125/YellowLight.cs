using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Drawing;

namespace ADGP125
{
    class YellowLight : ILight
    {
        public YellowLight() { }
        public Stopwatch swy = new Stopwatch();
        
        public void Enter()
        {
            swy.Restart();
            //pictureBox1.BackColor = Color.Yellow;
        }
        public void Update()
        {
           
        }
        public bool Exit(ILight currentState)
        {
            if (swy.ElapsedMilliseconds >= 7 * 1000)
                return true;
            else
                return false;
        }
    }
}
