"""
27. Remove Element
https://leetcode.com/problems/remove-element/
"""

"""
Solution
Iterate backwards through the list, removing elements that match val
"""
class Solution(object):
    def removeElement(self, nums, val):
        """
        :type nums: List[int]
        :type val: int
        :rtype: int
        """

        matches = 0

        for i in range(len(nums)-1, -1, -1):
            if nums[i] == val:
                del nums[i]
                matches += 1

        return len(nums)