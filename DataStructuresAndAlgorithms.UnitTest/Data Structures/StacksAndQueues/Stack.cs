using Microsoft.VisualStudio.TestTools.UnitTesting;

using DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.Interface;

namespace DataStructuresAndAlgorithms.UnitTest.Data_Structures.StacksAndQueues
{
    [TestClass]
    public class Stack
    {
        [TestMethod]
        public void Push_Push1_SizeOf1()
        {
            IStack<int> stack = new Stack<int>();
            stack.Push(1);
            Assert.IsTrue(stack.Length == 1);
            Assert.IsTrue(stack.Peak.Data == 1);
        }

        [TestMethod]
        public void Pop_EmptyLinkedList_NullHead()
        {
            IStack<int> stack = new Stack<int>();
            INode<int> node = stack.Pop();
            Assert.IsNull(node);
            Assert.IsTrue(stack.Length == 0);
        }

        [TestMethod]
        public void Pop_SingleElement_EmptyStack()
        {
            IStack<int> stack = new Stack<int>();
            stack.Push(1);
            INode<int> node = stack.Pop();
            Assert.IsTrue(node != null);
            Assert.IsTrue(node.Data == 1);
            Assert.IsTrue(stack.Length == 0);
        }
    }
}
