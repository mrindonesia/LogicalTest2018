using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView.Classes
{
    class SingleSwap
    {
         public static bool CheckSingleSwap(int[] A)
        {
            int count = 0;

            int[] B = new int[A.Length];
            Array.Copy(A, B, A.Length);
            Array.Sort(B);

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] != B[i])
                {
                    count++;
                }
            }

            if (count > 2)
            {
                return false;
            }
            return true;
        }
    }
}
