using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  题目：删除链表的倒数第N个节点
给定一个链表，删除链表的倒数第 n 个节点，并且返回链表的头结点。

示例：

给定一个链表: 1->2->3->4->5, 和 n = 2.

当删除了倒数第二个节点后，链表变为 1->2->3->5.
说明：

给定的 n 保证是有效的。

进阶：

你能尝试使用一趟扫描实现吗？
*/

/*
Given a linked list, remove the n-th node from the end of list and return its head.

Example:

Given linked list: 1->2->3->4->5, and n = 2.

After removing the second node from the end, the linked list becomes 1->2->3->5.
Note:

Given n will always be valid.

Follow up:

Could you do this in one pass?
*/

namespace RemoveNthFromEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(3);
            ListNode node4 = new ListNode(4);
            ListNode node5 = new ListNode(5);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;

            Solution solution = new Solution();
            solution.RemoveNthFromEnd(node1, 5);
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
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            Stack<ListNode> listNodeStack = new Stack<ListNode>();
            ListNode node = head;
            while (node != null)
            {
                listNodeStack.Push(node);
                node = node.next;
            }

            while (n > 0)
            {
                node = listNodeStack.Pop();
                n--;
            }

            if (listNodeStack.Count > 0)
            {
                node = listNodeStack.Pop();
                node.next = node.next.next;
            }
            else
            {
                return node.next;
            }

            return listNodeStack.Count > 0 ? head : node;
        }
    }
}
