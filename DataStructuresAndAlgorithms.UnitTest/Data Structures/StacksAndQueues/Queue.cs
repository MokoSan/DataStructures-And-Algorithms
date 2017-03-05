using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.Interface;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.StacksAndQueues
{
    [TestClass]
    public class Queue
    {
        [TestMethod]
        public void Enqueue_Enqueue1_Sizeof1()
        {
            IQueue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            Assert.IsTrue(queue.Length == 1);
            Assert.IsTrue(queue.Peak.Data == 1);
        }

        [TestMethod]
        public void Dequeue_EmptyLinkedList_NullTail()
        {
            IQueue<int> queue = new Queue<int>();
            INode<int> node = queue.Dequeue();
            Assert.IsNull(node);
            Assert.IsTrue(queue.Length == 0);
        }

        [TestMethod]
        public void Dequeue_SingleElement_EmptyQueue()
        {
            IQueue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            INode<int> node = queue.Dequeue();
            Assert.IsNotNull(node);
            Assert.IsTrue(node.Data == 1);
            Assert.IsTrue(queue.Length == 0);
        }
    }
}
