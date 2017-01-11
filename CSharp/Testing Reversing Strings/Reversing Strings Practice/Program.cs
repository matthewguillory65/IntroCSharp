using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversing_Strings_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();

            fruits.Add("Apple");
            fruits.Add("Orange");
            fruits.Add("Pineapple");
            fruits.Add("Grape");
            fruits.Add("Grapefruit");

            Console.WriteLine();
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            fruits.Reverse();

            Console.WriteLine();
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadLine();
        }
    }
}
