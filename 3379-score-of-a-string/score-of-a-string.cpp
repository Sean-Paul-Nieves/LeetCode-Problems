class Solution {
public:
    int scoreOfString(string s) {
        int sum = 0;

        for (int i = 0; i <= s.length() - 1; i++) {
            if (i < s.length() - 1) {
            sum += abs(s[i] - s[i+1]);
            }
        }
        return sum;
    }
};