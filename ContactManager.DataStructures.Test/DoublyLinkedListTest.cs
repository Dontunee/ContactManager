using System;
using Xunit;

namespace ContactManager.DataStructures.Test
{
    public class DoublyLinkedListTest
    {
        [Fact]
        public void AddHeadTest()
        {
            DoublyLinkedList<int> numbers = new DoublyLinkedList<int>();
            for (int i = 1; i <=5; i++)
            {
                numbers.AddHead(i);
            }

            Assert.Equal("5", numbers.Head.nodeValue.ToString());

            Assert.Equal("1", numbers.Tail.nodeValue.ToString());
        }

        [Fact]
        public void AddTailTest()
        {
            DoublyLinkedList<int> numbers = new DoublyLinkedList<int>();
            for (int i = 1; i <= 5; i++)
            {
                numbers.AddTail(i);
            }

            Assert.Equal("1", numbers.Head.nodeValue.ToString());

            Assert.Equal("5", numbers.Tail.nodeValue.ToString());
        }
    }
}
