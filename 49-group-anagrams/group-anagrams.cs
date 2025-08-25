public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        
        // Initialize a Dict with string as a key, and IList as its values
        Dictionary<string, IList<string>> map = new Dictionary<string, IList<string>>();

        // Reiterate each word inside the strs array
        foreach (var word in strs) {
            // Create an array that will hold all possible letter frequencies (a-z)
            int[] freq = new int[26];
            foreach (var letters in word) {
                // A letter is incremented to count its frequency
                freq[letters - 'a']++;
            }

            // Turn the array from the previous foreach loop into a string to serve as key
            string key = string.Join("#", freq);

            // If the current key or frequencies of letters is not currently in the Dict, we initialize a List with the variable key, as the key
            if (!map.ContainsKey(key)) {
                map[key] = new List<string>();
            }

            // If the frequencies of letters is inside the map, we just add the current word to the List.
            map[key].Add(word);
        }
        return new List<IList<string>>(map.Values);
    }
}