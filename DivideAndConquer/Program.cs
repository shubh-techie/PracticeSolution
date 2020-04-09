using System;

namespace DivideAndConquer
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 3, 5, 5, 7, 9, 10, 11 };
            int value = 6;
            int result = closestValue(arr, value);
            Console.WriteLine(string.Format("{0}", result));
            Console.WriteLine("Press <enter> to exit.");
            Console.ReadLine();
        }


        public static int closestValue(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1, mid = 0, closedSet = int.MaxValue, difference = 0;
            if (right == 0) throw new Exception("please enter a valid sorted array.");
            int value = arr[left + (right - left) / 2];
            while (left < right)
            {
                mid = left + (right - left) / 2;
                difference = Math.Abs(target - arr[mid]);
                if (difference < closedSet)
                {
                    closedSet = difference;
                    value = arr[mid];
                }

                if (target < arr[mid])
                    right = mid - 1;
                else
                    left = mid + 1;

            }

            // YOUR WORK HERE
            return value;
        }
    }
}
