using System.Collections.Generic;

using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.Interface;
using LinkedLists = DataStructuresAndAlgorithms.Data_Structures.Linked_Lists;

namespace DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI
{
    /// <summary>
    /// How would you design a stack which, in addition to push and pop, also has a function
    /// min which returns the minimum element? Push, pop and min should all operate in
    /// O(1) time.
    /// </summary>
    public class Question2 : IStack<int>
    {
        private readonly ILinkedList<int> _linkedList    = new LinkedLists.LinkedList<int>();
        private readonly SortedSet<int> _minSet          = new SortedSet<int>();

        public uint Length { get { return _linkedList.Length; }}

        public INode<int> Peak { get { return _linkedList.Head; }}
        
        public int Min { get { return _minSet.Min; }}

        public void Push(int data)
        {
            _minSet.Add(data);
            _linkedList.AddToHead(data);
        }

        public INode<int> Pop()
        {
            if (Length == 0 || _linkedList.Head == null)
                return null;

            INode<int> head = _linkedList.Head; 
            _linkedList.RemoveFromHead();
            _minSet.Remove(head.Data);
            return head;
        }
    }
}
