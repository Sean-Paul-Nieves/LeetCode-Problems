#include <algorithm>

class Solution {
public:
    bool isPalindrome(int x) {
        
        string original = to_string(x);
        string reversed = original;
        
        reverse(reversed.begin(), reversed.end());
        
        for (int i = 0; i < original.length(); i++) {
            
            if (reversed[i] != original[i]) {
                return false;
            }
        }
        return true;
    }
};