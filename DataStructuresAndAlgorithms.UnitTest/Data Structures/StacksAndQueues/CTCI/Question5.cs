using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.StacksAndQueues.CTCI
{
    [TestClass]
    public class Question5
    {
        [TestMethod]
        public void Dequeue_EmptyQueue_NullResult()
        {
            var q5 = new DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI.Question5<int>();
            INode<int> node = q5.Dequeue();
            Assert.IsNull(node);
            Assert.IsTrue( q5.Length == 0);
        }

        [TestMethod]
        public void Enqueue_Enqueue1_PeakReturns1()
        {
            var q5 = new DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI.Question5<int>();
            q5.Enqueue(1);
            Assert.IsTrue( q5.Length == 1);
            Assert.IsNotNull( q5.Peak );
            Assert.IsTrue(q5.Peak.Data == 1);
        }

        [TestMethod]
        public void Dequeue_DequeueNonEmptyQueue_1Returned()
        {
            var q5 = new DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI.Question5<int>();
            q5.Enqueue(1);
            INode<int> dequeuedNode = q5.Dequeue();
            Assert.IsTrue( q5.Length == 0);
            Assert.IsNotNull( dequeuedNode );
            Assert.IsTrue( dequeuedNode.Data == 1);
        }
    }
}
