class Solution {
public:
    bool arrayStringsAreEqual(vector<string>& word1, vector<string>& word2) {
        
        string s1 = "", s2 = "";

        for (auto letter : word1) {
            s1 += letter;
        }

        for (auto letter : word2) {
            s2 += letter;
        }

        return s1.compare(s2) == 0;
    }
};