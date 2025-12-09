"""
530. Minimum Absolute Difference in BST
https://leetcode.com/problems/minimum-absolute-difference-in-bst/
"""

# Definition for a binary tree node.
class TreeNode(object):
    def __init__(self, val=0, left=None, right=None):
        self.val = val
        self.left = left
        self.right = right
"""
Solution
Use in-order traversal to compute min difference between adjacent nodes
"""
class Solution(object):
    def getMinimumDifference(self, root):
        self.prev = None
        self.minVal = float('inf')
        self.inOrderBST(root)
        return self.minVal

    def inOrderBST(self, node):
        if not node:
            return

        self.inOrderBST(node.left)

        if self.prev is not None:
            self.minVal = min(self.minVal, node.val - self.prev)

        self.prev = node.val

        self.inOrderBST(node.right)
