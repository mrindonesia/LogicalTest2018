using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView.Classes
{
    class Fibonachi
    {
        public static void NotfiboRecrusive(int n)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.Write(a + " ");
                a = a + b;
                b = a - b;
            }
        }
    }
}
