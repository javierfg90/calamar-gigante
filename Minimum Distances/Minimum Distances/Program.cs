using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Distances
{
    class Program
    {
        public static int Min(int[] b)
        {
            int min = b[0];
            for (int i = 0; i < b.Length; i++)
                if (b[i] < min)
                    min = b[i];
            return min;
        }

        // Complete the minimumDistances function below.
        static int minimumDistances(int[] a)
        {
            int[] m = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                m[i] = a.Length;
            for (int k = 0; k < a.Length; k++)
                 for (int j = k + 1; j < a.Length; j++)
                    if (a[k] - a[j] == 0)
                    m[k] = j - k;
            if (Min(m) < a.Length)
                return Min(m);
            else
                return -1;
            
                

            
        }
            static void Main(string[] args)
        {
            int[] g = { 1, 2, 4, 3, 8, 5, 6, 10, 12 };
            Console.WriteLine(minimumDistances(g));
        }
    }
}
