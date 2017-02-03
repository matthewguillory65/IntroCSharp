using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADGP125
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FSM fsm = new FSM();
            RedLight redLightState = new RedLight();

        

            fsm.StartMachine(redLightState);

            

            //while (true)
            //    fsm.Update();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LightSystem());
        }
    }
}
