using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recrusive
{
    class FactorialRecrusive
    {
        public double Factorial(int number)
        {
            if (number == 0)
                return 1;

            return number * Factorial(number - 1);
        }
    }
}
