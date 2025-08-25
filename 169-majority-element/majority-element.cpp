class Solution {
public:
    int majorityElement(vector<int>& nums) {
        
        map<int,int> freq;

        for (int num : nums) {
            freq[num]++;
        }
        pair<int,int> maxFreq = {INT_MIN, INT_MIN};
        for (auto item : freq) {
            if (maxFreq.second < item.second) {
                maxFreq = {item.first, item.second};
            }
        }
        return maxFreq.first;
    }
};