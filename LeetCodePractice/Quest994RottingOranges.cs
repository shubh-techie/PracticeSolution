using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class Quest994RottingOranges
    {
        public void OrangesRotting()
        {
            int[][] grid = new int[3][];
            grid[0] = new int[] { 2, 1, 1 };
            grid[1] = new int[] { 1, 1, 0 };
            grid[2] = new int[] { 0, 1, 1 };

            int[][] grid2 = new int[1][];
            grid2[0] = new int[] { 0, 2 };

            int[][] grid3 = new int[3][];
            grid3[0] = new int[] { 2, 1, 1 };
            grid3[1] = new int[] { 0, 1, 1 };
            grid3[2] = new int[] { 1, 0, 1 };

            int[][] grid4 = new int[1][];
            grid3[0] = new int[] { 1 };

            Console.WriteLine("No of minutes :" + OrangesRotting(grid3));
        }
        public int OrangesRotting(int[][] grid)
        {
            if (grid.Length == 0) return 0;
            if (grid[0].Length == 0) return 0;
            int minutes = 0, rows = grid.Length, cols = grid[0].Length, freshOrange = 0;
            Queue<int[]> rottenQueue = new Queue<int[]>();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 2)
                    {
                        rottenQueue.Enqueue(new int[] { i, j });
                    }
                    if (grid[i][j] == 1)
                        freshOrange++;
                }
            }

            // return zero if there is no rotten orange or fresh orange
            int[,] neighbourDirs = new int[,] { { 1, 0 }, { -1, 0 }, { 0, 1 }, { 0, -1 } };

            while (rottenQueue.Count > 0 && freshOrange > 0)
            {
                minutes++;
                int size = rottenQueue.Count;
                for (int i = 0; i < size; i++)
                {
                    //loop all four neighbour
                    int[] rAddress = rottenQueue.Dequeue();
                    for (int p = 0; p < neighbourDirs.GetLength(0); p++)
                    {
                        int x = rAddress[0] + neighbourDirs[p, 0];
                        int y = rAddress[1] + neighbourDirs[p, 1];
                        if (x >= 0 && x < rows && y >= 0 && y < cols)
                        {
                            if (grid[x][y] == 1)
                            {
                                rottenQueue.Enqueue(new int[] { x, y });
                                grid[x][y] = 2; //make it rotten orange
                                freshOrange--;
                            }
                        }
                    }
                }
            }

            return freshOrange != 0 ? -1 : minutes;
        }
    }
}
