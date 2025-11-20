/*
    383. Ransom Note

    Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

    Each letter in magazine can only be used once in ransomNote.

    Example 1:
        Input: ransomNote = "a", magazine = "b"
        Output: false

    Example 2:
        Input: ransomNote = "aa", magazine = "ab"
        Output: false

    Example 3:
        Input: ransomNote = "aa", magazine = "aab"
        Output: true

    Constraints:
        1 <= ransomNote.length, magazine.length <= 105
        ransomNote and magazine consist of lowercase English letters.
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