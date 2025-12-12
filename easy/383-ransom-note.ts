/**
 * 383. Ransom Note
 * https://leetcode.com/problems/ransom-note/
 */

/**
 * Solution
 * Count each occurance of each letter in magazine, then check if ransomNote can be constructed from magazine
 * by decrementing the count for each letter in ransomNote.
 * If any letter count goes below zero, return false. Otherwise, return true.
 */
function canConstruct(ransomNote: string, magazine: string): boolean {
    interface HashMap {
        [key: string]: number;
    }

    const matches: HashMap = {};

    // count each occurance of each letter in magazine
    for (let i=0; i<magazine.length; i++) {
        matches[magazine[i]] = (matches[magazine[i]] || 0) + 1;
    }

    // check if ransomNote can be constructed from magazine
    for (let i=0; i<ransomNote.length; i++) {
        if (!(ransomNote[i] in matches)) {
            return false;
        }

        // decrement and return false if we run out of that letter
        if (--matches[ransomNote[i]] < 0) {
           return false;
        }
    }

    return true;
};