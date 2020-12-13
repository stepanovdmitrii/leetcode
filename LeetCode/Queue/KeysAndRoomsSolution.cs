using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode.Queue
{
    public sealed class KeysAndRoomsSolution
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            if (rooms.Count <= 1) return true;

            var opened = new HashSet<int>();
            var buffer = new Queue<int>();
            buffer.Enqueue(0);

            while(buffer.Count > 0)
            {
                var room = buffer.Dequeue();
                opened.Add(room);
                if(opened.Count == rooms.Count)
                {
                    return true;
                }
                foreach(var key in rooms[room])
                {
                    if (!opened.Contains(key))
                    {
                        buffer.Enqueue(key);
                    }
                }
            }

            return false;
        }
    }
}
