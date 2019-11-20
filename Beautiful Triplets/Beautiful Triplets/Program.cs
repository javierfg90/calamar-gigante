using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautiful_Triplets
{
    class Program
    {
        static int beautifulTriplets(int d, int[] arr)
        {
            int b = 0;
            for (int i = 0; i < arr.Length - 2; i++)
                for (int j = i + 1; j < arr.Length - 1; j++)
                    if (arr[j] - arr[i] == d)
                        for (int k = j + 1; k < arr.Length; k++)
                            if (arr[k] - arr[j] == d)
                                b += 1;
            return b;



        }

        static void Main(string[] args)
        {
            int[] d = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(beautifulTriplets(2,d));
        }
    }
}
