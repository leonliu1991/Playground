using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
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

    public class Stack
    {
        public Queue<int> q1 = new Queue<int>();
        public Queue<int> q2 = new Queue<int>();

        public void Push(int x)
        {
            q2.Enqueue(x);

            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Peek());
                q1.Dequeue();
            }

            Queue<int> temp = new Queue<int>();
            temp = q1;
            q1 = q2;
            q2 = temp;
        }

        public void Pop()
        {
            if (q1.Count > 0)
                q1.Dequeue();
            else
                return;
        }
    }

    public class Solution
    {
        public ListNode ReverseBetween(ListNode head, int left, int right)
        {
            if (head == null || left == right) return head;

            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode prev = dummy;

            for (int i = 0; i < left - 1; ++i)
            {
                prev = prev.next;
            }

            ListNode current = prev.next;

            for (int i = 0; i < right - left; ++i)
            {
                ListNode nextNode = current.next;
                current.next = nextNode.next;
                nextNode.next = prev.next;
                prev.next = nextNode;
            }

            return dummy.next;
        }

        public ListNode ReverseEveryKNode(ListNode head, int k)
        {
            if (head == null)
                return null;
            ListNode current = head;
            ListNode prev = null;
            ListNode next = null;

            int count = 0;

            while (count < k && current != null)
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next;
                
                count++;
            }

            if (current != null)
                head.next=ReverseEveryKNode(current, k);

            return prev;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode();
            ListNode current = dummyHead;
            int carry = 0;

            while (l1 != null || l2 != null)
            {
                int x = (l1 != null) ? l1.val : 0;
                int y = (l2 != null) ? l2.val : 0;

                int sum = x + y + carry;
                carry = sum / 10;

                current.next = new ListNode(sum % 10);
                current = current.next;

                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;

            }

            if (carry != 0)
                current.next = new ListNode(carry);

            return dummyHead.next;
        }
    }
}
