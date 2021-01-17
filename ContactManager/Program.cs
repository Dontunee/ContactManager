using ContactManager.DataStructures;
using System;

namespace ContactManager
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<int> numbers = new DoublyLinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                numbers.AddHead(i);
            }

            Console.WriteLine(numbers.Head.ToString());
        }
    }
}
