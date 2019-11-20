using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SockMerchant
{
    class Solution
    {
        private static int MinorPos(int[] a, int start)
        {
            int p = start;
            for (int i = start + 1; i < a.Length; i++)
                if (a[i] < a[p])
                    p = i;
            return p;

        }
        public static void Trade(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
        public static void Order(int[] a)
        {
            for (int k = 0; k < a.Length; k++)
                Trade(a, k, MinorPos(a, k));
        }

        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            Order(ar);
            int cnt = 0;
            for (int i = 0; i < n - 1; i++)
                if (ar[i] == ar[i + 1])
                {
                    cnt += 1;
                    i = i + 1;
                }

            return cnt;



        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}