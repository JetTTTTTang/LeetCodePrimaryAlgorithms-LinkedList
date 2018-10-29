using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  题目：反转链表
反转一个单链表。

示例:

输入: 1->2->3->4->5->NULL
输出: 5->4->3->2->1->NULL
进阶:
你可以迭代或递归地反转链表。你能否用两种方法解决这道题？
 */

/*
Reverse a singly linked list.

Example:

Input: 1->2->3->4->5->NULL
Output: 5->4->3->2->1->NULL
Follow up:

A linked list can be reversed either iteratively or recursively. Could you implement both?
*/

namespace ReverseLink
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode n1 = new ListNode(1);
            ListNode n2 = new ListNode(2);
            ListNode n3 = new ListNode(3);
            ListNode n4 = new ListNode(4);
            ListNode n5 = new ListNode(5);
            n1.next = n2;
            n2.next = n3;
            n3.next = n4;
            n4.next = n5;

            Solution solution = new Solution();
            solution.ReverseList(n1);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return head;
            //head = ReverseListIteratively(head);
            head = ReverseListRecursively(head);
            return head;
        }

        private ListNode ReverseListIteratively(ListNode head)
        {
            Stack<ListNode> nodeStack = new Stack<ListNode>();
            nodeStack.Push(head);

            head = head.next;
            while(head != null)
            {
                nodeStack.Push(head);
                head = head.next;
            }

            head = nodeStack.Pop();
            ListNode node = head;
            while (nodeStack.Count > 0)
            {
                node.next = nodeStack.Pop();
                node = node.next;
            }

            node.next = null;

            return head;
        }

        private ListNode ReverseListRecursively(ListNode head)
        {
            if (head.next != null)
            {
                ListNode node = ReverseListRecursively(head.next);
                ListNode temp = node;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = head;
                head.next = null;
                return node;
            }
            else
            {
                return head;
            }
        }
    }
}
