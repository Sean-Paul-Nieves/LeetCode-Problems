public class Solution {
    public int StrStr(string haystack, string needle) {
        // Initialization of variables
        int haystack_length = haystack.Length; int needle_length = needle.Length; 
        string current_window;

        // If the needle is already longer than the haystack, we return -1 since needle would never occur in haystack in this situation
        if (needle_length > haystack_length) return -1;

        // If the needle and haystack are already equal, we just return 0 since it occured on the first index
        if (needle == haystack) return 0;
        
        // Used for-loop to implement sliding window algorithm
        for (int i = 0; i <= haystack_length - needle_length; i++) {
            // At the current iteration, we get the substring of the haystack by using the i and the length of the needle
            current_window = haystack.Substring(i, needle_length);

            // if the current window and the needle matches, we return the current index of where it first occured 
            if (current_window == needle) return i;
        }
        return -1;
    }
}