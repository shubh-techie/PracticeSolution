using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreedyAlgorithm
{
    public class FabonacciSeries
    {
        public static void getFabonacciSerices()
        {
            int no = 6;

            long[] memo = new long[no + 1];
            for (int i = 0; i < memo.Length; i++)
            {
                memo[i] = -1;
            }




            DateTime startTime = DateTime.Now;
            Console.WriteLine("Bottom up  :" + getBottom(no));
            Console.WriteLine("Time Bottom up: {0}", DateTime.Now - startTime);


            startTime = DateTime.Now;
            Console.WriteLine("Top Down :" + geTopDownFab(no, memo));
            Console.WriteLine("Time Top Down: {0}", DateTime.Now - startTime);

            startTime = DateTime.Now;
            Console.WriteLine("Recursion :" + geFab(no));
            Console.WriteLine("Time recursion: {0}", DateTime.Now - startTime);


        }

        static long geFab(int no)
        {
            if (no <= 1)
                return no;
            long fab = geFab(no - 1) + geFab(no - 2);
            Console.WriteLine(fab);
            return fab;
        }

        static long getBottom(int no)
        {
            long[] fab = new long[no + 1];
            fab[0] = 0;
            fab[1] = 1;

            for (int i = 2; i <= no; i++)
            {
                fab[i] = fab[i - 1] + fab[i - 2];
            }

            return fab[no];
        }


        static long geTopDownFab(int no, long[] memo)
        {
            if (no <= 1)
                memo[no] = no;
            else if (memo[no] == -1)
            {
                memo[no] = geTopDownFab(no - 1, memo) + geTopDownFab(no - 2, memo);
            }
            return memo[no];
        }
    }
}
