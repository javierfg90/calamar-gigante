using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace extra_Long_Factorials
{
    class Program
    {
        static long factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * factorial(n - 1);
        }
        static void extraLongFactorials(int n)
        {
            System.Numerics.BigInteger results =
            new BigInteger(1);

            for (int i = 1; i <= n; i++)
                results *= i;

            Console.WriteLine(results);


        }


        static void Main(string[] args)
        {
            Console.WriteLine(factorial(100));
        }
    }
}
