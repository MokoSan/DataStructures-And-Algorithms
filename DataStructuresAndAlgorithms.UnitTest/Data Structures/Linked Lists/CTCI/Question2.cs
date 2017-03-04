using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.CTCI;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.Linked_Lists.CTCI
{
    [TestClass]
    public class Question2
    {

        [TestMethod]
        public void NthFromLast_EmptyList_Null()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            INode<int> node = linkedList.FindNthFromLast(1);
            Assert.IsNull(node);
        }

        [TestMethod]
        public void NthFromLast_SmallerListThann_Null()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddToHead(1);
            INode<int> node = linkedList.FindNthFromLast(5);
            Assert.IsNull(node);
        }

        [TestMethod]
        public void NthFromLast_Validn_ValidNode()
        {
            ILinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AppendToTail(1);
            linkedList.AppendToTail(2);
            linkedList.AppendToTail(3);
            linkedList.AppendToTail(4);

            INode<int> nthFromLast = linkedList.FindNthFromLast(2);
            Assert.IsNotNull(nthFromLast);
            Assert.IsTrue(nthFromLast.Data == 3);
        }
    }
}
