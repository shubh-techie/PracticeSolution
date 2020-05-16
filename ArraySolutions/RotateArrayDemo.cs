using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class RotateArrayDemo
    {
        public static void rotateDemo()
        {
            int[] Arr = { 1, 2, 3, 4, 5 };
            rotateArr(Arr, 2, Arr.Length);

            Console.WriteLine(string.Join(",", Arr));
        }
        public static void rotateArr(int[] arr, int d, int n)
        {
            // add your code here
            if (d < n)
            {
                reverse(arr, 0, d - 1);
                Console.WriteLine(string.Join(",", arr));

                reverse(arr, d, n - 1);
                Console.WriteLine(string.Join(",", arr));

                reverse(arr, 0, n - 1);
                Console.WriteLine(string.Join(",", arr));

            }
        }
        public static void reverse(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int temp = arr[l];
                arr[l] = arr[r];
                arr[r] = temp;
                l++;
                r--;
            }
        }
    }
}
