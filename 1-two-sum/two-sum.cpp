class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        //Creating unordered map
        unordered_map<int,int> complement;
        //Outer loop
        for (int i=0; i < nums.size(); i++) {
            //Getting the complement
            int x = target - nums[i];
            if (complement.contains(x)) {
                return {i, complement[x]};
            }
            complement[nums[i]] = i;
        }
        return {};
    }
};