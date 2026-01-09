/**
 * 56. Merge Intervals
 * https://leetcode.com/problems/merge-intervals/
 */

/**
 * Solution:
 * Sort the intervals based on the start time.
 * Iterate through the sorted intervals and merge overlapping intervals.
 * i.e. if the start of the current interval is less than or equal to the end of the last merged interval
 */
public class Solution {
    public int[][] Merge(int[][] intervals) {
        List<int[]> ret = new List<int[]>();
        int retIdx = 0;

        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));

        ret.Add(intervals[0]);

        for (int i = 1; i < intervals.Length; i++)
        {
            if (intervals[i][0] <= ret[retIdx][1])
            {
                ret[retIdx][1] = Math.Max(intervals[i][1], ret[retIdx][1]);
            }
            else
            {
                ret.Add(intervals[i]);
                retIdx++;
            }
        }

        return ret.ToArray();
    }
}