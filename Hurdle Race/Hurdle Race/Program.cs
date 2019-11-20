using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hurdle_Race
{
    class Program
    {
        public static int Max(int[] a)
        {
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
                if (a[i] > max)
                    max = a[i];
            return max;

        }
        public static int HR(int n,int k, int[] h)
        {
            int m = Max(h);
            if (m > k)
                return m - k;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            int[] b = { 2, 5, 4, 5, 2 };
            Console.WriteLine(HR(5, 7,b));
        }
    }
}
