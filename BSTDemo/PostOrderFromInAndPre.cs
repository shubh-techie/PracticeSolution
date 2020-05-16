using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTDemo
{
    public class PostOrderFromInAndPre
    {

        public static void PrintPostOrderFromInAndPre(int[] preOrer, int[] inOrder)
        {
            PrintPostOrderFromInAndPreHelper(preOrer, inOrder, 0, 0, inOrder.Length - 1);
        }

        private static void PrintPostOrderFromInAndPreHelper(int[] preOrer, int[] inOrder, int preIndex, int start, int end)
        {
            if (start > end && preIndex < end)
                return;

            int rootIndex = SearchRoot(inOrder, preOrer[preIndex++], start, end);
            //preIndex++;

            PrintPostOrderFromInAndPreHelper(preOrer, inOrder, preIndex, start, rootIndex - 1);
            PrintPostOrderFromInAndPreHelper(preOrer, inOrder, preIndex, rootIndex + 1, end);

            Console.WriteLine(inOrder[rootIndex]);
        }
        public static int SearchRoot(int[] inOrder, int preOrer, int start, int end)
        {
            for (int i = start; i < end; i++)
            {
                if (inOrder[i] == preOrer)
                {
                    Console.WriteLine("preOrer {0}, index {1}", preOrer, i);
                    return i;
                }
            }

            return -1;
        }

        


    }
}
