#include <iostream>

class Solution {
public:
    int divide(int dividend, int divisor) {
        int sign = dividend > 0 == divisor > 0 ? 1 : -1;
        int add = 0;
        if(dividend == -2147483648) {
            if(divisor == -1) return 2147483647;
            if(divisor == 1) return -2147483648;
            if(divisor == -2147483648) return 1;
            dividend += abs(divisor);
            add = 1;
        }

        if(divisor == -2147483648) {
            return 0;
        }

        dividend = dividend > 0 ? dividend : -dividend;
        divisor = divisor > 0 ? divisor : -divisor;

        if(dividend == divisor) {
            return sign;
        }

        if(dividend < divisor) {
            if(sign > 0) {
                return add;
            }
            return -add;
        }
        
        int max_shift = 1;
        int max = 1 << 30;
        while((max & divisor) == 0) {
            divisor = divisor << 1;
            ++max_shift;
        }

        int quotient = 0;
        while (max_shift > 0)
        {
            if(dividend >= divisor) {
                dividend = dividend - divisor;
                quotient = quotient << 1;
                quotient += 1;
            } else {
                quotient = quotient << 1;
            }
            divisor = divisor >> 1;
            --max_shift;
        }
        
        quotient += add;
        if(sign > 0) {
            return quotient;
        }
        return -quotient;
    }
};

int main()
{
    Solution s;
    std::cout << s.divide(-2147483648,-1109186033) << std::endl;
}