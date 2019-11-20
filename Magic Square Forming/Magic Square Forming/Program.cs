using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic_Square_Forming2
{
    class Program
    {
        public static int[] rest(int[] a,int[] b)
        {
            int[] r = new int[3];
            for (int i = 0; i < 3; i++)
                r[i] = Math.Abs(a[i] - b[i]);
            return r;
        }
        public static int[][] Matrixsubs(int[][] a, int[][] b)
        {
            
            int[][] sum = new int[3][];

            for (int i = 0; i < 3; i++)
                sum[i] = rest(a[i], b[i]);


            return sum;

        }
        public static int Matrixpow(int[][] a)
        {
            int pow = 0;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    pow += a[i][j];
            return pow;
        }
        public static int formingMagicSquare(int[][] s)

        {
            int[][] a1 = new int[3][];
            a1[0] = new int[] { 4, 3, 8};
            a1[1] = new int[] { 9,5,1 };
            a1[2] = new int[] { 2,7, 6 };
            int[][] a2 = new int[3][];
            a2[0] = new int[] { 8, 1, 6 };
            a2[1] = new int[] { 3, 5, 7 };
            a2[2] = new int[] { 4, 9, 2 };
            int[][] a3 = new int[3][];
            a3[0] = new int[] { 6, 1, 8 };
            a3[1] = new int[] { 7, 5, 3 };
            a3[2] = new int[] { 2, 9, 4 };
            int[][] a4 = new int[3][];
            a4[0] = new int[] { 4, 9, 2 };
            a4[1] = new int[] { 3, 5, 7 };
            a4[2] = new int[] { 8, 1, 6 };
            int[][] a5 = new int[3][];
            a5[0] = new int[] { 2, 9, 4 };
            a5[1] = new int[] { 7, 5, 3 };
            a5[2] = new int[] { 6, 1, 8 };
            int[][] a6 = new int[3][];
            a6[0] = new int[] { 8, 3, 4 };
            a6[1] = new int[] { 1, 5, 9 };
            a6[2] = new int[] { 6, 7, 2 };
            int[][] a7 = new int[3][];
            a7[0] = new int[] { 2, 7, 6 };
            a7[1] = new int[] { 9, 5, 1 };
            a7[2] = new int[] { 4, 3, 8 };
            int[][] a8 = new int[3][];
            a8[0] = new int[] { 6, 7, 2 };
            a8[1] = new int[] { 1, 5, 9 };
            a8[2] = new int[] { 8, 3, 4 };
            int[][] d1 = Matrixsubs(s, a1);
            int[][] d2 = Matrixsubs(s, a2);
            int[][] d3 = Matrixsubs(s, a3);
            int[][] d4 = Matrixsubs(s, a4);
            int[][] d5 = Matrixsubs(s, a5);
            int[][] d6 = Matrixsubs(s, a6);
            int[][] d7 = Matrixsubs(s, a7);
            int[][] d8 = Matrixsubs(s, a8);
            int[] dif = { Matrixpow(d1), Matrixpow(d2), Matrixpow(d3), Matrixpow(d4), Matrixpow(d5), Matrixpow(d6), Matrixpow(d7), Matrixpow(d8) };
            int cost = dif[0];
            for (int i = 0; i < 8; i++)
                if (dif[i] < cost)
                        cost = dif[i];
            return cost;
        }
        public static void Main(string[] args)
        {
            int[][] f1 = new int[3][];
            f1[0] = new int[] { 4, 4, 7 };
            f1[1] = new int[] { 3, 1, 5 };
            f1[2] = new int[] { 1, 7, 9 };
            int[][] f2 = new int[3][];
            f2[0] = new int[] { 8, 1, 6 };
            f2[1] = new int[] { 3, 5, 7 };
            f2[2] = new int[] { 4, 9, 2 };
            Console.WriteLine(formingMagicSquare(f1));


        }












    }
        
    
}
