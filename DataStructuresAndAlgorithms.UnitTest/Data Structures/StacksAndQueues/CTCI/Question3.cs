using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.StacksAndQueues.CTCI
{
    [TestClass]
    public class Question3
    {
        [TestMethod]
        public void Pop_EmptyStacksPop_NullResult()
        {
            var q3 = new DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI.Question3<int>(0);
            INode<int> node = q3.Pop();
            Assert.IsNull(node);
        }

        [TestMethod]
        public void Push_Push1IntoSingleStack_PeakIs1()
        {
            var q3 = new DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI.Question3<int>(300);
            q3.Push(1);
            Assert.IsTrue(q3.NumberOfStacks == 1);
            Assert.IsTrue(q3.Peak.Data == 1);
        }

        [TestMethod]
        public void Push_Push1IntoMultipleStacksWith1Threshold_2ndStackPeak1()
        {
            var q3 = new DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI.Question3<int>(1);
            q3.Push(2);
            q3.Push(1);
            Assert.IsTrue(q3.NumberOfStacks == 2);
            Assert.IsTrue(q3.Peak.Data == 1);
        }

        [TestMethod]
        public void Pop_PopFromMultipleStackToRemoveOneStack_PoppedResultHasData1()
        {
            var q3 = new DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI.Question3<int>(1);
            q3.Push(2);
            q3.Push(1);
            q3.Pop();
            Assert.IsTrue(q3.NumberOfStacks == 1);
            Assert.IsTrue(q3.Peak.Data == 2);
        }
    }
}
