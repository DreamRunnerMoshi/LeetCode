using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions
{
    public class _19RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {

            int count = 1;
            var node = new ListNode(head.val, head.next);
            while (node.next != null)
            {
                count++;
                node = new ListNode(node.next.val, node.next.next);
            }

            var fromStart = count - (n - 1);

            if (fromStart == 1)
            {
                head = head.next;
                return head;
            }

            var prevNode = head;
            var nextNode = head.next;

            int start = 1;
            while (start + 1 < fromStart)
            {
                prevNode = prevNode.next;
                nextNode = nextNode.next;
                start++;
            }

            prevNode.next = nextNode.next;
            return head;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
