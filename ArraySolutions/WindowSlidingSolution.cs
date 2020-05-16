using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class WindowSlidingSolution
    {
        public static void WindowSlidingDemo()
        {
            //int[] arr = { 1, 8, 30, -5, 20, 7 };
            //int result = WindowSlidingDemoBF(arr, 3);
            //int result = WindowSlidingDemolinear(arr, 3);
            //int[] arr = { 1, 4, 20, 3, 10, 5 };
            //bool result = WindowSlidingDemolinearGivenSum(arr, 33);
            //Console.WriteLine(result);

            Console.WriteLine(MyAtoi("    -42"));
        }

        public static int MyAtoi(string str)
        {
            str = str.Trim();
            if (str == null || str.Length == 0) return 0;

            long result = 0;
            int indicator = 1;
            int i = 0;

            if (str[0] == '-')
                indicator = 1;
            if (str[0] == '-')
                indicator = 1;

            while (i < str.Length && char.IsDigit(str[i]))
            {
                result = result * 10 + (str[i++] - '0');
                if (result * indicator >= int.MaxValue) return int.MaxValue;
                if (result * indicator <= int.MinValue) return int.MinValue;
            }

            return (int)result * indicator;

        }

        private static bool WindowSlidingDemolinearGivenSum(int[] arr, int sum)
        {
            int start = 0, end = 0, cSum = 0, size = arr.Length;

            for (end = 0; end < size; end++)
            {
                while (cSum > sum && start < end - 1)
                {
                    cSum = cSum - arr[start];
                    start++;
                }
                if (cSum == sum) return true;
                if (end < size)
                    cSum += arr[end];
                Console.WriteLine("cSum :{0}", cSum);

            }

            return cSum == sum ? true : false;
        }

        private static int WindowSlidingDemolinear(int[] arr, int windowSize)
        {
            int uMax = 0, size = arr.Length, wMax = 0;

            int index = 0;
            while (index < windowSize)
            {
                wMax += arr[index];
                index++;
            }

            uMax = wMax;

            for (int i = windowSize; i < size; i++)
            {
                wMax = wMax + arr[i] - arr[i - windowSize];
                uMax = Math.Max(uMax, wMax);
            }

            return uMax;
        }

        private static int WindowSlidingDemoBF(int[] arr, int windowSize)
        {
            int uMax = 0, size = arr.Length, cMax = 0;

            for (int i = 0; i + windowSize - 1 < size; i++)
            {
                cMax = 0;
                for (int j = 0; j < windowSize; j++)
                {
                    cMax += arr[i + j];
                    Console.Write(arr[i + j] + " ");
                }
                uMax = Math.Max(uMax, cMax);
                Console.WriteLine();
                Console.WriteLine();
            }
            return uMax;
        }
    }
}
