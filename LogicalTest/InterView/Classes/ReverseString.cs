using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterView.Classes
{
    class ReverseString
    {
        public string solution(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            string[] wordSplit = S.Split(' ');
            string result = "";
            string tempStr = "";

            for (int i = 0; i < wordSplit.Length; i++)
            {
                tempStr = reverseString(wordSplit[i].ToString());
                if (i != wordSplit.Length - 1)
                    result += tempStr + " ";
                else
                    result += tempStr;
            }
            return result;
        }

        static string reverseString(string str)
        {
            string strOut = "";
            int len = str.Length;
            for (int i = 1; i <= len; i++)
            {
                strOut = strOut + str[len - i];
            }
            return strOut;
        }
    }
}
