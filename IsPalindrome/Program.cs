using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 题目：回文链表
请判断一个链表是否为回文链表。

示例 1:

输入: 1->2
输出: false
示例 2:

输入: 1->2->2->1
输出: true
进阶：
你能否用 O(n) 时间复杂度和 O(1) 空间复杂度解决此题？
 */

/* Given a singly linked list, determine if it is a palindrome.

Example 1:

Input: 1->2
Output: false
Example 2:

Input: 1->2->2->1
Output: true
Follow up:
Could you do it in O(n) time and O(1) space?
*/

namespace IsPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode test1 = new ListNode(1);
            ListNode test2 = new ListNode(2);
            ListNode test3 = new ListNode(2);
            ListNode test4 = new ListNode(1);
            test1.next = test2;
            test2.next = test3;
            test3.next = test4;

            Solution solution = new Solution();
            System.Console.WriteLine(solution.IsPalindrome(test1));
            System.Console.ReadKey();
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
        public bool IsPalindrome(ListNode head)
        {
            if (head.next == null)
            {
                return true;
            }

            ListNode fastNode = head;
            ListNode slowNode = head;
            Stack<int> nums = new Stack<int>();
            nums.Push(slowNode.val);
            while(true)
            {
                if (fastNode.next == null)
                {
                    nums.Pop();
                    break;
                }
                else if (fastNode.next.next == null)
                {
                    slowNode = slowNode.next;
                    break;
                }

                fastNode = fastNode.next.next;
                slowNode = slowNode.next;
                nums.Push(slowNode.val);
            }

            while (nums.Count > 0)
            {
                if (nums.Pop() != slowNode.val)
                {
                    return false;
                }

                slowNode = slowNode.next;
            }

            return true;
        }
    }
}
