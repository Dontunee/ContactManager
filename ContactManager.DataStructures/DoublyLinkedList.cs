using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

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

       

        /// <summary>
        /// Adds a node value  to become the head of the list (Beginning of the list)
        /// </summary>
        /// <param name="value"></param>
        public void AddHead([NotNull] T value)
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

        /// <summary>
        /// Adds a node value  to become the Tail of the list (End of the list)
        /// </summary>
        /// <param name="value"></param>
        public void AddTail([NotNull] T value)
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


        /// <summary>
        /// Finds the first node with the value that matches the input value and returns the node
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public DoublyLinkedListNode<T> Find([NotNull] T value)
        {
            DoublyLinkedListNode<T> getCurrentHead = Head;

            while(getCurrentHead != null)
            {
                if(getCurrentHead.nodeValue.Equals(value))
                {
                    return getCurrentHead;
                }
                else
                {
                    getCurrentHead = getCurrentHead.nextNode;
                }
            }

            return null;
        }

        /// <summary>
        /// Checks if the NodeList contains a node with a value that matches the input value
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>

        public bool Contains([NotNull] T item)
        {
            return Find(item) != null;
        }


        /// <summary>
        /// Removes the first node with the value equal to the input value
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove([NotNull] T item)
        {
            DoublyLinkedListNode<T> findValue = Find(item);
            if (findValue is null)
            {
                return false;
            }
            else
            {
                var getNextNode = findValue.nextNode;
                var getPreviousNode = findValue.previousNode;

                if(getPreviousNode is null && getNextNode is null)
                {
                    //Only one value exists so remove and make list empty
                    Head = Tail = null;
                    return true;
                }
                else
                {
                    if (getPreviousNode is null)
                    {
                        //we are removing the head
                        //assign the next to become the head
                        Head = getNextNode;

                        if (Head != null)
                        {
                            //Ensure the previous is null since the next could have had a previous node
                            Head.previousNode = null;
                        }
                    }
                    else
                    {
                        //Previous isnt empty
                        //Set the next node to become the one after the current Node
                        //Set the previous node 
                        getPreviousNode.nextNode = getNextNode;
                        //getNextNode.previousNode = getPreviousNode;
                    }

                    if (getNextNode is null)
                    {
                        //We are removing the tail
                        //Set Tail to be the previous node
                        Tail = getPreviousNode;
                        if (Tail != null)
                        {
                            //Set the next to be null to make it last node
                            Tail.nextNode = null;
                        }
                    }
                    else
                    {
                        //Not removing the tail
                        //Set the previous node of the next node to be retrieved previous node
                        getNextNode.previousNode = getPreviousNode;
                    }

                    Count--;
                    return true;
                }
            }
           
        }

        /// <summary>
        /// Get Each value from the node list from the head
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            DoublyLinkedListNode<T> current = Head;
            while (current != null)
            {
                yield return current.nodeValue;
                current = current.nextNode;
            }
        }

        /// <summary>
        /// Enables compatibility with Icollection interfaces
        /// </summary>
        /// <returns></returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


        /// <summary>
        /// Get each value from the node list from the Tail backward
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetReverseEnumerator()
        {
            DoublyLinkedListNode<T> current = Tail;
            while (current != null)
            {
                yield return current.nodeValue;
                current = current.previousNode;
            }
        }


        public void Clear()
        {
            throw new NotImplementedException();
        }

        

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public void Add(T item)
        {
            throw new NotImplementedException();
        }
    }

}
