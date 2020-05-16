
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionSolution
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(foo(513, 2));
            //Console.WriteLine(Print1ToN.countDigits(361));


            //Console.WriteLine(Print1ToN.sumOfDigits(9999));
            //Print1ToN.PrintOneToNDemo(64);
            Console.WriteLine("Press <enter> to exit");
            Console.ReadLine();
        }

        static UInt32 foo(UInt32 n, UInt32 r)
        {
            if (n > 0) return (n % r + foo(n / r, r));
            else return 0;
        }

        public static int f(int n)
        {
            if (n <= 1)
                return 1;
            if (n % 2 == 0)
                return f(n / 2);
            return f(n / 2) + f(n / 2 + 1);
        }
    }
}
