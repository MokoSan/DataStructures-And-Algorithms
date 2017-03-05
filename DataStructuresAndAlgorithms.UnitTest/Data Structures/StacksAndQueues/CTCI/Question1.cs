using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.StacksAndQueues.CTCI
{
    [TestClass]
    public class Question1
    {
        [TestMethod]
        public void Push_StackNumberGreaterThan3_NotPushed()
        {
            Question1<int> q1 = new Question1<int>();
            q1.Push(4, 4);
            Assert.IsTrue(q1.Peak(0) == 0);
            Assert.IsTrue(q1.Peak(1) == 0);
            Assert.IsTrue(q1.Peak(2) == 0);
        }

        [TestMethod]
        public void Push_StackNumber1Push1_Peak1InStack1()
        {
            Question1<int> q1 = new Question1<int>();
            q1.Push(0, 1);
            Assert.IsTrue(q1.Peak(0) == 1);
            Assert.IsTrue(q1.Peak(1) == 0);
            Assert.IsTrue(q1.Peak(2) == 0);
        }

        [TestMethod]
        public void Push_StackNumber1Push2StackNumber2Push3_Peak1InStack1AndPeak3InStack2()
        {
            Question1<int> q1 = new Question1<int>();
            q1.Push(1, 2);
            q1.Push(2, 3);
            Assert.IsTrue(q1.Peak(0) == 0);
            Assert.IsTrue(q1.Peak(1) == 2);
            Assert.IsTrue(q1.Peak(2) == 3);
        }

        [TestMethod]
        public void Pop_StackNumber1Empty_0Returned()
        {
            Question1<int> q1 = new Question1<int>();
            q1.Pop(1);
            Assert.IsTrue(q1.Peak(0) == 0);
        }

        [TestMethod]
        public void Pop_StackNumber0NotEmpty_1Returned()
        {
            Question1<int> q1 = new Question1<int>();
            q1.Push(0, 1);
            Assert.IsTrue(q1.Peak(0) == 1);
            int value = q1.Pop(0);
            Assert.IsTrue(q1.Peak(0) == 0);
            Assert.IsTrue(value == 1);
        }
    }
}
