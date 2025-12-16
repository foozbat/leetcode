/**
 * 167. Two Sum II - Input Array Is Sorted
 * https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
 */

 /**
  * Solution
  * Use two pointers to find the sum.
  * If the sum is smaller than the target, move the left pointer to the right
  * If the sum is larger than the target, move the right pointer to the left.
  */
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i = 0;
        int j = numbers.Length - 1;

        while (i < j)
        {
            int sum = numbers[i] + numbers[j];

            if (sum == target)
            {
                break;
            }
            else if (sum < target)
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        return [i+1, j+1];
    }
}  
