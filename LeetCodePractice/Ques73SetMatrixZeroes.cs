using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class Ques73SetMatrixZeroes
    {
        public static void SetZeroes()
        {
            int[,] matrix = { { 1, 1, 0 }, { 1, 1, 1 }, { 1, 1, 1 } };
            //int[,] matrix = { { 0,1,2,0 }, { 3, 4, 5, 2 }, { 1, 3, 1, 5 } };
            Console.WriteLine("Before modification");

            PrintArray(matrix);
            SetZeroes(matrix);

            Console.WriteLine("After modificaiton");
            PrintArray(matrix);
        }

        public static void PrintArray(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }

        }

        public static void SetZeroes(int[,] matrix)
        {
            int col0 = 1, rows = matrix.GetLength(0), cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, 0] == 0) col0 = 0;
                for (int j = 1; j < cols; j++)
                    if (matrix[i, j] == 0)
                    {
                        Console.WriteLine("upding  matrix[{0}, {1}] and col0 values :{2}", i, j, col0);
                        matrix[i, 0] = matrix[0, j] = 0;
                    }
            }

            Console.WriteLine("InProcess........");
            PrintArray(matrix);


            for (int i = rows - 1; i >= 0; i--)
            {
                for (int j = cols - 1; j >= 1; j--)
                    if (matrix[i, 0] == 0 || matrix[0, j] == 0)
                    {
                        Console.WriteLine("upding  matrix[{0}, {1}] and col0 values :{2}", i, j, col0);
                        matrix[i, j] = 0;
                    }
                if (col0 == 0) matrix[i, 0] = 0;
            }


        }

        public static void SetZeroesHash(int[,] matrix)
        {
            HashSet<int> rows = new HashSet<int>();
            HashSet<int> cols = new HashSet<int>();

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        rows.Add(i);
                        cols.Add(j);
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (rows.Contains(i) || cols.Contains(j))
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }
    }
}
