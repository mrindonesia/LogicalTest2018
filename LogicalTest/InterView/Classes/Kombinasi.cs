﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView.Classes
{
    class Kombinasi
    {
        public static int kombinasi(int n, int r)
        {
            if (n < 1)
                return 0;
            else
                return (Factorial(n) / (Factorial(r) * Factorial(n - r)));
        }

        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}
