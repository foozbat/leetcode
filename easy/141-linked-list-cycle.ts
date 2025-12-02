/**
 * 141. Linked List Cycle
 * https://leetcode.com/problems/linked-list-cycle/
 */

/**
 * Definition for singly-linked list.
 */
class ListNode {
   val: number
   next: ListNode | null
   constructor(val?: number, next?: ListNode | null) {
       this.val = (val===undefined ? 0 : val)
       this.next = (next===undefined ? null : next)
   }
}

/**
 * Solution 1: Use an array to track previously seen nodes
 */
function hasCycle(head: ListNode | null): boolean {
    if (head === null) {
        return false;
    }

    let previousNodes: Array<ListNode> = [];

    while (head.next !== null) {
        if (previousNodes.includes(head.next)) {
            return true;
        } else {
            previousNodes.push(head);
            head = head.next;
        }
    }

    return false;
};

/**
 * Solution 2: Floyd's Tortoise and Hare Algorithm
 */
function hasCycle2(head: ListNode | null): boolean {
    if (head === null) {
        return false;
    }

    let slow: ListNode | null = head;
    let fast: ListNode | null = head;

    while (fast !== null && fast.next !== null) {
        slow = slow!.next;
        fast = fast.next.next;

        if (slow === fast) {
            return true;
        }
    }

    return false;
};