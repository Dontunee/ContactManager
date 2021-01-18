using System;
using Xunit;

namespace ContactManager.DataStructures.Test
{
    public class DoublyLinkedListTest
    {

        DoublyLinkedList<int> numbers = new DoublyLinkedList<int>();
        [Fact]
        public void AddHeadTest()
        {


            for (int i = 1; i <= 5; i++)
            {
                numbers.AddHead(i);
            }

            Assert.Equal("5", numbers.Head.nodeValue.ToString());

            Assert.Equal("1", numbers.Tail.nodeValue.ToString());
        }

        [Fact]
        public void AddTailTest()
        {
            for (int i = 1; i <= 5; i++)
            {
                numbers.AddTail(i);
            }
            Assert.Equal("1", numbers.Head.nodeValue.ToString());

            Assert.Equal("5", numbers.Tail.nodeValue.ToString());
        }

        [Fact]
        public void FindTest()
        {
            numbers.AddHead(1);
            numbers.AddHead(2);
            numbers.AddHead(3);
            numbers.AddHead(4);
            numbers.AddHead(4);
            var fourthNumber = numbers.Find(4);

            Assert.True(fourthNumber.nextNode.nodeValue == 4);
            Assert.True(fourthNumber != null);
        }

        [Fact]
        public void ContainsTest()
        {
            Assert.True(numbers.Contains(1) is false);
        }

        [Fact]
        public void RemoveTest()
        {
            numbers.AddHead(1);
            numbers.Remove(1);
            Assert.True(numbers.Head == null && numbers.Tail == null);
            numbers.AddHead(2);
            numbers.AddHead(3);
            numbers.AddHead(4);
            numbers.Remove(2);
            Assert.True(numbers.Head.nodeValue == 4);
            Assert.True(numbers.Tail.nodeValue == 3 );
            numbers.AddTail(5);
            numbers.Remove(4);
            Assert.True(numbers.Head.nextNode.nodeValue == 5);
        }
    }
}
