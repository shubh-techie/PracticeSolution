using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTDemo
{
    public class TreeUtil
    {
        public static void PreOrder(TreeNode root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }


        public static TreeNode InsertRecKey(TreeNode root, int key)
        {
            if (root == null)
            {
                root = new TreeNode(key);
                return root;
            }
            root.Left = InsertRecKey(root.Left, key);
            root.Right = InsertRecKey(root.Right, key);

            return root;
        }

        public static void InsertKey(TreeNode root, int key)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode temp = queue.Dequeue();
                if (temp.Left == null)
                {
                    temp.Left = new TreeNode(key); ;
                    break;
                }
                else
                    queue.Enqueue(temp.Left);

                if (temp.Right == null)
                {
                    temp.Right = new TreeNode(key); ;
                    break;
                }
                else
                    queue.Enqueue(temp.Right);
            }

        }

        public static IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            IList<IList<int>> results = new List<IList<int>>();
            if (root == null) return results;

            SortedDictionary<int, List<int>> output = new SortedDictionary<int, List<int>>();
            VerticalTraversalHelper(root, output, 0);

            foreach (var item in output.Values)
            {
                item.Sort();
                results.Add(item);
            }

            return results;
        }
        public static void VerticalTraversalHelper(TreeNode root, SortedDictionary<int, List<int>> output, int level)
        {
            if (!output.ContainsKey(level))
            {
                List<int> temp = new List<int>() { root.Data };
                output.Add(level, temp);
            }
            else
            {
                output[level].Add(root.Data);
            }

            if (root.Left != null)
                VerticalTraversalHelper(root.Left, output, level - 1);
            if (root.Right != null)
                VerticalTraversalHelper(root.Right, output, level + 1);
        }
        internal static SortedDictionary<int, IList<int>> GetVerticalOrders(TreeNode root)
        {
            SortedDictionary<int, IList<int>> output = new SortedDictionary<int, IList<int>>();
            if (root == null) return output;
            GetVerticalOrdersRec(root, output, 0);
            IList<IList<int>> results = new List<IList<int>>();

            foreach (var item in output.Values)
            {
                results.Add(item);
            }
            return output;
        }

        private static void GetVerticalOrdersRec(TreeNode root, SortedDictionary<int, IList<int>> output, int level)
        {
            if (!output.ContainsKey(level))
            {
                IList<int> temp = new List<int>() { root.Data };
                output.Add(level, temp);
            }
            else
            {
                output[level].Add(root.Data);
            }

            if (root.Left != null)
                GetVerticalOrdersRec(root.Left, output, level - 1);
            if (root.Right != null)
                GetVerticalOrdersRec(root.Right, output, level + 1);
        }

        internal static IList<int> RightSideView(TreeNode root)
        {
            if (root == null) return new List<int>();
            IList<int> output = new List<int>();
            RightSideViewHelper(root, output, 0);
            return output;
        }

        public static void RightSideViewHelper(TreeNode root, IList<int> output, int level)
        {
            if (level == output.Count)
            {
                output.Add(root.Data);
            }
            else
            {
                output[level] = root.Data;
            }

            if (root.Left != null)
                RightSideViewHelper(root.Left, output, level + 1);
            if (root.Right != null)
                RightSideViewHelper(root.Right, output, level + 1);

        }

        internal static Dictionary<int, List<int>> GetDiagonalOrders(TreeNode root)
        {
            Dictionary<int, List<int>> output = new Dictionary<int, List<int>>();
            if (root == null) return output;
            GetDiagonalOrdersRec(root, output, 0);
            return output;
        }

        private static void GetDiagonalOrdersRec(TreeNode root, Dictionary<int, List<int>> output, int level)
        {
            if (!output.ContainsKey(level))
            {
                List<int> temp = new List<int>() { root.Data };
                output.Add(level, temp);
            }
            else
            {
                output[level].Add(root.Data);
            }

            if (root.Left != null)
                GetDiagonalOrdersRec(root.Left, output, level + 1);
            if (root.Right != null)
                GetDiagonalOrdersRec(root.Right, output, level);
        }



        internal static List<List<int>> GetLevelOrders(TreeNode root)
        {
            List<List<int>> output = new List<List<int>>();
            if (root == null) return output;
            GetLevelOrdersRec(root, output, 0);
            return output;
        }

        private static void GetLevelOrdersRec(TreeNode root, List<List<int>> output, int level)
        {
            if (output.Count == level)
            {
                output.Add(new List<int>() { root.Data });
            }
            else
            {
                output[level].Add(root.Data);
            }

            if (root.Left != null)
                GetLevelOrdersRec(root.Left, output, level + 1);
            if (root.Right != null)
                GetLevelOrdersRec(root.Right, output, level + 1);

        }


        internal static List<List<int>> GetZigZagOrders(TreeNode root)
        {
            List<List<int>> output = new List<List<int>>();
            if (root == null) return output;
            GetZigZagOrdersRec(root, output, 0);
            return output;
        }

        private static void GetZigZagOrdersRec(TreeNode root, List<List<int>> output, int level)
        {
            if (output.Count == level)
            {
                output.Add(new List<int>() { root.Data });
            }
            else
            {
                if (level % 2 == 0)
                    output[level].Add(root.Data);
                else
                    output[level].Insert(0, root.Data);
            }

            if (root.Left != null)
                GetZigZagOrdersRec(root.Left, output, level + 1);
            if (root.Right != null)
                GetZigZagOrdersRec(root.Right, output, level + 1);
        }

        public static int TreePaths(TreeNode root, int targetSum)
        {
            if (root == null) return 0;
            int pathFromRoot = ReadAllThePath(root, targetSum, 0);

            int pathOfleft = TreePaths(root.Left, targetSum);
            int pathOfRight = TreePaths(root.Right, targetSum);

            return pathFromRoot + pathOfleft + pathOfRight;
        }

        private static int ReadAllThePath(TreeNode root, int targetSum, int currSum)
        {
            if (root == null) return 0;

            currSum += root.Data;
            //Console.WriteLine(currSum);

            int totalPath = 0;
            if (currSum == targetSum)
            {
                totalPath++;
            }

            totalPath += ReadAllThePath(root.Left, targetSum, currSum);
            totalPath += ReadAllThePath(root.Left, targetSum, currSum);

            return totalPath;
        }
    }
}

