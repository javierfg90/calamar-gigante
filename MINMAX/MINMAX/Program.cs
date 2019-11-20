using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MINMAX
{
    class Program
    {
        public static int MinorPos(int[] a, int start)
        {
            int p = start;
            for (int i = start + 1; i < a.Length; i++)
                if (a[i] < a[p])
                    p = i;


            return p;

        }
        public static void Trade<T>(T[] a, int i, int j)
        {
            T temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
        public static void Order(int[] a)
        {
            for (int k = 0; k < a.Length; k++)
                Trade(a, k, MinorPos(a, k));
        }


        // Complete the miniMaxSum function below.
        static void miniMaxSum(int[] arr)
        {

            Order(arr);
            long a0 = Convert.ToInt64(arr[0]);
            long a1 = Convert.ToInt64(arr[1]);
            long a2 = Convert.ToInt64(arr[2]);
            long a3 = Convert.ToInt64(arr[3]);
            long a4 = Convert.ToInt64(arr[4]);
            long sum1 = a0 + a1 + a2 + a3;
            long sum2 = a1 + a2 + a3 + a4;
            Console.WriteLine("{0} {1}",sum1,sum2);




        }
        static void Main(string[] args)
        {
            int[] a = { 256741038, 623958417, 467905213, 714532089, 938071625 };
            miniMaxSum(a);
        }
    }
}
