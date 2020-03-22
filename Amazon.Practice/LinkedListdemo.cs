using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon.Practice
{
    public class Node
    {
        int Data;
        Node Next;
        public Node(int d)
        {
            this.Data = d;
            this.Next = null;
        }
    }

    public class DNode
    {
        int Data;
        DNode Next;
        DNode Prev;
        public DNode(int intData)
        {
            this.Data = intData;
            Prev = null;
            Next = null;
        }
    }

    public class SingleLinkList
    {
        public Node head;
    }

    public class DoubleLinkList
    {
        public DNode head;
    }

    class LinkedListdemo
    {
       
    }
}
