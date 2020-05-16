using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    //Definition for a binary tree node.
    public class BSTNode
    {
        public int val;
        public BSTNode left;
        public BSTNode right;
        public BSTNode(int x) { val = x; }
    }

    public class Codec
    {

        public BSTNode desHelper(Queue<string> qData, int min, int max)
        {
            if (qData.Count == 0) return null;
            int val = Convert.ToInt32(qData.Peek());
            if (val < min || val > max) return null;
            qData.Dequeue();
            BSTNode root = new BSTNode(val);
            root.left = desHelper(qData, min, val);
            root.right = desHelper(qData, val, max);
            return root;
        }
        public void serHelper(BSTNode root, StringBuilder serObj)
        {
            if (root == null) return;
            serObj.Append(root.val).Append(",");
            serHelper(root.left, serObj);
            serHelper(root.right, serObj);
        }
        // Encodes a tree to a single string.
        public string serialize(BSTNode root)
        {
            StringBuilder serObj = new StringBuilder();
            serHelper(root, serObj);
            return serObj.ToString();
        }

        // Decodes your encoded data to tree.
        public BSTNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data)) return null;
            Console.WriteLine(data);

            Queue<string> qData = new Queue<string>();
            string[] split = data.Split(",");
            foreach (var item in split)
            {
                if (!string.IsNullOrEmpty(item))
                    qData.Enqueue(item);
            }
            BSTNode output = desHelper(qData, int.MinValue, int.MaxValue);
            return output;
        }
    }
    public class Quest449SerializeandDeserializeBST
    {
        public static void Testing()
        {
            BSTNode root = new BSTNode(2)
            {
                left = null,
                right = new BSTNode(3)
            };
            root.right.left = null;
            root.right.right = new BSTNode(4);
            Codec _codec = new Codec();
            string serOBj = _codec.serialize(root);
            Console.WriteLine(serOBj);
            BSTNode output = _codec.deserialize(serOBj);
            TraverserBST(output);
        }

        private static void TraverserBST(BSTNode root)
        {
            if (root == null) return;
            Console.WriteLine(root.val);
            TraverserBST(root.left);
            TraverserBST(root.right);


        }
    }
}
