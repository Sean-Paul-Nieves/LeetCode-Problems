class Solution {
public:
    vector<string> splitWordsBySeparator(vector<string>& words, char separator) {

        string str = "";
        string temp = "";

        for (auto word : words) {
            str += word + separator;
        }
        vector <string> result;

       for (char c : str) {
            if (c == separator) {
                if (!temp.empty()) {
                result.push_back(temp);
                temp = "";
                }
            }
            else {
                temp += c;
            }
       }
        return result;
    }
};