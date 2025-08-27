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
        
        foreach (var curr in counter) {
        int freq = curr.Value;
        // If the current index is a null, then we initialize a list in that index
        if (bucket[freq] == null) bucket[freq] = new List<int>();
        // We add the current key value to the index of frequency
        // For ex. If the number has a frequency of 4, it will be placed at index 4
        bucket[freq].Add(curr.Key);
        }
        // After FOREACH, bucket = {[ ], [ ], [3], [ ], [1,2], [ ], [ ], [ ], [ ], [ ], [ ]}
        //                index =    0    1    2    3     4     5    6    7    8    9    10

        // Create a list to be returned later
        List<int> result = new List<int>();

        // Start from the last index of the bucket list and the loop should stop if result becomes greater than input k
        for (int i = bucket.Length-1; i >= 0 && result.Count < k; i--) {
            // If the current index is not null, it means it has a value inside it, we use the AddRange to add all elements in that index
            if (bucket[i] != null) result.AddRange(bucket[i]);
        }

        return result.ToArray();
    }
}