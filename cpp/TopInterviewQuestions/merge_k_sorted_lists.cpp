#include <vector>
#include <queue>

using namespace std;

struct ListNode
{
    int val;
    ListNode *next;
    ListNode() : val(0), next(nullptr) {}
    ListNode(int x) : val(x), next(nullptr) {}
    ListNode(int x, ListNode *next) : val(x), next(next) {}
};

struct QueueNode
{
    int value;
    size_t index;
};

class Solution
{
public:
    ListNode *mergeKLists(vector<ListNode *> &lists)
    {
        auto comp = [](const QueueNode lhs, const QueueNode rhs)
        {
            if (lhs.value == rhs.value)
            {
                return lhs.index < rhs.index;
            }
            return lhs.value < rhs.value;
        };
        priority_queue<QueueNode, vector<QueueNode>, decltype(comp)> queue(comp);
        for (size_t idx = 0; idx < lists.size(); ++idx)
        {
            if (lists[idx] != nullptr)
            {
                QueueNode qn;
                qn.index = idx;
                qn.value = lists[idx]->val;
                queue.push(qn);
                lists[idx] = lists[idx]->next;
            }
        }

        ListNode *head = nullptr;
        ListNode *last = nullptr;
        while (queue.size() > 0)
        {
            QueueNode qn = queue.top();
            queue.pop();

            if (head == nullptr)
            {
                head = new ListNode(qn.value);
                last = head;
            }
            else
            {
                last->next = new ListNode(qn.value);
                last = last->next;
            }

            if (lists[qn.index] != nullptr)
            {
                QueueNode qn_next;
                qn_next.index = qn.index;
                qn_next.value = lists[qn.index]->val;
                queue.push(qn_next);
                lists[qn.index] = lists[qn.index]->next;
            }
        }
        return head;
    }
};