using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strange_Advertising
{
    class Program
    {
        static int viralAdvertising(int n)
        {
            int people = 5/2;
            int[] p = new int[n];
            p[0] = 5 / 2;
            for (int i = 1; i < n; i++)
            {
                people = (people * 3) / 2;
                p[i] = people;
            }
            int sum = 0;
            for (int k = 0; k < p.Length; k++)
            {
                sum += p[k];
            }    
            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(viralAdvertising(3));
        }
    }
}
