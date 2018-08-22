using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recrusive
{
    class Recursion
    {
        public void abc(int x)
        {
            Console.Write(x + ", ");

            if(x != 0)
            {
                abc(x - 1);
            }

            Console.Write(x + ", ");
        }
    }
}
