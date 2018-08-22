using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recrusive
{
    class Program
    {
        static void Main(string[] args)
        {
            FaktorialWithoutRecrusive objFaktorialWithoutRecrusive = new FaktorialWithoutRecrusive();
            Console.WriteLine("Please enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} faktorial is {1}", number, objFaktorialWithoutRecrusive.Factorial(number));

            FactorialRecrusive objFactorialRecrusive = new FactorialRecrusive();
            number = 6;
            Console.WriteLine("{0} faktorial is {1}", number, objFactorialRecrusive.Factorial(number));

            /*FindFilesRecrusive objFindFilesRecrusive = new FindFilesRecrusive();
            Console.WriteLine("Please enter path : ");
            string path = Console.ReadLine();
            objFindFilesRecrusive.FindFiles(path);*/

            Fun objFun = new Fun();
            int x = 10;
            objFun.FunMethod(x, x++);
            Console.Write(x);
            Console.WriteLine();

            Recursion objRecursion = new Recursion();
            objRecursion.abc(4);

            Console.ReadKey();
        }
    }
}
