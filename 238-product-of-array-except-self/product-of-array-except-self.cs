public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        
        // Test Case to use is [1,2,3,4]
        int n = nums.Length;
        int i;
        int[] answer = new int[n];

        // First Part: Prefix
        answer[0] = 1;
        for (i = 1; i < n; i++) {
            answer[i] = answer[i-1] * nums[i-1];
            /*
            answer[0] = 1 
            -- FOR-LOOP enters --
            answer[1] = answer[0](1) * nums[0](1) = 1 
            answer[2] = answer[1](1) * nums[1](2) = 2 
            answer[3] = answer[2](2) * nums[2](3) = 6

            Current Array: [1,1,2,6] 
            */
        }

        // Second Part: Suffix
        // We are accessing the array backwards, so [6,2,1,1]
        int suffix = 1;
        for (i = n - 1; i >= 0; i--) {
            answer[i] *= suffix;
            suffix *= nums[i];
            /*
            Backwards Perspective
            First Iteration: [6,2,1,1] Suffix = 4
            Second Iteration: [6,8,1,1] Suffix = 12
            Third Iteration: [6,8,12,1] Suffix = 24
            Fourth Iteration: [6,8,12,24] Suffix = 24
            */
        }
       
        return answer;
    }
}