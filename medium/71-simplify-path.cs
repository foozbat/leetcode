/**
 * 71. Simplify Path
 * https://leetcode.com/problems/simplify-path/
 */

/**
 * Solution:
 * Split the path by '/' and use a stack to process each part.
 * Ignore '.' and pop the stack for '..'. Push valid directory names onto the stack.
 * Finally, join the stack contents to form the simplified path.
 */
public class Solution {
    public string SimplifyPath(string path) {
        var parts = path.Split('/', StringSplitOptions.RemoveEmptyEntries);
        var dirs = new Stack<string>();

        foreach (var part in parts) {
            if (part == ".")
            {
                continue;
            }
            else if (part == "..")
            {
                if (dirs.Count > 0)
                {
                    dirs.Pop();
                }
            }
            else
            {
                dirs.Push(part);
            }
        }

        return "/" + String.Join('/', dirs.Reverse());
    }
}