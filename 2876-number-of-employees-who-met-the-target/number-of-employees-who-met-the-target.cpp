class Solution {
public:
    int numberOfEmployeesWhoMetTarget(vector<int>& hours, int target) {
        
        int employees = 0; 

        for (auto worker : hours) {
            if (worker >= target) {
                employees++;
            }
        }
        return employees;
    }
};