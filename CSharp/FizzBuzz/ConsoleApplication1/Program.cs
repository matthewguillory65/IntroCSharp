using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> newbie = new List<int>();
            //Exercise 1:
            for(int i = 0; i <= 100; i++)
            {
                if (i % 3 != 0)
                    Console.WriteLine("Fizz");
                if (i % 5 != 0)
                    Console.WriteLine("Buzz");
                if (i % 3 != 0 && i % 5 != 0)
                    Console.WriteLine("FizzBuzz");
                else if (i % 3 != 0 && i % 5 != 0)
                    Console.WriteLine(newbie[i]);
            }
            Console.ReadLine();
        }
    }
}
