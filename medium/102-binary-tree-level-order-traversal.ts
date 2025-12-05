/**
 * 102. Binary Tree Level Order Traversal
 * https://leetcode.com/problems/binary-tree-level-order-traversal/
 */

/**
 * Definition for a binary tree node.
 */
class TreeNode {
    val: number
    left: TreeNode | null
    right: TreeNode | null
    constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
        this.val = (val===undefined ? 0 : val)
        this.left = (left===undefined ? null : left)
        this.right = (right===undefined ? null : right)
    }
}

/**
 * Solution
 * Use BFS to traverse the tree, store each level's values in the 2D return array.
 */
function levelOrder(root: TreeNode | null): number[][] {
    if (!root) return [];

    const queue: Array<TreeNode> = [root];
    const result: Array<number[]> = [];

    while (queue.length > 0) {
        let levelSize = queue.length;
        let sum = 0;

        let level: Array<number> = [];

        for (let i = 0; i < levelSize; i++) {
            const node: TreeNode = queue.shift()!;
            
            level.push(node.val);

            if (node.left) queue.push(node.left);
            if (node.right) queue.push(node.right);
        }

        result.push(level);
    }

    return result;
}