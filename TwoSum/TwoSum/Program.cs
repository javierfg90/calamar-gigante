using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        public static int[] TwoSum(int[] a, int target)
        {
            for (int k = 0; k < a.Length; k++)
            {
                for (int l = k + 1; l < a.Length; l++)
                {
                    if (a[k] + a[l] == target)
                    {
                        return new int[] { k, l };
                    }
                }
            }
            throw new Exception("No two sum solution");
        }
                    
        static void Main(string[] args)
        {
            int[] a = { 2, 3, 5, 7, 11, 29, 31, 47, 79, 19, 17, 67,43,83 };
            Console.WriteLine(TwoSum(a, 100));
        }
    }
}
