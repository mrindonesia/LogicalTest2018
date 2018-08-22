using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recrusive
{
    class Fun
    {
        public void FunMethod(int x, int y)
        {
            if (x > 40)
            {
                return;
            }                

            x += y;

            FunMethod(x, y);

            Console.Write(x + ", ");
        }
    }
}
