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
            List<int> nums = new List<int>();
            List<int> numb = new List<int>();
            for (int i = 0; i < 101; i++)
            {
                if (i % 2 == 0)
                    nums.Add(i);
            }

            foreach (var num in nums)
            {
                Console.WriteLine(nums.ElementAt(i));
            }

            for (int j = 0; j < 101; j++)
            {
                numb.Add(j);

                if (j % 10 == 0) numb.Remove(j);
                    Console.WriteLine(numb.ElementAt(j));
            }
            Console.ReadLine();
        }

    }
}
