// Test Case [1,2,1,2,1,2,3,1,3,2] to use for line per line guide

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        
        // Takes the length of the argument array nums
        int n = nums.Length;

        // Create a dictionary with key(the element) and value(the frequency)
        Dictionary<int,int> counter = new Dictionary<int, int>();
        
        foreach (var num in nums) {
            // if the number is already present in the dict, we just increase its value, otherwise, add it to the dict and assign 1 as value
            if (counter.ContainsKey(num)) counter[num]++;
            else counter[num] = 1;
        }
        // After FOREACH, counter = {1:4, 2:4, 3:2}

        //Create a list bucket for sorting
        List<int>[] bucket = new List<int>[n + 1];
        
        //
        foreach (var curr in counter) {
        int freq = curr.Value;
        if (bucket[freq] == null) bucket[freq] = new List<int>();
        bucket[freq].Add(curr.Key);
        }
        // bucket = {[], [], [3], [], [1,2], [], [], [], [], []}

        List<int> result = new List<int>();

        for (int i = bucket.Length-1; i >= 0 && result.Count < k; i--) {
            if (bucket[i] != null) result.AddRange(bucket[i]);
        }

        return result.ToArray();
    }
}