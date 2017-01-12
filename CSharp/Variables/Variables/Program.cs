using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nuke = new List<int>();
            //Problem 1:
            //Swapping 2 numbers
            nuke.Add(Convert.ToInt32(Console.ReadLine()));
            nuke.Add(Convert.ToInt32(Console.ReadLine()));

            int a = nuke[0];
            int b = nuke[1];
            a = a + b;
            b = a - b;
            a = a - b;
            
            Console.WriteLine("Consider them switched.");
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Problem2:
            //Ask for 5 numbers, then find the average of the numbers given
            //(Convert.ToInt32(Console.ReadLine()));


            Console.ReadLine();
            nuke.Contains(1);
        }
        
    }
}
