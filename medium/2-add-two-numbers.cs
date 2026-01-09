/**
 * 2. Add Two Numbers
 * https://leetcode.com/problems/add-two-numbers/
 */

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

/**
 * Solution:
 * Use a dummy head to simplify list construction.
 * Iterate through both lists, adding corresponding digits along with any carry from the previous addition.
 * Create new nodes for each digit of the result and link them together.
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode head = new ListNode();
        ListNode curr = head;
        head.next = curr;

        int carry = 0;

        while (l1 != null || l2 != null || carry > 0)
        {
            int result = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            carry = result / 10;
            result %= 10;

            curr.next = new ListNode(result);
            curr = curr.next;

            l1 = l1?.next ?? null;
            l2 = l2?.next ?? null;
        }

        return head.next;
    }
}