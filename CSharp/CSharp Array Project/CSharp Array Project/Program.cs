using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Array_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number "1"
            //A loop to initialize arr(int data[10]) with the values 10, 9, 8... (etc).
            int i;
            List<int> luups = new List<int>();
            for (i = 0; i < 10; i++)
                luups.Add(i);
            Console.WriteLine(luups.ElementAt(i));
            Console.ReadLine();


            //Number "2"
            //Asks the user for 5 numbers, stores them, and prints them out in a reverse order.
            List<int> nums = new List<int>();
            Console.WriteLine("Please give me 5 numbers");
            for (int i = 0; i < 5; i++)
            {
                nums.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("\nThese are the numbers reversed \n");
            for (int i = 4; i >= 0; i--)
            {
                Console.WriteLine(nums[i].ToString());
            }

            Console.ReadLine();


            //Number "3"
            //The user inputs 10 numbers, then displays the largest and smallest values.
            List<int> small = new List<int>();
            Console.WriteLine("Please give me 10 numbers");
            for (int i = 0; i < 10; i++)
            {
                small.Add(Convert.ToInt32(Console.ReadLine()));
            }
            int largeNumber = small[0];
            int smallNumber = small[0];
            int d;
            //Console.WriteLine("\nThe largest number is:\n");
            for (d = 0; d < 10; d++)
            {

                if (largeNumber < small[d])
                    largeNumber = small[d];
                Console.WriteLine(largeNumber);

                if (smallNumber > small[d])
                    smallNumber = small[d];
                Console.WriteLine(smallNumber);
            }
            Console.ReadLine();

            //Number "4"

        }
        
    }

}
