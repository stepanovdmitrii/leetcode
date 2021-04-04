
 struct TreeNode {
     int val;
     TreeNode *left;
     TreeNode *right;
     TreeNode() : val(0), left(nullptr), right(nullptr) {}
     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 };

#include <stack>

class Solution {
public:
    bool isSameTree(TreeNode* p, TreeNode* q) {
        if(p == nullptr && q == nullptr) return true;
        if(p == nullptr || q == nullptr) return false;
        
        std::stack<TreeNode*> fromLeft;
        std::stack<TreeNode*> fromRight;

        fromLeft.push(p);
        fromRight.push(q);

        while (fromLeft.size() > 0 && fromRight.size() > 0)
        {
            TreeNode* left = fromLeft.top();
            TreeNode* right = fromRight.top();
            fromLeft.pop();
            fromRight.pop();

            if(left == nullptr && right == nullptr) continue;
            if(left == nullptr || right == nullptr) return false;
            if(left->val != right->val) return false;
            
            fromLeft.push(left->left);
            fromLeft.push(left->right);

            fromRight.push(right->left);
            fromRight.push(right->right);
        }
        return fromLeft.size() == 0 && fromRight.size() == 0;
    }
};