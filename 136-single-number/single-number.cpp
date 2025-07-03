class Solution {
public:
    int singleNumber(vector<int>& nums) {
        
        int res = 0;
        map <int, int> freq;
        
        for (auto num : nums) {
            freq[num]++;
        }
        
        
        for (auto num : freq) {
            if (num.second == 1) {
                res = num.first;
            }
        }
        return res;
    }
};