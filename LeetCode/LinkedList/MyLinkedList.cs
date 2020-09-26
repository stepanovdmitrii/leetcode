namespace LeetCode.LinkedList
{
    public class MyLinkedList
    {
        private LinkedListNode<int> _head;
        private int _count = 0;

        public MyLinkedList()
        {
            _head = null;
        }

        /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
        public int Get(int index)
        {
            if (index >= _count) return -1;
            var node = _head;
            for(int i = 0; i < index; ++i)
            {
                node = node.Next;
            }
            return node.Value;
        }

        /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
        public void AddAtHead(int val)
        {
            var node = new LinkedListNode<int>();
            node.Value = val;
            node.Next = _head;
            if (_head != null)
            {
                _head.Previous = node;
            }
            _head = node;
            ++_count;
        }

        /** Append a node of value val to the last element of the linked list. */
        public void AddAtTail(int val)
        {
            if (_count == 0) {
                AddAtHead(val);
                return;
            }
            var prev = _head;
            while(prev.Next != null)
            {
                prev = prev.Next;
            }

            var node = new LinkedListNode<int>();
            node.Value = val;
            prev.Next = node;
            node.Previous = prev;
            ++_count;
        }

        /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
        public void AddAtIndex(int index, int val)
        {
            if (index > _count) return;

            if(index == _count)
            {
                AddAtTail(val);
                return;
            }

            if(index == 0)
            {
                AddAtHead(val);
                return;
            }

            var node = new LinkedListNode<int>();
            node.Value = val;

            int i = 0;
            var next = _head;

            while(i != index)
            {
                next = next.Next;
                ++i;
            }

            node.Previous = next.Previous;
            node.Next = next;
            next.Previous.Next = node;
            next.Previous = node;
            ++_count;
        }

        /** Delete the index-th node in the linked list, if the index is valid. */
        public void DeleteAtIndex(int index)
        {
            if (index >= _count) return;
            if (index == 0)
            {
                if (_head.Next != null) _head.Next.Previous = null;
                _head = _head.Next;
            }
            int i = 0;
            var node = _head;
            while (i != index)
            {
                node = node.Next;
                ++i;
            }
            if (node == null) return;
            if(node.Previous != null)
            {
                node.Previous.Next = node.Next;
            }
            if(node.Next != null)
            {
                node.Next.Previous = node.Previous;
            }
            --_count;
        }

        private sealed class LinkedListNode<T>
        {
            public T Value { get; set; }
            public LinkedListNode<T> Next { get; set; }
            public LinkedListNode<T> Previous { get; set; }
        }
    }
}
