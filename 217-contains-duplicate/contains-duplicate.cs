public class Solution {
    public bool ContainsDuplicate(int[] nums) {

        Hashtable ht = new Hashtable();
        int n = 0;
        foreach (int num in nums) {
            if (ht.ContainsKey(num)) {
                return true;
            }
            else {
                ht.Add(num, true);
            }
        }
        return false;
    }
}