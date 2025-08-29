public class Solution {
    public int SearchInsert(int[] nums, int target) {
        
        int start = 0; 
        int end = nums.Length - 1; 
        int middle = 0;

        while (start <= end) {
            middle = (start + end) / 2; 
            if (nums[middle] == target) return middle;
            else if (nums[middle] < target) {
                start = middle + 1;
            }
            else if (nums[middle] > target) { 
                end = middle - 1;
            } 
        }
        return start;
    }
}