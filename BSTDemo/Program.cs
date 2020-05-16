using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTDemo
{

    class Program
    {
        static void Main(string[] args)
        {

            string hello = "Hello World!";
            Console.WriteLine(hello.Contains("hello"));
            Console.WriteLine(hello.IndexOf("Hello"));

            TreeNode root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            TreeUtil.InsertKey(root, 4);
            TreeUtil.InsertKey(root, 5);
            TreeUtil.InsertKey(root, 6);
            TreeUtil.InsertKey(root, 7);
            //TreeUtil.InsertKey(root, 8);
            //TreeUtil.InsertKey(root, 9);
            Console.WriteLine("reading using preorder ");
            TreeUtil.PreOrder(root);

            Console.WriteLine();
            TreeNode rootright = new TreeNode(1);
            rootright.Left = new TreeNode(2);
            rootright.Right = new TreeNode(3);
            rootright.Right.Right = new TreeNode(4);
            rootright.Left.Right = new TreeNode(5);
            Console.WriteLine("Reading right views");
            IList<int> outpur = TreeUtil.RightSideView(rootright);


            Console.WriteLine();
            Console.WriteLine("Vertical  order Sorted Dictionary");
            IList<IList<int>> result = TreeUtil.VerticalTraversal(root);
            foreach (var item in result)
            {
                foreach (var ls in item)
                {
                    Console.Write(ls + " ");
                }
                Console.WriteLine();
            }

            //Console.WriteLine("reading using TreePaths 9 ");
            //Console.WriteLine(TreeUtil.TreePaths(root, 8));

            Console.WriteLine();
            Console.WriteLine("level order");
            List<List<int>> LeverOrders = TreeUtil.GetLevelOrders(root);
            ReadListCollection(LeverOrders);

            Console.WriteLine();
            Console.WriteLine("ZigZag  order");
            List<List<int>> ZigZagOrders = TreeUtil.GetZigZagOrders(root);
            ReadListCollection(ZigZagOrders);

            Console.WriteLine();
            Console.WriteLine("Vertical  order");
            SortedDictionary<int, IList<int>> VerticalOrders = TreeUtil.GetVerticalOrders(root);
            //ReadDictionaryCollection(VerticalOrders);

            Console.WriteLine();
            Console.WriteLine("Diagonal  order");
            Dictionary<int, List<int>> DiagonalOrders = TreeUtil.GetDiagonalOrders(root);
            ReadDictionaryCollection(DiagonalOrders);










            //BinaryTreeSet1();
            Console.WriteLine("Please press <enter> to exit !");
            Console.ReadLine();
        }

        private static void ReadDictionaryCollection(Dictionary<int, List<int>> dicCollection)
        {
            foreach (var item in dicCollection.Values)
            {
                foreach (var data in item)
                {
                    Console.Write(data.ToString(), ", ");
                }
                Console.WriteLine();
            }
        }

        private static void ReadListCollection(List<List<int>> leverOrders)
        {
            foreach (var item in leverOrders)
            {
                foreach (var data in item)
                {
                    Console.Write(data.ToString(), ", ");
                }
                Console.WriteLine();
            }
        }

        private static void BinaryTreeSet1()
        {
            TreeNode root = new TreeNode(1);
            root.Left = new TreeNode(2);
            root.Right = new TreeNode(3);
            root.Left.Left = new TreeNode(4);
            root.InsertKey(root, 5);
            root.InsertKey(root, 6);
            root.InsertKey(root, 7);
            //root.InsertKey(root, 8);
            //root.InsertKey(root, 9);
            //root.InsertKey(root, 10);
            //root.InsertKey(root, 11);
            //root.InsertKey(root, 12);
            //root.InsertKey(root, 13);
            //root.InsertKey(root, 14);
            //root.InsertKey(root, 15);

            Console.WriteLine();
            Console.WriteLine("In order traverse");
            root.InOrderTraverse(root);

            Console.WriteLine();
            Console.WriteLine("InOrderIterative traverse");
            root.InOrderIterative(root);
            //root.DeleteNode(root, 2);
            //Console.WriteLine("After Deletion");
            //root.Traverse(root);


            //Testing Postorder traversal from given Inorder and Preorder traversals
            int[] inorder = { 4, 2, 5, 1, 3, 6 };
            int[] preorder = { 1, 2, 4, 5, 3, 6 };
            PostOrderFromInAndPre.PrintPostOrderFromInAndPre(preorder, inorder);

            Console.WriteLine(root.IsTreeContinuous(root));
        }
    }
}
