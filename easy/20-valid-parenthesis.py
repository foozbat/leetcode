"""
20. Valid Parentheses
https://leetcode.com/problems/valid-parentheses/
"""

"""
Solution
Use a stack to track opening parentheses, ensuring each closing parenthesis matches the most recent opening one.
"""
class Solution:
    def isValid(self, s: str) -> bool:
        open_parens = ['(', '[', '{']
        close_parens = [')', ']', '}']
        paren_stack = []

        for char in s:
            if char in open_parens:
                paren_stack.append(char)
                continue

            if char in close_parens and len(paren_stack) == 0:
                return False

            if char in close_parens:
                if (char == ')' and paren_stack[-1] == '(') or \
                    (char == ']' and paren_stack[-1] == '[') or \
                    (char == '}' and paren_stack[-1] == '{'):
                    paren_stack.pop()
                else:
                    return False
                    
        if len(paren_stack) > 0:
            return False

        return True