struct ListNode
{
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

class Solution
{
public:
    ListNode *sortList(ListNode *head)
    {
        if(head == nullptr || head->next == nullptr) {
            return head;
        }

        ListNode* last = head;
        ListNode* fast = head;
        ListNode* slow = head;
        while (fast != nullptr && fast->next != nullptr)
        {
            last = slow;
            slow = slow->next;
            fast = fast->next;
            if(fast != nullptr) {
                fast = fast->next;
            }
        }

        last->next = nullptr;

        ListNode* left = sortList(head);
        ListNode* right = sortList(slow);
        
        ListNode* result = nullptr;
        ListNode* previous = nullptr;
        while(left != nullptr || right != nullptr) {
            if(result = nullptr) {
                if(left == nullptr) {
                    result = right;
                    right = right->next;
                } else if (right == nullptr) {
                    result = left;
                    left = left->next;
                } else if (left->val < right->val) {
                    result = left;
                    left = left->next;
                } else {
                    result = right;
                    right = right->next;
                }
                previous = result;
                continue;
            }


            if(left == nullptr) {
                previous->next = right;
                right = right->next;
            } else if (right == nullptr) {
                previous->next = left;
                left = left->next;
            } else if (left->val < right->val) {
                previous->next = left;
                left = left->next;
            } else {
                previous->next = right;
                right = right->next;
            }
            previous = previous->next;
        }
        return result;
    }
};