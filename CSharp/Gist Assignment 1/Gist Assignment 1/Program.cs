using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gist_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int o = 0;
            List<int> nums = new List<int>();
            for (int i = 0; i <= 100; i+=2)
            {
                 nums.Add(i);
                Console.WriteLine(nums.ElementAt(o));
                o++;
            }

            int w = 10;
            for (int j = 0; j <= 40; j++)
            {
                nums.Remove(w);
                Console.WriteLine(nums.ElementAt(j));
                w += 10;
            }
            Console.ReadLine();
        }

    }
}
