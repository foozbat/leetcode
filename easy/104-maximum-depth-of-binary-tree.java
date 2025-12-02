/**
 * 104. Maximum Depth of Binary Tree
 * https://leetcode.com/problems/maximum-depth-of-binary-tree/
 */

/**
 * Definition for a binary tree node.
 **/
public class TreeNode {
    int val;
    TreeNode left;
    TreeNode right;
    TreeNode() {}
    TreeNode(int val) { this.val = val; }
    TreeNode(int val, TreeNode left, TreeNode right) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

/**
 * Solution
 * Use DFS to traverse the tree and calculate the depth.
 */
class Solution {
    public int maxDepth(TreeNode root) {
        return this.dfs(root, 0);
    }

    public int dfs(TreeNode node, int depth) {
        if (node == null) {
            return depth;
        }
        
        return Math.max(dfs(node.left, depth + 1), dfs(node.right, depth + 1));
    }
}