class Solution {
    public boolean isArraySpecial(int[] nums) {
        
        if (nums.length == 1) {
            return true;
        }
        
        for (int i = 0; i < nums.length - 1; i++) {
            
            if (nums[i] % 2 == 0 && nums[i+1] % 2 == 0) { // If both num is even
                    return false;
                }
            
            else if (nums[i] % 2 != 0 && nums[i+1] % 2 != 0) { // If both num is odd
                    return false;
            }
        }
        
        return true;
        
        }
    }