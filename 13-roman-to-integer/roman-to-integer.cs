public class Solution {
    public int RomanToInt(string s) {
Dictionary<string, int> RomanNumerals = new Dictionary<string, int>
{
    { "I", 1 },
    { "V", 5 },
    { "X", 10 },
    { "L", 50 },
    { "C", 100 },
    { "D", 500 },
    { "M", 1000 }
};
        
    char[] Arr = new char[s.Length];
    int result = 0, j = 0; 
    foreach(char letter in s) {
        Arr[j++] = letter;
    }
    for (int i = 0; i < s.Length; i++) {
        if (Arr[i] == 'I' && i != s.Length - 1) {
            if (Arr[i+1] == 'V' || Arr[i+1] == 'X') {
                result -= 2;
            }
        }
        if (Arr[i] == 'X' && i != s.Length - 1) {
            if (Arr[i+1] == 'L' || Arr[i+1] == 'C') {
                result -= 20;
            }
        }
        if (Arr[i] == 'C' && i != s.Length - 1) {
            if (Arr[i+1] == 'D' || Arr[i+1] == 'M') {
                result -= 200;
            }
        }
        result += RomanNumerals[Arr[i].ToString()];
    }
    return result;
    }
}