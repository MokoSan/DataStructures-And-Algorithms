using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.StacksAndQueues.CTCI
{
    [TestClass]
    public class Question2
    {
        [TestMethod]
        public void Push_PushMultipleInts_GetAppropriateMin()
        {
            var q2 = new DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI.Question2();
            q2.Push(1);
            q2.Push(2);
            Assert.IsTrue(q2.Min == 1);
        }

        [TestMethod]
        public void Pop_PopEmptyStack_NoMin()
        {
            var q2 = new DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI.Question2();
            q2.Pop();
            Assert.IsTrue(q2.Min == default(int));
        }

        [TestMethod]
        public void Pop_PopStackWithElements_GetAppropriateMin()
        {
            var q2 = new DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI.Question2();
            q2.Push(1);
            q2.Push(-1);
            q2.Push(1);
            q2.Pop();
            Assert.IsTrue(q2.Min == -1);
        }
    }
}
