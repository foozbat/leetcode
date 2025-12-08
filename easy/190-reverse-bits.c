/**
 * 190. Reverse Bits
 * https://leetcode.com/problems/reverse-bits/
 */

/**
 * Solution
 * Foreach bit, extract the last bit, and add it to the left-shifted result, then right shift the input.
 */
int reverseBits(int n) {
    int result = 0;

    for (int i = 0; i < 32; i++) {
        int bit = n % 2;
        result = result * 2 + bit;
        n /= 2;
    }

    return result;
}