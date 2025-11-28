/**
 * 1448. Count Good Nodes in Binary Tree
 * https://leetcode.com/problems/count-good-nodes-in-binary-tree/
 */

/**
 * Solution:
 * Use Depth-First Search (recursive) to traverse the binary tree.
 * Keep track of the maximum value encountered from root to the current node.
 * Count the good nodes in the left and right subtrees, updating the maximum value as needed.
 * Return the total count of good nodes.
 */

function goodNodes(root: TreeNode | null): number {
    if (!root) return 0;

    return dfs(root, root.val);
};

function dfs(node: TreeNode | null, largest: number): number {
    if (!node) return 0;

    let good = node.val >= largest ? 1 : 0;
    largest = node.val > largest ? node.val : largest;

    return good + dfs(node.left, largest) + dfs(node.right, largest);
}