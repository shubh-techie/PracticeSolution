using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicProgramming
{
    class MaxOfConsecutiveSum
    {
        public static void BitFlip()
        {
            int[] arr = { 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1 };
            int[] arr2 = { 1, 0, 0, 1, 1, 0, 1, 0, 1, 1, 1 };
            int[] arr3 = { 0, 0, 0, 1 };
            //BitFlipHelper(arr3, 4);
            flip("0011101");
        }

        public static List<int> flip(string arr)
        {
            List<int> output = new List<int>();
            output.Add(0);
            output.Add(0);
            int max = 0, length = arr.Length; 
            int diff = 0;
            int i = 0;
            int start = 0;
            bool solFound = false;
            for (i = 0; i < length; i++)
            {
                string c = arr[i].ToString();
                diff += (c == "0") ? 1 : -1;
                if (diff < 0)
                {
                    diff = 0;
                    start = (c == "0") ? i : i + 1;
                }
                else
                {
                    if (max < diff)
                    {
                        max = diff;
                        output[0]=start;
                        output[0]=i;
                        solFound = true;
                    }
                }
            }

            if (!solFound)
            {
                return output;
            }

            output[0] += 1;
            output[1] += 1;
            return output;
        }
        public static void BitFlipHelper(int[] arr, int m)
        {
            int max = 0, startIndex = 0, steak = 0, length = arr.Length;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] == 0)
                {
                    if (m > 0)
                    {
                        m--;
                    }
                    else
                    {
                        int substrctNumber = 1;
                        while (arr[startIndex] == 1)
                        {
                            startIndex++;
                            substrctNumber++;
                        }
                        startIndex++;
                        steak = steak - substrctNumber;
                    }
                }

                steak++;
                max = Math.Max(max, steak);
            }

            Console.WriteLine("max    :" + max);

            if (m < length)
            {
                for (int i = startIndex; i < length; i++)
                {
                    if (arr[i] == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                Console.WriteLine("Need to flip all the 0");
            }
        }
        public static void maxConsecutiveSum()
        {
            int[] arr = { 6, -1, 3, 5, -10 };
            Console.WriteLine(FindMaxConsecutiveSum(arr, arr.Length));
        }
        public static int FindMaxConsecutiveSum(int[] arr, int length)
        {
            if (length == 0) return 0;

            int localMax = 0;
            int ultimateMax = arr[0];

            for (int i = 0; i < length; i++)
            {
                localMax = Math.Max(arr[i], arr[i] + localMax);
                ultimateMax = Math.Max(localMax, ultimateMax);
            }

            return ultimateMax;
        }

    }
}
