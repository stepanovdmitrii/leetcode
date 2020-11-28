namespace LeetCode.LinkedList
{
    class SwapNodesInPairsSolution
    {
        public ListNode SwapPairs(ListNode head)
        {
            return Swap(head, head?.next);
        }

        private static ListNode Swap(ListNode left, ListNode right)
        {
            if (left == null) return null;
            if (right == null) return left;

            left.next = Swap(right.next, right.next?.next);
            right.next = left;
            return right;
        }
    }
}
