using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
    class Program
    {
        static List<int> gradingstudents(List<int> g)

        {
            List<int> grad = new List<int>();
            for (int k = 0; k < g.Count; k++)
                grad.Add(0);
            for (int i = 0; i < g.Count; i++)
                if (g[i] >= 38 && g[i] % 5 > 2)
                    grad[i] = (g[i] - (g[i] % 5))+5;
                else
                    grad[i] = g[i];
            return grad;
                    
        }
        static void Main(string[] args)
        {
             
                }

    }
}
