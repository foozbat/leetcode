/**
 * 394. Decode String
 * https://leetcode.com/problems/decode-string/
 */

/**
 * Solution: 
 * Use two stacks to store the multipliers and the strings.
 * When encountering a '[', push the current multiplier and string onto their respective stacks and reset them.
 * When encountering a ']', pop from both stacks to get the last multiplier and string, and append the multiplied string to currentString.
 */
public class Solution
{
    public string DecodeString(string s)
    {
        var k = new Stack<int>();
        var strings = new Stack<string>();
        string currentString = "";
        string currentMultiplier = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsDigit(s[i]))
            {
                currentMultiplier += s[i];
            }
            else if (s[i] == '[')
            {
                k.Push(int.Parse(currentMultiplier));
                strings.Push(currentString);
                currentString = "";
                currentMultiplier = "";
            }
            else if (s[i] == ']')
            {
                string previousString = strings.Pop();
                currentString = previousString + string.Concat(Enumerable.Repeat(currentString, k.Pop()));
            }
            else
            {
                currentString += s[i];
            }
        }

        return currentString;
    }
}