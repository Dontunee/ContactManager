//using System;
//using System.Collections.Generic;
//using System.Text;
//using Xunit;

//namespace ContactManager.DataStructures.Test
//{
//    public class SortedListTest
//    {
//        SortedList<int> newSortedList = new SortedList<int>();
        
     

//        [Fact]
//        public void AddTest()
//        {
//            newSortedList.Add(7);
//            newSortedList.Add(8);
//            newSortedList.Add(1);
//            newSortedList.Add(3);
//            Assert.Equal("1", newSortedList.Head.value.ToString());
//            Assert.Equal("3", newSortedList.Head.nextNode.value.ToString());
//            Assert.Equal("8", newSortedList.Tail.value.ToString());
//            Assert.Null(newSortedList.Head.previousNode);
//            Assert.Null(newSortedList.Tail.nextNode);
//        }

//        [Fact]
//        public void FindTest()
//        {
//            newSortedList.Add(7);
//            newSortedList.Add(8);
//            newSortedList.Add(1);
//            newSortedList.Add(3);
//            var sortedNode = new SortedListNode<int>(1,null,null);
//            newSortedList.Find(3, out sortedNode);

//            Assert.True(sortedNode.nextNode.value.Equals(7));

//        }

//        [Fact]
//        public void RemoveTest()
//        {
//            newSortedList.Add(7);
//            newSortedList.Add(8);
//            newSortedList.Add(1);
//            newSortedList.Add(3);
//            var sortedNode = new SortedListNode<int>(1, null, null);
//            newSortedList.Remove(3);

//            Assert.False(newSortedList.Find(3, out sortedNode));
//        }
//    }
//}
