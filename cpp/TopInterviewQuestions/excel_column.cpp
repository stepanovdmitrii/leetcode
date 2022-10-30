#include <string>

using namespace std;

class Solution
{
public:
    int titleToNumber(string columnTitle)
    {
        const int base = 26;
        int power = 1;
        int result = 0;

        for (auto it = columnTitle.rbegin(); it != columnTitle.rend(); ++it)
        {
            int value = (*it - 'A' + 1);

            result += value * power;

            if (power < 308915776)
            {
                power *= base;
            }
        }

        return result;
    }
};