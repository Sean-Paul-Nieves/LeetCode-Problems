class Solution {
public:
    int accountBalanceAfterPurchase(int num) {
        int total;
        const int MONEY = 100;

        total = num % 10;

        if (total >= 5) {
            total = ceil(static_cast<double>(num)/10) * 10;
        } 
        else if (total < 5) {
            total = floor(static_cast<double>(num)/10) * 10;
        }

        return MONEY - total;
    }
};