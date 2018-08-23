using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView.Classes
{
    class FiboRecrusive
    {
         public static int fiboRecrusive(int n)
        {
            if(n == 0)
                return 0;
            if (n == 1)
                return 1;
            return fiboRecrusive(n - 1) + fiboRecrusive(n - 2);
        }
    }
}
