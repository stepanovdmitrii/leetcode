#include <vector>
#include <string>
#include <stack>

using namespace std;

struct Holder {
    string str;
    int opened;
    int closed;
};

class Solution {
public:
    vector<string> generateParenthesis(int n) {
        Holder init{"", 0};
        vector<Holder> stack;
        stack.push_back(init);
        vector<Holder> next;
        for(int i = 0; i < 2*n; ++i){
            while (stack.size() > 0)
            {
                Holder current = stack[stack.size() - 1];
                stack.pop_back();

                if(current.opened < n) {
                    next.push_back({current.str + "(", current.opened + 1, current.closed});
                }

                if(current.opened - current.closed > 0) {
                    next.push_back({current.str + ")", current.opened, current.closed + 1});
                }
            }
            stack = move(next);
        }
        vector<string> res;
        res.reserve(stack.size());
        for(const Holder& h : stack) {
            if(h.str != "") {
                res.push_back(h.str);
            }
        }
        return res;
    }
};