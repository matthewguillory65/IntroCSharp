using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            //Problem 1:
            if (y == 0)
            {
                int x = 100;
            }

            //Problem 2:
            List<int> yuh = new List<int>();
            yuh.Add(Convert.ToInt32(Console.ReadLine()));
            yuh.Add(Convert.ToInt32(Console.ReadLine()));
            int uno = yuh[0];
            int dos = yuh[1];

            if (uno < dos)
            {
                Console.WriteLine(dos);
            }
            else if(dos < uno)
            {
                Console.WriteLine(uno);
            }
            Console.ReadLine();
        }
    }
}
