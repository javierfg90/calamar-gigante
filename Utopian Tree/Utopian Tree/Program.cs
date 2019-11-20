using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utopian_Tree
{
    class Program
    {
        static int utopianTree(int n)
        {
            int[] a = new int[n + 1];
            a[0] = 1;
            for (int i = 1; i < a.Length; i++)
            {
                if (i % 2 != 0)
                    a[i] = 2*a[i-1];
                else
                    a[i] = a[i - 1] + 1;

            }
            return a[n];




        }
        static void Main(string[] args)
        {
            Console.WriteLine(utopianTree(5));    
        }
    }
}
