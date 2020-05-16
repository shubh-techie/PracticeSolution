using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySolutions
{
    public class WaterTrappingSolution
    {
        public static void trappingWaterdemo()
        {
            int[] arr = { 3, 0, 0, 2, 0, 4 };
            //int[] arr = { 8, 8, 2, 4, 5, 5, 1 };
            Console.WriteLine(trappingWaterEfficient(arr, arr.Length));
        }

        public static int trappingWaterEfficient(int[] arr, int n)
        {
            if (arr == null || arr.Length < 2) return 0;

            int water = 0, left = 0, right = arr.Length - 1, lMax = 0, rMax = 0;

            while (left < right)
            {
                if (arr[left] < arr[right])
                {
                    water += Math.Max(lMax, arr[left]) - arr[left];

                    left++;
                }
                else
                {
                    water += Math.Max(rMax, arr[right]) - arr[right];

                    right--;
                }
            }

            return water;
        }
        public static int trappingWater(int[] arr, int n)
        {
            int lmax = 0, rmax = 0, water = 0;

            for (int i = 0; i < n; i++)
            {
                lmax = arr[0];
                for (int j = 0; j <= i; j++)
                {
                    lmax = Math.Max(lmax, arr[i]);
                }
                rmax = arr[i];
                for (int k = i; k < n; k++)
                {
                    rmax = Math.Max(rmax, arr[k]);
                }

                int hold = Math.Min(lmax, rmax);
                if (hold > arr[i])
                {
                    water += hold - arr[i];
                }
            }

            return water;
        }
    }
}
