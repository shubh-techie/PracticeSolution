using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class Ques23MergeKth
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists.Length == 0) return null;
            if (lists.Length == 1) return lists[0];
            if (lists.Length == 2) return mergeTwoLists(lists[0], lists[1]);
            return mergeTwoLists(MergeKLists(new List<ListNode>(lists).GetRange(0, lists.Length / 2).ToArray()),
                MergeKLists(new List<ListNode>(lists).GetRange(lists.Length / 2, lists.Length).ToArray()));

            
        }

        public ListNode mergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            if (l1.val <= l2.val)
            {
                l1.next = mergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = mergeTwoLists(l1, l2.next);
                return l2;
            }
        }
    }
}
