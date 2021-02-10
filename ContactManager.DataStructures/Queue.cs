using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManager.DataStructures
{
    public class Queue<T>
    {
        readonly Deque<T> store = new Deque<T>();

        
        public void Enqueue(T value)
        {
            //Add to the tail which makes the first one accessible from the head
            store.EnqueueTail(value);
        }

        public void Dequeue()
        {
            store.DequeueHead();
        }

        public T Peek()
        {
            T value;
            if (store.PeekHead(out value))
            {
                return value;
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public int Count
        {
            get
            {
                return store.Count;
            }
        }
    }
}
