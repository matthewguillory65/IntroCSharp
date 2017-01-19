using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Work
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Lights
    {
        public enum LightsState
        {
            INIT = 0,
            RED = 1,
            GREEN = 2,
            YELLOW = 3,
            END = 9000,
        }

        public void Red()
        {

        }

        public void Green()
        {

        }

        public void Yellow()
        {
            
        }

        public void Lightchange()
        {
            bool Power = true;
            if(Power == true)
            {
                Stopwatch.StartNew(); 
            }
        }
    }
}
