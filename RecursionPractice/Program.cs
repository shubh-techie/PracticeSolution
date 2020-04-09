using System;

namespace RecursionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintingArray();
            //ReverseString();
            //ConvertSingleToDouble();
            //Convert2DArrayToSingle();
            //MergetTwoSortedArray();

            //int m = 3, n = 2;
            //long[,] cache = new long[m, n];
            //for (int i = 0; i < m; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        cache[i, j] = 0;
            //    }
            //}
            //Console.WriteLine(latticePaths(m, n));

            //miniMaxSum(new int[] { 1, 2, 3, 4, 5 });


            //DateTime track = new DateTime();


            LatticePathDemo.compute();

            Console.WriteLine("Please press <enter> to exit");
            Console.Read();
        }

        static void miniMaxSum(int[] arr)
        {
            long[] result = new long[2];
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                long temp = sum;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i - j != 0)
                        sum += arr[j];
                }
                if (sum >= temp)
                {
                    result[0] = temp;
                    result[1] = sum;
                }
                else
                {
                    result[0] = sum;
                    result[1] = temp;
                }
            }

            Console.WriteLine(string.Format("{0} {1}", arr[0], arr[1]));
        }

        public static int latticePaths(int m, int n)
        {
            int larger = Math.Max(m, n);
            int smaller = Math.Min(m, n);

            int[] work = new int[larger + 1];
            work[0] = 1;

            for (int i = 1; i < larger + 1; i++)
            {
                int temp = 1;
                for (int j = 1; j < i + 1; j++)
                {
                    temp = temp + work[j];
                    work[j] = temp;
                }
                work[i] = 2 * temp;
            }

            return work[smaller];
        }

        static long count_routes(long[,] cache, int x, int y)
        {
            if (cache[x, y] != 0)
            {
                return cache[x, y];
            }
            long n = 0;
            if (x == 0 && y == 0)
            {
                n = 1;
            }
            else
            {
                n = 0;
                if (x > 0)
                {
                    n += count_routes(cache, x - 1, y);
                }
                if (y > 0)
                {
                    n += count_routes(cache, x, y - 1);
                }
            }
            cache[x, y] = n;
            return n;
        }


        private static void MergetTwoSortedArray()
        {
            int[] nums1 = { 1, 4, 7 };
            int[] nums2 = { 2, 3, 6, 9 };
            int resultLengh = nums1.Length + nums2.Length;
            int[] result = new int[resultLengh];
            MergetTwoSortedArrayHelper(result, nums1, nums2, 0, 0);
            PrintingArrayHelper(result, 0, result.Length - 1);
        }

        private static void MergetTwoSortedArrayHelper(int[] result, int[] nums1, int[] nums2, int i, int j)
        {
            if (i + j >= result.Length) return;


            if (i < nums1.Length && nums1[i] < nums2[j])
            {
                result[i + j] = nums1[i];
                i++;
            }
            else if (j < nums2.Length)
            {
                result[i + j] = nums2[j];
                j++;
            }
            MergetTwoSortedArrayHelper(result, nums1, nums2, i, j);
        }

        private static void Convert2DArrayToSingle()
        {
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[] result = new int[matrix.GetLength(0) * matrix.GetLength(1)];

            getFromHelper(matrix, 0, 0, result);
            PrintingArrayHelper(result, 0, result.Length - 1);
        }

        private static void getFromHelper(int[,] matrix, int row, int index, int[] result)
        {
            if (row > matrix.GetLength(0) - 1) return;

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[index] = matrix[row, j];
                index++;
            }

            getFromHelper(matrix, row + 1, index, result);
        }

        private static void ConvertSingleToDouble()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            int[,] results = ConvertSingleToDoubleDimenstion(nums);

            for (int i = 0; i < results.GetLength(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(string.Format("{0}", results[i, j]));
                }
                Console.Write("}");
            }
        }

        private static int[,] ConvertSingleToDoubleDimenstion(int[] nums)
        {
            int rows = 0;
            if (nums.Length % 2 == 0)
                rows = nums.Length / 2;
            else
                rows = nums.Length / 2 + 1;
            int[,] results = new int[rows, 2];
            ConvertHelper(nums, 0, results);
            return results;
        }

        private static void ConvertHelper(int[] arr, int index, int[,] results)
        {
            if (index >= arr.Length) return;

            results[index / 2, 0] = arr[index];
            if (index + 1 <= arr.Length - 1)
                results[index / 2, 1] = arr[index + 1];
            else
                results[index / 2, 1] = -1;

            ConvertHelper(arr, index + 2, results);
        }

        private static void ReverseString()
        {
            Console.WriteLine(ReverseStringHelper("Hello World Testing", ""));
        }

        private static string ReverseStringHelper(string inputString, string output)
        {
            if (string.IsNullOrEmpty(inputString)) return output;

            output = inputString[0] + output;
            return ReverseStringHelper(inputString.Substring(1), output);
        }

        private static void PrintingArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            PrintingArrayHelper(arr, 0, arr.Length - 1);
        }

        private static void PrintingArrayHelper(int[] arr, int index, int length)
        {
            if (index > length) return;
            Console.WriteLine(arr[index] + " ");
            PrintingArrayHelper(arr, index + 1, length);
        }
    }
}
