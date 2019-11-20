using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Digits
{
    class Program
    {

        public static int[] intToArray(int num)
        {
            num = Math.Abs(num);
            int length = num.ToString().Length;
            int[] arr = new int[length];
            do
            {
                arr[--length] = num % 10;
                num /= 10;
            } while (num != 0);

            return arr;
        }
        static int[] digits(int n)
        {
            string s = n.ToString();
            int length = s.Length;
            int[] a = new int[length];
            int i = 0;
            while(n>0)
            {
                a[i] = n % 10;
                n /= 10;
                i++;
            }
            return a;
        }

        static int findDigits(int n)
        {
            int[] a = digits(n);
            int k = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if(a[i]!=0)
                    if (n % a[i] == 0)
                    k += 1;
            }
            return k;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(findDigits(1012));
        }
    }
}
