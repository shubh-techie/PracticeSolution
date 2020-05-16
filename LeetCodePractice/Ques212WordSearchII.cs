using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class Ques212WordSearchII
    {
        public class TrieNode
        {
            public TrieNode[] next = new TrieNode[26];
            public string word;
        }

        public static TrieNode buildTrie(String[] words)
        {
            TrieNode root = new TrieNode();
            foreach (string w in words)
            {
                TrieNode p = root;
                foreach (char c in w.ToCharArray())
                {
                    int i = c - 'a';
                    if (p.next[i] == null)
                        p.next[i] = new TrieNode();
                    p = p.next[i];
                }
                p.word = w;
            }
            return root;
        }

        public static void Exist()
        {
            char[][] board = new char[4][];
            board[0] = new char[] { 'o', 'a', 'a', 'n' };
            board[1] = new char[] { 'e', 't', 'a', 'e' };
            board[2] = new char[] { 'i', 'h', 'k', 'r' };
            board[3] = new char[] { 'i', 'f', 'l', 'v' };
            //string word = "ABCCED";
            string[] words = { "eat", "pea", "oath", "rain" };
            IList<string> validWords = FindWords(board, words);

            foreach (var item in validWords)
            {
                Console.WriteLine(item);
            }
        }
        public static IList<string> FindWords(char[][] board, string[] words)
        {
            IList<string> output = new List<string>();

            if (board.Length == 0) return output;
            int rows = board.Length;
            int cols = board[0].Length;

            TrieNode root = buildTrie(words);

            for (int i = 0; i < rows; i++)
            { 
                for (int j = 0; j < cols; j++)
                {
                    isExist(board, i, j, root, output);
                }
            }

            return output;
        }
        public static void isExist(char[][] board, int i, int j, TrieNode wordNode, IList<string> output)
        {
            char boardChar = board[i][j];
            if (boardChar == '#' || wordNode.next[boardChar - 'a'] == null) return;
            TrieNode currNode;
            currNode = wordNode.next[boardChar - 'a'];

            Console.WriteLine("wordNode : : " + wordNode);
            if (currNode.word != null)
            {   // found one
                output.Add(currNode.word);
                currNode.word = null;     // de-duplicate
            }

            board[i][j] = '#';
            if (i > 0) isExist(board, i - 1, j, wordNode, output);
            if (j > 0) isExist(board, i, j - 1, wordNode, output);
            if (i < board.Length - 1) isExist(board, i + 1, j, wordNode, output);
            if (j < board[0].Length - 1) isExist(board, i, j + 1, wordNode, output);
            board[i][j] = boardChar;

        }
    }
}
