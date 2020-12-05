using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramClient
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class _2AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            ListNode root = new ListNode(0);
            ListNode next = root;
            int carry = 0;

            //addSingle(l1, l2, root, carry);

            return root;
        }

        ListNode addSingle(ListNode l1, ListNode l2, int carry)
        {
            ListNode result = new ListNode(1);
            if (l1 == null && l2 == null)
            {
                if (carry > 0)
                {
                    result.val = carry;
                    result.next = null;
                }
                else result = null;

                return result;
            };

            int val1 = l1 != null ? l1.val : 0;
            int val2 = l2 != null ? l2.val : 0;

            int sum = val1 + val2 + carry;

            new ListNode(sum > 9 ? sum % 10 : sum);
            result.next = new ListNode(0);
            carry = sum > 9 ? 1 : 0;

            //result.next = addSingle(l1 != null ? l1.next : null, l2 != null ? l2.next : null, result.next, carry);
            return result;
        }

    }
}
