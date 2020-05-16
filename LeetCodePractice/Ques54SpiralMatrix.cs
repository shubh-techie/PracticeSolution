using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques54SpiralMatrix
    {
        public static void SpiralOrder()
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };
            IList<int> output = SpiralOrder(matrix);

            foreach (var item in output)
            {
                Console.WriteLine(item);
            }



        }
        public static IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();
            if (matrix.Length == 0)
            {
                return result;
            }

            int leftBound = 0;
            int rightBound = matrix[0].Length - 1;
            int bottomBound = matrix.Length - 1;
            int upperBound = 0;

            while (leftBound <= rightBound && upperBound <= bottomBound)
            {
                for (int col = leftBound; col <= rightBound; col++)
                {
                    result.Add(matrix[upperBound][col]);
                }
                upperBound++;

                for (int row = upperBound; row <= bottomBound; row++)
                {
                    result.Add(matrix[row][rightBound]);
                }
                rightBound--;

                for (int col = rightBound; upperBound <= bottomBound && col >= leftBound; col--)
                {
                    result.Add(matrix[bottomBound][col]);
                }
                bottomBound--;

                for (int row = bottomBound; leftBound <= rightBound && row >= upperBound; row--)
                {
                    result.Add(matrix[row][leftBound]);
                }
                leftBound++;
            }

            return result;
        }
    }
}
