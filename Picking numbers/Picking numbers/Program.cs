using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Picking_numbers
{
    class Program
    {
        private static int MinorPos(List<int> a, int start)
        {
            int p = start;
            for (int i = start + 1; i < a.Count; i++)
                if (a[i] < a[p])
                    p = i;
            return p;

        }
        public static void Trade(List<int> a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
        public static void Order(List<int> a)
        {
            for (int k = 0; k < a.Count; k++)
                Trade(a, k, MinorPos(a, k));
        }
        public static int Max(List<int> m)
        {
            int max = m[0];
            for (int k = 0; k < m.Count; k++)
                if (m[k] > max)
                    max = m[k];
            return max;
        }
        public static int Picknum(List<int> a)
        {
            Order(a);
            List<int> nums = new List<int>();
            for (int k = 0; k < a.Count; k++)
                nums.Add(0);
            for (int i = 0; i < a.Count; i++)
                for (int j = i+1; j < a.Count; j++)
                    if ((Math.Abs(a[i] - a[j])) <= 1)
                        nums[i]+=1;
            for (int h = 0; h < a.Count; h++)
                Console.WriteLine(a[h]);
            for (int k = 0; k < a.Count; k++)
                Console.WriteLine(nums[k]);
            return Max(nums)+1;
            
        }
        static void Main(string[] args)
        {
            List<int> f = new List<int>() {4,5,6,2,3,89,1 };
            Console.WriteLine(Picknum(f));
        }
    }
}
