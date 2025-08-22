public class Solution {
    public bool IsValid(string s) {
        
        //Used a stack for this problem
        Stack<char> stack = new Stack<char>();

        foreach (char c in s) {
            if (c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            }
            else {
                if (stack.Count == 0) return false;
                var opening = stack.Pop();
                if (opening == '(' && c != ')' || 
                    opening == '[' && c != ']' || 
                    opening == '{' && c != '}') {
                        return false;
                    }     
            }
        }
        if (stack.Count > 0) {
                return false;
            }
        return true;
    }
}