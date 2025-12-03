"""
1. Two Sum
https://leetcode.com/problems/two-sum/
"""

"""
Solution
Use a dictionary to store previously seen numbers and their indices.
"""
from typing import List

class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        past_nums = {}
        
        for i in range(len(nums)):
            complement = target - nums[i]

            index = past_nums.get(complement)

            if index is not None:
                return [i, index]
            else:
                past_nums[nums[i]] = i
        
        return []