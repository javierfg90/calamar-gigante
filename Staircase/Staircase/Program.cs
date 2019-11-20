using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staircase
{
    class Program
    {
        static void Staircase(int n)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(new string('#', i + 1).PadLeft(n,' '));
        }
        static void Main(string[] args)
        {
            Staircase(4);
        }
    }
}
