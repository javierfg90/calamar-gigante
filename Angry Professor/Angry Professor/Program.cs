using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angry_Professor
{
    class Program
    {
        static string angryProfessor(int k, int[] a)
        {
            int ontime = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] <= 0)
                    ontime += 1;
            if (ontime >= k)
                return "NO";
            else
                return "YES";
        }
        static void Main(string[] args)
        {
            int[] b = { 0, -1, 2, 1 };
            Console.WriteLine(angryProfessor(2, b));
        }
    }
}
