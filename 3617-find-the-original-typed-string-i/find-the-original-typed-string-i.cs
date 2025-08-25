public class Solution {
    public int PossibleStringCount(string word) {
        
        int n = 0;

        List<char> letters = word.ToList();
        for (int i = 0; i < letters.Count - 1; i++) {
            if (letters[i] == letters[i+1]) 
                n++;
        }

        return n + 1;
    }
}

//(45ms Runtime, O(n))
// public class Solution {
//     public int PossibleStringCount(string word) {
        
//         int n = 0;

//         for (int i = 0; i < word.Length - 1; i++) {
//             if (word[i] == word[i+1]) 
//                 n++; 
//         }

//         return n + 1;
//     }
// }