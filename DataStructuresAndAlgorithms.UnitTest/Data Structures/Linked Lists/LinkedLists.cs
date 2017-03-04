using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.Linked_Lists
{
    [TestClass]
    public class LinkedLists
    {
        [TestMethod]
        public void AddToHead_Add1ToHeadEmptyList_HeadHasData1()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(1);
            Assert.IsTrue(linkedList != null);
            Assert.IsTrue(linkedList.Length == 1);
            Assert.IsTrue(linkedList.Head.Data == 1);
        }

        [TestMethod]
        public void AddToHead_Add1ToHeadNonEmptyList_HeadHasData1()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(1);
            linkedList.AddToHead(2);

            Assert.IsTrue(linkedList != null);
            Assert.IsTrue(linkedList.Length == 2);
            Assert.IsTrue(linkedList.Head.Data == 2);
            Assert.IsTrue(linkedList.Head.Next.Data == 1);
        }
    
        [TestMethod]
        public void AppendToTail_Append1ToTailEmptyList_TailHasData1()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AppendToTail(1);

            Assert.IsTrue(linkedList != null);
            Assert.IsTrue(linkedList.Length == 1);
            Assert.IsTrue(linkedList.Head.Data == 1);
        }

        [TestMethod]
        public void AppendToTail_Append1ToTailNonEmptyList_TailHasData2()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(1);
            linkedList.AppendToTail(2);

            Assert.IsTrue(linkedList != null);
            Assert.IsTrue(linkedList.Length == 2);
            Assert.IsTrue(linkedList.Head.Data == 1);
            Assert.IsTrue(linkedList.Head.Next.Data == 2);
        }

        [TestMethod]
        public void DeleteAll_NullHead_NoOp()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.DeleteAll(5);

            Assert.IsTrue(linkedList.Head == null);
            Assert.IsTrue(linkedList.Length == 0);
        }

        [TestMethod]
        public void DeleteAll_HeadWithDataToDelete_DeleteHead()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(1);
            linkedList.DeleteAll(1);

            Assert.IsTrue(linkedList.Head == null);
            Assert.IsTrue(linkedList.Length == 0);
        }
    }
}
