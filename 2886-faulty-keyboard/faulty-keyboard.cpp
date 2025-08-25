class Solution {
public:
    string finalString(string s) {
        string word = "";

        for (auto c : s) {
            if (c == 'i') {
                reverse(word.begin(), word.end());
            }
            else {
                word += c;
            }
        }
        return word;
    }
};