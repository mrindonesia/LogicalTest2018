using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView.Classes
{
    class PrimeNumber
    {
         public static void ShowPrimeNumbers(int n)
        {
            bool isPrime = true;
            if(n >= 2)
            {
                for (int i = 2; i <= n; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }                           
                    }

                    if(isPrime)
                        Console.Write(i + " ");

                    isPrime = true;
                }
            }
        }
    }
}
