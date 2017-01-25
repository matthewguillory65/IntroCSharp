using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._25
{
    class Program
    {
        //Write a function that takes in an argument
        //a string representation of a binary number
        //whose maximum amount is (2^8)-1.
        //This function must return a string matching this format
        //except the first half should be the exact opposite of the second half.
        static public char Invert(char s)
        {
            return ((s == '0') ? '1' : '0');
        }

        public class Gene
        {
            public Gene(string s)
            {
                if (s.Length != 8)
                    throw new Exception("too big or too small... must be 8 long");
                value = s;
                tail = value.Substring(4);
                head = value.Remove(4, 4);
            }
            string value;
            string tail;
            string head;
            public override string ToString()
            {
                return value;
            }
            public string Head
            {
                get
                {
                    return head;
                }
            }

            public string Tail
            {
                get
                {
                    return tail;
                }
            }
        }

        static void Main(string[] args)
        {
            //Make a Gene, a new one, and flip it.
            Gene g = new Gene("11111111");
            
        }


        //class Whatevs
        //{
        //    
        //    public void Whatever(string m_Represent)
        //    {
        //        m_Represent = "1, 1, 1, 1" "1, 1, 1, 1";

        //        return;
        //    }
        //}




    }
