using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }
    class Ques103BinaryTreeZigzagLevel
    {
        public void ZigzagLevelOrder()
        {

        }
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            if (root == null)
            {
                return new List<IList<int>>(); ;
            }
            IList<IList<int>> output = new List<IList<int>>();
            ZigzagLevelOrderHelper(root, output, 0);
            return output;
        }
        public void ZigzagLevelOrderHelper(TreeNode root, IList<IList<int>> output, int level)
        {
            if (level >= output.Count)
            {
                IList<int> temp = new List<int>();
                temp.Add(root.val);
                output.Add(temp);
            }
            else
            {
                if (level % 2 == 0)
                {
                    output[level].Add(root.val);
                }
                else
                {
                    output[level].Insert(0, root.val);
                }
            }

            if (root.left != null) ZigzagLevelOrderHelper(root.left, output, level + 1);
            if (root.right != null) ZigzagLevelOrderHelper(root.right, output, level + 1);
        }
    }
}
