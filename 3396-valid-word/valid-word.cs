using System.Text.RegularExpressions;
public class Solution {
    public bool IsValid(string word) {
        string regex = @"^(?=.*[aeiouAEIOU])(?=.*[b-df-hj-np-tv-zB-DF-HJ-NP-TV-Z])[a-zA-Z0-9]{3,}$";
        Regex rg = new Regex(regex);
        if (rg.IsMatch(word))
            return true;
        return false;
    }
}