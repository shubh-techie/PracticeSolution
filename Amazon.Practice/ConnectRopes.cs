using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    class ConnectRopes
    {

        public static void mergeFiles()
        {
            int[] files1 = { 8, 4, 6, 12 };
            int[] files2 = { 20, 4, 8, 2 };
            int[] files3 = { 1, 2, 5, 10, 35, 89 };
            int[] files4 = { 2, 2, 3, 3 };
            Console.WriteLine(MinCost_BF(files1));
            Console.WriteLine(MinCost_BF(files2));
            Console.WriteLine(MinCost_BF(files3));
            Console.WriteLine(MinCost_BF(files4));
        }

        private static int mergeFiles(int[] files)
        {
            Queue<int> minHeap = new Queue<int>();

            foreach (var f in files)
            {
                minHeap.Enqueue(f);
            }

            int res = 0;
            while (minHeap.Count > 1)
            {
                int f1 = minHeap.Dequeue();
                int f2 = minHeap.Dequeue();
                int tmp = f1 + f2;
                res += tmp;
                minHeap.Enqueue(tmp);
            }

            return res;
        }

        public static int MinCost_BF(int[] ropes)
        {
            int minCost = 0;
            List<int> ropesCollection = new List<int>(ropes);
            ropesCollection.Sort();

            while (ropesCollection.Count > 1)
            {
                int currminCost = ropesCollection[0] + ropesCollection[1];
                ropesCollection.RemoveRange(0, 2);
                ropesCollection.Add(currminCost);
                ropesCollection.Sort();
                minCost += currminCost;
            }

            return minCost;
        }

    }
}
