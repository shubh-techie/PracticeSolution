using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    class Bubblesort
    {
        public static void Bubblesorting(int[] data)
        {
            int length = data.Length;

            bool isSorted = true;

            for (int i = 0; i < length; i++)
            {
                isSorted = true;
                for (int j = 0; j < length; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        Swapping(data, j, j + 1);
                        isSorted = false;
                    }
                }

                if (isSorted)
                    break;
            }
        }

        public static void Swapping(int[] data, int toIndex, int fromIndex)
        {
            int temp = data[toIndex];
            data[toIndex] = data[fromIndex];
            data[fromIndex] = temp;
        }

        public void DisplayArrary(int[] data)
        {
            foreach (var item in data)
            {
                Console.Write(item + "");
            }
            Console.WriteLine();
        }
    }
}
