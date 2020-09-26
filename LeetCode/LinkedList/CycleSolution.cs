namespace LeetCode.LinkedList
{
    class CycleSolution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null) return false;
            ListNode slow = head;
            ListNode fast = head.next;
            while(fast.next != null && fast.next.next != null)
            {
                if (ReferenceEquals(slow, fast))
                    return true;

                slow = slow.next;
                fast = fast.next.next;
            }
            return false;
        }

        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null) return null;
            ListNode slow = head;
            ListNode fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;

                if (ReferenceEquals(slow, fast))
                {
                    fast = head;
                    while (!ReferenceEquals(fast, slow))
                    {
                        fast = fast.next;
                        slow = slow.next;
                    }
                    return fast;
                }
            }
            return null;

        }

        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {

        }
    }
}
