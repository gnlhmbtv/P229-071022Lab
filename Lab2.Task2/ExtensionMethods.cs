using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Task2
{
    static class ExtensionMethods
    {

        public static bool isEven(int a) => a % 2 == 0;

        public static int[] GetValueIndexes(int[] arr, int num)
        {
            int[] ans = { };

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    Array.Resize(ref ans, ans.Length + 1);
                    ans[ans.Length - 1] = i;
                }
            }

            return ans;
        }

        public static bool isOdd(int a) => a % 2 == 1;

        public static bool IsContainsDigit(string str)
        {
            
            bool check = false;
            foreach (char item in str)
            {
                if (char.IsDigit(item))
                {
                    check = true;
                }
            }

            return check;
        }

        public static int[] GetValueIndexes(string str, char symbol)
        {
            int[] ans = { };

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == symbol)
                {
                    Array.Resize(ref ans, ans.Length + 1);
                    ans[ans.Length - 1] = i;
                }
            }

            return ans;
        }
    }

    




}
