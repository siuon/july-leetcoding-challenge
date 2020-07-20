using System;

namespace _020_Remove_Linked_List_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Remove all elements from a linked list of integers that have value val.

                Example:
                Input:  1->2->6->3->4->5->6, val = 6
                Output: 1->2->3->4->5
            */

            var head = new ListNode(1, null);
            var node2 = new ListNode(2, null);
            var node3 = new ListNode(6, null);
            var node4 = new ListNode(3, null);
            var node5 = new ListNode(4, null);
            var node6 = new ListNode(5, null);
            var node7 = new ListNode(6, null);

            head.next = node2;
            head.next.next = node3;
            head.next.next.next = node4;
            head.next.next.next.next = node5;
            head.next.next.next.next.next = node6;
            head.next.next.next.next.next.next = node7;

            var val = 6;

            var solution = new Solution();

            var result = solution.RemoveElements(head, val);
        }
    }

    /*
     * Definition for singly-linked list.
     */
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

    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            var returnNode = new ListNode(0, null);
            ref ListNode returnTempNode = ref returnNode.next;
            var currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.val != val)
                {
                    returnTempNode = currentNode;
                    returnTempNode = ref returnTempNode.next;
                }

                currentNode = currentNode.next;
            }

            if (returnTempNode != null &&
                returnTempNode.val == val)
            {
                returnTempNode = null;
            }

            return returnNode.next;
        }
    }
}
