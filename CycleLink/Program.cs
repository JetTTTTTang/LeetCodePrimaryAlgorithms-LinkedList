using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*题目：环形链表
给定一个链表，判断链表中是否有环。

为了表示给定链表中的环，我们使用整数 pos 来表示链表尾连接到链表中的位置（索引从 0 开始）。 如果 pos 是 -1，则在该链表中没有环。

 

示例 1：

输入：head = [3,2,0,-4], pos = 1
输出：true
解释：链表中有一个环，其尾部连接到第二个节点。


示例 2：

输入：head = [1,2], pos = 0
输出：true
解释：链表中有一个环，其尾部连接到第一个节点。


示例 3：

输入：head = [1], pos = -1
输出：false
解释：链表中没有环。


 

进阶：

你能用 O(1)（即，常量）内存解决此问题吗？
 */

/*
Given a linked list, determine if it has a cycle in it.

To represent a cycle in the given linked list, we use an integer pos which represents the position (0-indexed) in the linked list where tail connects to. If pos is -1, then there is no cycle in the linked list.

 

Example 1:

Input: head = [3,2,0,-4], pos = 1
Output: true
Explanation: There is a cycle in the linked list, where tail connects to the second node.


Example 2:

Input: head = [1,2], pos = 0
Output: true
Explanation: There is a cycle in the linked list, where tail connects to the first node.


Example 3:

Input: head = [1], pos = -1
Output: false
Explanation: There is no cycle in the linked list.


 

Follow up:

Can you solve it using O(1) (i.e. constant) memory?
 */

namespace CycleLink
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(3);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(0);
            ListNode node4 = new ListNode(-4);
            node1.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node2;
            Solution solution = new Solution();
            solution.HasCycle(node1);
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null)
                return false;

            ListNode slow = head;
            ListNode fast = head;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow)
                    return true;
            }
            return false;
        }
    }
}
