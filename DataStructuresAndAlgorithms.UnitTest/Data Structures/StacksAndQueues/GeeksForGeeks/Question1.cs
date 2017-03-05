using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.GeeksForGeeks;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.StacksAndQueues.GeeksForGeeks
{
    [TestClass]
    public class Question1
    {
        [TestMethod]
        public void InsertIntoSortedList_EmptyLinkedList_InsertAtHead()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.InsertIntoSortedList(1);
            Assert.IsTrue(linkedList.Length == 1);
            Assert.IsTrue(linkedList.Head.Data == 1);
        }

        [TestMethod]
        public void InsertIntoSortedList_NewDataLessThanHead_InsertAtHead()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(2);
            linkedList.InsertIntoSortedList(1);
            Assert.IsTrue(linkedList.Length == 2);
            Assert.IsTrue(linkedList.Head.Data == 1);
        }

        [TestMethod]
        public void InsertIntoSortedList_NewDataGreaterThanHead_InsertAtTail()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(1);
            linkedList.InsertIntoSortedList(2);
            Assert.IsTrue(linkedList.Length == 2);
            Assert.IsTrue(linkedList.Head.Data == 1);
            Assert.IsTrue(linkedList.Head.Next.Data == 2);
        } 

        [TestMethod]
        public void InsertIntoSortedList_NewDataInTheMiddle_InsertedElementInTheMiddle()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AppendToTail(1);
            linkedList.AppendToTail(2);
            linkedList.AppendToTail(4);
            linkedList.AppendToTail(5);
            linkedList.InsertIntoSortedList(3);
            Assert.IsTrue(linkedList.Length == 5);
            Assert.IsTrue(linkedList.Head.Next.Next.Data == 3);
        }

        [TestMethod]
        public void InsertIntoSortedList_LargestElementInTheList_InsertedElementAtTail()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AppendToTail(1);
            linkedList.AppendToTail(2);
            linkedList.AppendToTail(3);
            linkedList.AppendToTail(4);
            linkedList.InsertIntoSortedList(5);
            Assert.IsTrue(linkedList.Length == 5);
            Assert.IsTrue(linkedList.Head.Next.Next.Next.Next.Data == 5);
        }
    }
}
