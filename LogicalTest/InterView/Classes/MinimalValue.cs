using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView.Classes
{
    class MinimalValue
    {
        public static int GetMinimalValueBothArray(int[] A, int[] B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            // Time: O(nlogn)
            // Space: O(1)
            Array.Sort(A);
            Array.Sort(B);

            int i = 0;
            int j = 0;

            while (i < A.Length && j < B.Length)
            {
                if (A[i] == B[j])
                {
                    return A[i];
                }
                else if (A[i] < B[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return -1;
        }
    }
}
