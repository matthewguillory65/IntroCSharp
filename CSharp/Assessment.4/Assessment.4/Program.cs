using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment._4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Heros Defender = new Heros(10, 200, true);
            Heros Archer = new Heros(160, 140, true);
            Heros Warrior = new Heros(180, 120, true);

            Enemy LavaDragon = new Enemy(300, 180, true);
            Enemy RockDragon = new Enemy(280, 210, true);
            Enemy VolticDragon = new Enemy(190, 300, true);
            Enemy ArmoredDragon = new Enemy(200, 270, true);
            Enemy SkeleDragon = new Enemy(240, 160, true);
            Enemy WaterDragon = new Enemy(140, 260, true);

            List<Heros> Hoomans = new List<Heros>();
            List<Enemy> Drogoons = new List<Enemy>();

            Enemy ActiveDrogoon;

            

            foreach (Heros b in Hoomans) { Hoomans.Add(b); }
            foreach (Enemy z in Drogoons) { Drogoons.Add(z); }

            Random Rand = new Random();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
