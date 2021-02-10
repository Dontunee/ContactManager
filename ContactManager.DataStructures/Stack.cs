using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManager.DataStructures
{
    public class Stack<T> 
    {
        readonly Deque<T> store = new Deque<T>();

        public void Push(T value)
        {
            store.EnqueueHead(value);
        }

        public T Pop()
        {
            T value;
            if (store.PeekTail(out value))
            {
                return store.DequeueHead();
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public T Peek()
        {
            T value;
            if(store.PeekHead(out value))
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
