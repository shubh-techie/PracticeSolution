using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTDemo
{
    public class TreeNode
    {
        public int Data;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int data)
        {
            this.Data = data;
            this.Left = this.Right = null;
        }


        public void PreOrderTraverse(TreeNode root)
        {
            if (root != null)
            {
                Console.Write(root.Data + " ");
                PreOrderTraverse(root.Left);
                PreOrderTraverse(root.Right);
            }
            else
            {
                Console.Write("NULL" + " ");
            }
        }

        public void InOrderTraverse(TreeNode root)
        {
            if (root != null)
            {
                InOrderTraverse(root.Left);
                Console.Write(root.Data + " ");
                InOrderTraverse(root.Right);
            }
        }
        public void InOrderIterative(TreeNode root)
        {
            if (root == null) return;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            TreeNode node = root;
            while (node != null || stack.Count > 0)
            {
                if (node != null)
                {
                    stack.Push(node);
                    node = node.Left;
                }
                else
                {
                    node = stack.Pop();
                    Console.Write(node.Data + " ");
                    node = node.Right;
                }
            }
        }


        public void PostOrderTraverse(TreeNode root)
        {
            if (root != null)
            {
                PreOrderTraverse(root.Left);
                PreOrderTraverse(root.Right);
                Console.WriteLine(root.Data + " ");
            }
        }


        public void Traverse(TreeNode root)
        {
            if (root == null) return;
            Console.Write(root.Data + " ");
            Traverse(root.Left);
            Traverse(root.Right);
        }

        public void InsertKey(TreeNode root, int key)
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

        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return null;
            if (root.Left == null && root.Right == null)
            {
                if (root.Data == key)
                    return null;
                else
                    return root;
            }
            TreeNode CurrNode = null;
            TreeNode keyNode = null;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                CurrNode = queue.Dequeue();
                if (CurrNode.Data == key)
                    keyNode = CurrNode;

                if (CurrNode.Left != null)
                    queue.Enqueue(CurrNode.Left);

                if (CurrNode.Right != null)
                    queue.Enqueue(CurrNode.Right);
            }

            if (keyNode != null)
            {
                int deepestKey = CurrNode.Data;
                DeleteDeepestNode(root, CurrNode);
                keyNode.Data = deepestKey;
            }

            return root;
        }

        private void DeleteDeepestNode(TreeNode root, TreeNode currNode)
        {
            if (root != null)
            {
                if (root == currNode)
                {
                    root = null;
                    return;
                }
                else
                {
                    DeleteDeepestNode(root.Left, currNode);
                    DeleteDeepestNode(root.Right, currNode);
                }
            }
        }

        public Boolean IsTreeContinuous(TreeNode root)
        {
            if (root == null) return true;

            if (root.Left == null && root.Right == null)
            {
                return true;
            }

            if (!IsBalanceTree(root))
                return false;

            return IsTreeContinuous(root.Left) && IsTreeContinuous(root.Right);
        }

        private Boolean IsBalanceTree(TreeNode root)
        {
            if (root.Left != null)
            {
                if (Math.Abs(root.Data - root.Left.Data) != 1)
                    return false;
            }

            if (root.Right != null)
            {
                if (Math.Abs(root.Data - root.Right.Data) != 1)
                    return false;
            }

            return true;
        }


        public bool IsSymmetricTree(TreeNode root1, TreeNode root2)
        {
            return isIsSymmetricHelper(root1, root2);
        }

        public bool isIsSymmetricHelper(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            if (root1 == null || root2 == null) return false;

            if (root1 != null && root2 != null && root1.Data == root2.Data)
            {
                return isIsSymmetricHelper(root1.Left, root2.Right) && isIsSymmetricHelper(root1.Right, root2.Left);
            }

            return false;
        }

    }

}


