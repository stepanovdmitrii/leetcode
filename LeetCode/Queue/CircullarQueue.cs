namespace LeetCode.Queue
{
    public class MyCircularQueue
    {
        private readonly int[] _data;
        private int _head;
        private int _tail;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            _data = new int[k];
            _head = _tail = -1;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull()) return false;
            _tail = (_tail + 1) % _data.Length;
            _head = _head == -1 ? 0 : _head;
            _data[_tail] = value;
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty()) return false;
            bool last = _head == _tail;
            if (last)
            {
                _head = _tail = -1;
            }
            else
            {
                _head = (_head + 1) % _data.Length;
            }
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (IsEmpty()) return -1;
            return _data[_head];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (IsEmpty()) return -1;
            return _data[_tail];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return _head == -1 && _tail == -1;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return (_tail + 1) % _data.Length == _head; 
        }
    }
}
