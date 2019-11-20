using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_array_rotation
{
    class Program
    {
        static int[] Rot(int[] a)
        {
            int[] b = new int[a.Length];
            b[0] = a[a.Length - 1];
            for (int i = 1; i < a.Length; i++)
                b[i] = a[i - 1];
            return b;
        }
        static int[] kRot(int[] a,int k)
        {
            int[] d = a;
            for (int i = 0; i < k; i++)
                d = Rot(d);
            return d;


        }
        static int[] circularArrayRotation(int[] a, int k, int[] queries)
        {
            int[] r = kRot(a, k);
            int[] p = new int[a.Length];
            for (int i = 0; i < queries.Length; i++)
                p[i] = r[queries[i]];
            return p;

        }


        static void Main(string[] args)
        {
            int[] p = { 1, 2, 3};
            int[] r = { 0, 1, 2 };
            int[] s = circularArrayRotation(p, 2, r);
            for (int k = 0; k < s.Length; k++)
                Console.WriteLine(s[k]);
            
        }
    }
}
