using System;
using System.Collections;
using System.Collections.Generic;

namespace ContactManager.DataStructures
{
    /// <summary>
    /// Create a doubly linked NOde  with T value
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyLinkedListNode<T>
    {
        public DoublyLinkedListNode<T> previousNode;
        public DoublyLinkedListNode<T> nextNode;
        public T nodeValue { get; set; }
        public DoublyLinkedListNode(T nodeValue, DoublyLinkedListNode<T> previousNode, DoublyLinkedListNode<T> nextNode)
        {
            this.nodeValue = nodeValue;
            this.previousNode = previousNode;
            this.nextNode = nextNode;
        }
    }

    /// <summary>
    /// Create a list of Doubly linked Nodes with T as Node
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DoublyLinkedList<T> : ICollection<T>
    {

        /// <summary>
        /// The first node in the list or null if empty
        /// </summary>
        public DoublyLinkedListNode<T> Head
        {
            get;
            private set;
        }

        /// <summary>
        /// The last node in the list or null if empty
        /// </summary>
        public DoublyLinkedListNode<T> Tail
        {
            get;
            private set;
        }

        public int Count { get; set; }

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds a node value  to become the head of the list (Beginning of the list)
        /// </summary>
        /// <param name="value"></param>
        public void AddHead(T value)
        {
            //Create a new node with a null previousNode and the current Head as nextNode if it exists
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value, null, Head);
            if (Head != null)
            {
                Head.previousNode = newNode;
                Head = newNode;
            }
            else
            {
                if (Tail == null)
                {
                    Head = newNode;
                    Tail = Head;
                }
            }
            Count++;
        }

        public void AddTail(T value)
        {
            if (Tail == null)
            {
                AddHead(value);
            }
            else
            {
                DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value, Tail, null);

                Tail.nextNode = newNode;
                Tail = newNode;
                Count++;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
