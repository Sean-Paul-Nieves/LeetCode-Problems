/*
Name: Find the Original Typed String I
Link: https://leetcode.com/problems/find-the-original-typed-string-i/description/?envType=daily-question&envId=2025-07-01
Difficulty: Easy
*/

public class Solution {
    public int PossibleStringCount(string word) {
        int n = 0;

        List<char> letters = word.ToList();
        for (int i = 0; i < letters.Count - 1; i++) {
            if (letters[i] == letters[i+1])
                n++;
        }

        return n + 1;
    }
}