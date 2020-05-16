using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    public class RodCuttingSolution
    {
        public void RodCuttingDemo()
        {
            int n = 160;
            int a = 11, b = 12, c = 13;
            Console.WriteLine(RodCutting(n, a, b, c));
        }

        private int RodCutting(int n, int a, int b, int c)
        {
            if (n < 0) return -1;
            if (n == 0) return 0;

            int maxA = RodCutting(n - a, a, b, c);
            int maxB = RodCutting(n - a, a, b, c);
            int maxC = RodCutting(n - a, a, b, c);

            int max = 1 + Math.Max(maxA, Math.Max(maxB, maxC));
            //Console.WriteLine($"maxA ={0} maxB ={1} maxC ={2} and finalMax ={max}", maxA, maxB, maxC);

            return max;
        }
    }
}
