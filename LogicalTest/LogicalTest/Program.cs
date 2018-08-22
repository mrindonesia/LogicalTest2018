using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalTest
{
    class Program
    {
        static int i = 1;
        static void Main(string[] args)
        {
            Print_1_10(1);
            Console.WriteLine();
            Console.Write("call func A and B : ");
            Console.WriteLine();
            A(2);

            Console.ReadKey();
        }

        public static void Print_1_10(int n) 
        {
            Console.Write(n + " ");
            if(n != 10)
            {
               Print_1_10(n + 1); 
            }
            Console.Write(n + " ");
        }

        public static void A(int x)
        {
            if(x > 0)
            {
                Console.Write(x + " ");
                B(x - 1);
            }
            
        }

        public static void B(int x)
        {
            if(x > 0)
            {
                A(x - 1);
                Console.Write(x + " ");
            }
            
        }
    }
}
