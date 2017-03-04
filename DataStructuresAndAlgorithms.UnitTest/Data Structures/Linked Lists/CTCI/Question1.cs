using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.CTCI;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.Linked_Lists.CTCI
{
    [TestClass]
    public class Question1
    {
        [TestMethod]
        public void RemoveDuplicatesWithTempBuffer_EmptyList_NoOp()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.RemoveDuplicatesWithTempBufffer();
            Assert.IsTrue(linkedList.Length == 0);
        }

        [TestMethod]
        public void RemoveDuplicatesWithTempBuffer_TwoDuplicates_OneElement()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(1);
            linkedList.AddToHead(1);
            linkedList.RemoveDuplicatesWithTempBufffer();
            Assert.IsTrue(linkedList.Length == 1);
            Assert.IsTrue(linkedList.Head.Data == 1);
        }

        [TestMethod]
        public void RemoveDuplicatedWithTempBuffer_AllDuplicates_OneElement()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(1);
            linkedList.AddToHead(1);
            linkedList.AddToHead(1);
            linkedList.AddToHead(1);
            linkedList.AddToHead(1);
            linkedList.RemoveDuplicatesWithTempBufffer();
            Assert.IsTrue(linkedList.Length == 1);
            Assert.IsTrue(linkedList.Head.Data == 1);
        }

        [TestMethod]
        public void RemoveDuplicatedWithTempBuffer_MultipleNonConsecutiveDuplicates_DuplicatesRemoved()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(1);
            linkedList.AddToHead(2);
            linkedList.AddToHead(1);
            linkedList.AddToHead(2);
            linkedList.RemoveDuplicatesWithTempBufffer();
            Assert.IsTrue(linkedList.Length == 2);
            Assert.IsTrue(linkedList.Head.Data == 2);
            Assert.IsTrue(linkedList.Head.Next.Data == 1);
        }
    }
}
