using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.CTCI;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.Linked_Lists.CTCI
{
    [TestClass]
    public class Question3
    {
        [TestMethod]
        public void DeleteNodeInTheMiddle_EmptyList_NoOp()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.DeleteNodeInTheMiddle(new Node<int>(5));
            Assert.IsTrue(linkedList.Length == 0);
        }

        [TestMethod]
        public void DeleteNodeInTheMiddle_NullInput_NoOp()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(1);
            Assert.IsTrue(linkedList.Length == 1);
            linkedList.DeleteNodeInTheMiddle(null);
            Assert.IsTrue(linkedList.Length == 1);
        }

        [TestMethod]
        public void DeleteNodeInTheMiddle_NextNodeNull_SetNodeNull()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AppendToTail(1);
            Assert.IsTrue(linkedList.Length == 1);
        }

        [TestMethod]
        public void DeleteNodeInTheMiddle_NextNodeNotNull_RemoveCurrentNode()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AppendToTail(1);
            linkedList.AppendToTail(2);
            linkedList.AppendToTail(3);
            Assert.IsTrue(linkedList.Length == 3);

            INode<int> secondNode = linkedList.Head.Next;
            linkedList.DeleteNodeInTheMiddle(secondNode);
            Assert.IsTrue(linkedList.Length == 2);
        }
    }
}
