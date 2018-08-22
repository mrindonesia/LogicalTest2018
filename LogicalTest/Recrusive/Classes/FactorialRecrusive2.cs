using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recrusive
{
    class FactorialRecrusive2
    {
        public double factorial(int n)
        {
            if (n != 0)
            {
                if (n == 1)
                    Console.Write(n + " = ");
                else
                    Console.Write(n + " * ");
            }

            if (n == 0)
                return 1;

            return n * factorial(n - 1);

        }
    }
}
