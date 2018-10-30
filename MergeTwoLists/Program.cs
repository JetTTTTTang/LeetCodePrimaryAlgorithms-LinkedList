using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  题目：合并两个有序链表
将两个有序链表合并为一个新的有序链表并返回。新链表是通过拼接给定的两个链表的所有节点组成的。 

示例：

输入：1->2->4, 1->3->4
输出：1->1->2->3->4->4
 */

/*Merge two sorted linked lists and return it as a new list. The new list should be made by splicing together the nodes of the first two lists.

Example:

Input: 1->2->4, 1->3->4
Output: 1->1->2->3->4->4
*/

namespace MergeTwoLists
{
    class Program
    {
        static void Main(string[] args)
        {
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
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode(0);
            ListNode temp = head;
            while (l1 != null && l2 != null)
            {
                if (l1.val > l2.val)
                {
                    temp.next = l2;
                    temp = temp.next;
                    l2 = l2.next;
                }
                else
                {
                    temp.next = l1;
                    temp = temp.next;
                    l1 = l1.next;
                }
            }
            if (l1 == null && l2 != null)
            {
                temp.next = l2;
            }
            else if (l1 != null && l2 == null)
            {
                temp.next = l1;
            }
            return head.next;
        }
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        ListNode head, node;
        if (l1 != null && l2 != null)
        {
            if (l1.val <= l2.val)
            {
                head = l1;
                l1 = l1.next;
            }
            else
            {
                head = l2;
                l2 = l2.next;
            }
            node = head;

            while (true)
            {
                if (l1 != null && l2 != null)
                {
                    if (l1.val <= l2.val)
                    {
                        node.next = l1;
                        l1 = l1.next;
                    }
                    else
                    {
                        node.next = l2;
                        l2 = l2.next;
                    }
                    node = node.next;
                }
                else if (l1 == null && l2 != null)
                {
                    node.next = l2;
                    break;
                }
                else if (l1 != null && l2 == null)
                {
                    node.next = l1;
                    break;
                }
                else
                {
                    break;
                }
            }
            return head;
        }
        else if (l1 == null && l2 != null)
        {
            head = l2;
            return head;
        }
        else if (l1 != null && l2 == null)
        {
            head = l1;
            return head;
        }
        else
        {
            return null;
        }

    }
}