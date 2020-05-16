using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    public class SumOfTwoNumberPractice
    {
        public static void TruckPackage()
        {
            int[] packages = { 20, 50, 40, 25, 30, 10 };
            int sum = 60;
            int[] result = getTheBestTruckPackage(packages, sum);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static int[] getTheBestTruckPackage(int[] packages, int sum)
        {
            int[] result = new int[2] { -1, -1 };
            if (packages == null && packages.Length < 1) return result;
            Dictionary<int, int> trackLoading = new Dictionary<int, int>();

            for (int i = 0; i < packages.Length; i++)
            {
                int oPair = sum - packages[i];
                if (trackLoading.ContainsKey(oPair))
                {
                    if (Math.Max(packages[i], packages[trackLoading[oPair]]) > Math.Max(result[0], result[0]))
                    {
                        result[0] = trackLoading[oPair];
                        result[1] = i;
                    }
                }
                {
                    trackLoading.Add(packages[i], i);
                }
            }

            return result;
        }

        public static int makeAnagram(string a, string b)
        {
            int[] forA = new int[256];

            foreach (char item in a)
            {
                forA[item]++;
            }
            printAArray(forA, 0);

            for (int index = 0; index < b.Length; index++)
            {
                if (b[index] == index)
                    forA[b[index]]--;
                else
                    forA[b[index]]++;
            }
            Console.WriteLine("After minus");
            printAArray(forA, 0);
            int odds = 0;
            for (int i = 0; i < 256; i++)
            {
                odds = odds + forA[i];
            }

            return Math.Abs(odds);
        }

        private static void printAArray(int[] forA, int index)
        {
            if (index > forA.Length-1) return;
            if (forA[index] != 0)
                Console.WriteLine(forA[index] + " ,");
            printAArray(forA, index+1);
        }
    }
}
