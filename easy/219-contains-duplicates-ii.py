"""
219. Contains Duplicate II
https://leetcode.com/problems/contains-duplicate-ii/
"""

"""
Solution
Use a dictionary to store the last index of each number seen. For each number, check if it has been seen before check abs(i - j) <= k.
"""
class Solution:
    def containsNearbyDuplicate(self, nums: List[int], k: int) -> bool:
        previous_nums = {}

        for i in range(0, len(nums)):
            if (nums[i] in previous_nums):
                if abs(i - previous_nums[nums[i]]) <= k:
                    return True

            previous_nums[nums[i]] = i
        
        return False