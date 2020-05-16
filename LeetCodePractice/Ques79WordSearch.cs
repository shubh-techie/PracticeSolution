using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class Ques79WordSearch
    {
        public static void Exist()
        {
            char[][] board = new char[3][];
            board[0] = new char[] { 'A', 'B', 'C', 'E' };
            board[1] = new char[] { 'S', 'F', 'C', 'S' };
            board[2] = new char[] { 'A', 'D', 'E', 'E' };
            //string word = "ABCCED";
            string word = "ABCB";
            Console.WriteLine(Exist(board, word));
        }
        public static bool Exist(char[][] board, string word)
        {
            if (board.Length == 0) return false;
            int rows = board.Length;
            int cols = board[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (isExist(board, i, j, rows-1, cols-1, word, 0)) return true;
                }
            }

            return false;
        }
        public static bool isExist(char[][] board, int i, int j, int rows, int cols, string word, int wordIndex)
        {
            if (wordIndex == word.Length) return true;
            if (i < 0 || j < 0 || i > rows || j > cols || board[i][j] != word[wordIndex]) return false;

            board[i][j] = '#';
            bool check = isExist(board, i - 1, j, rows, cols, word, wordIndex + 1) ||
                        isExist(board, i, j - 1, rows, cols, word, wordIndex + 1) ||
                        isExist(board, i, j + 1, rows, cols, word, wordIndex + 1) ||
                        isExist(board, i + 1, j, rows, cols, word, wordIndex + 1);
            board[i][j] = word[wordIndex];
            return check;
        }
    }
}
