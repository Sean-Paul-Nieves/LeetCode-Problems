public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        
        string prefix = "";
        string based = strs[0];
        var newStrs = strs.Skip(1);

        for (int i = 0; i < strs[0].Length; i++) {
            foreach (string word in newStrs) {
                if (i == word.Length || word[i] != based[i]) {
                    return prefix;
                }
                // prefix += based[i];
            }
            prefix += based[i];
        }
    return prefix;
    }
}