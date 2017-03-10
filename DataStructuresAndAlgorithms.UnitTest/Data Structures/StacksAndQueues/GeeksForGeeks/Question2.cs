using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists;
using q2 = DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.GeeksForGeeks.Question2;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.StacksAndQueues.GeeksForGeeks
{
    [TestClass]
    public class Question2
    {
        [TestMethod]
        public void StrCompareForLinkedList_BothListsEmpty_0()
        {
            int result = q2.StrCompareForLinkedLists(new LinkedList<char>(), new LinkedList<char>());
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void StrCompareForLinkedList_FirstListEmpty_Negative1()
        {
            ILinkedList<char> linkedList = new LinkedList<char>();
            linkedList.AddToHead('c');
            int result = q2.StrCompareForLinkedLists(new LinkedList<char>(), linkedList);
            Assert.IsTrue(result == -1);
        }

        [TestMethod]
        public void StrCompareForLinkedList_SecondLisEmpty_Positive1()
        {
            ILinkedList<char> linkedList = new LinkedList<char>();
            linkedList.AddToHead('c');
            int result = q2.StrCompareForLinkedLists(linkedList, new LinkedList<char>());
            Assert.IsTrue(result == 1);
        }
    }
}
