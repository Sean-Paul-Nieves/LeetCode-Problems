public class Solution {
    public bool IsAnagram(string s, string t) {
        
       Dictionary<char, int> anagram = new Dictionary<char, int>();

       foreach (var character in s) {
            if (!anagram.ContainsKey(character)) {
                anagram[character] = 1;
            }
            else {
                anagram[character]++; 
            }
        }

        foreach (var character in t) {
            if (anagram.ContainsKey(character)) {
                anagram[character]--;
                if (anagram[character] == 0) anagram.Remove(character);
            }
            else {
                return false;
            }
       }

       if (anagram.Count != 0) return false;
       return true;
    }
}