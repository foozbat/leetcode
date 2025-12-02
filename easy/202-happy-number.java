/**
 * 202. Happy Number
 * https://leetcode.com/problems/happy-number/
 */

/**
 * Solution
 * Brute force calculate the sum of squares of digits, store previous numbers in a list and use to break the loop if found, returning false.
 */
class Solution {
    public boolean isHappy(int n) {
        List<Integer> previousNumbers = new ArrayList<>();

        while (true) {
            // calculate sum of all digits
            n = Math.abs(n);
            int sum = 0;
            while (n > 0) {
                int digit = n % 10;
                sum += digit * digit;
                n /= 10;
            }

            n = sum;

            if (n == 1) {
                return true;
            } else if (previousNumbers.contains(n)) {
                break;
            } else {
                n = sum;
                previousNumbers.add(n);
            }
        }

        return false;
    }
}