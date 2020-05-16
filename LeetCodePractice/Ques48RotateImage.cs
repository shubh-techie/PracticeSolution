using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques48RotateImage
    {
        public static void Rotate()
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 3 };
            matrix[1] = new int[] { 4, 5, 6 };
            matrix[2] = new int[] { 7, 8, 9 };

            PrintArray(matrix);
            Console.WriteLine("Befor update:");
            Rotate(matrix);


            Console.WriteLine("After update:");
            PrintArray(matrix);
        }

        public static void PrintArray(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }
        public static void Rotate(int[][] matrix)
        {
            int n = matrix.Length;


            // transpose matrix
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.WriteLine("Swapping {0} {1}", matrix[j][i], matrix[i][j]);
                    int tmp = matrix[j][i];
                    matrix[j][i] = matrix[i][j];
                    matrix[i][j] = tmp;
                }
            }

            Console.WriteLine("Transpose matrix");
            PrintArray(matrix);

            // reverse each row
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n / 2; j++)
                {
                    Console.WriteLine("Swapping {0} {1}", matrix[i][j], matrix[i][n - j - 1]);
                    int tmp = matrix[i][j];
                    matrix[i][j] = matrix[i][n - j - 1];
                    matrix[i][n - j - 1] = tmp;
                }
            }

        }
    }
}
