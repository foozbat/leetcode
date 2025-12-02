/**
 * 100. Same Tree
 * https://leetcode.com/problems/same-tree/
 */

/**
 * Definition for a binary tree node.
 */
function TreeNode(val, left, right) {
   this.val = (val===undefined ? 0 : val)
   this.left = (left===undefined ? null : left)
   this.right = (right===undefined ? null : right)
}

/**
 * Solution
 * Use DFS to compare each node in both trees.
 */
/**
 * @param {TreeNode} p
 * @param {TreeNode} q
 * @return {boolean}
 */
var isSameTree = function(p, q) {
    // if both pointers are null, this branch matches
    if (p === null && q === null) {
        return true;
    }

    // if either pointer is null, this can't be a match
    if (p === null || q === null) {
        return false;
    }

    // if values don't match, this can't be a match
    if (p.val !== q.val) {
        return false;
    }

    return isSameTree(p.left, q.left) && isSameTree(p.right, q.right);
};