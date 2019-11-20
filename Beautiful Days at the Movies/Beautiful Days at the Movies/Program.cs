using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Days_at_the_Movies
{
    class Program
    {
        static int reverse(int a)
        {
            int rev = 0;
            int rem = 0;
            while (a != 0)
            {
                rem = a % 10;
                rev = rev*10 + rem;
                a /= 10;
            }
            return rev;
        }
        static int[] daysbetween(int i,int j)
        {
            int[] a = new int[j - i + 1];
            for (int m = 0; m < a.Length; m++)
                a[m] = i + m;
            return a;
        }
        static int beautifulDays(int i, int j, int k)
        {
            int[] d = daysbetween(i, j);
            int bd = 0;
            for (int m = 0; m < d.Length; m++)
                if ((Math.Abs(d[m] - reverse(d[m]))) % k == 0)
                    bd += 1;
            return bd;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(beautifulDays(20,23,6));
        }
    }
}
