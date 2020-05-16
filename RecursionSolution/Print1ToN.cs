using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionSolution
{
    public class Print1ToN
    {
        public static void PrintOneToNDemo(int n)
        {
            Helper(n, 1);
        }

        private static void Helper(int n, int start)
        {
            if (start == n + 1) return;
            Console.Write(start + " ");
            Helper(n, start + 1);
        }

        public static int sumOfDigits(int n)
        {
            if (n == 0)
                return 0;
            return sumOfDigits(n / 10) + n % 10;
        }

        public static int countDigits(int n)
        {
            if (n < 10) return 1;
            return countDigits(n / 10);

        }

        int digitalRoot(int n)
        {
            if (n == 0) return 0;
            int totalSum = digitalRoot(n / 10) + n / 10;
            
                return 0;
        }

    }
}
