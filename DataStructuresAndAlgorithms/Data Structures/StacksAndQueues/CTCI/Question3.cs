using System.Collections.Generic;

using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI
{
    /// <summary>
    /// Imagine a (literal) stack of plates. If the stack gets too high, it might topple. Therefore,
    /// in real life, we would likely start a new stack when the previous stack exceeds
    /// some threshold.Implement a data structure SetOfStacks that mimics this. SetOfStacks
    /// should be composed of several stacks, and should create a new stack once
    /// the previous one exceeds capacity.SetOfStacks.push() and SetOfStacks.pop() should
    /// behave identically to a single stack(that is, pop() should return the same values as it
    /// would if there were just a single stack).
    /// </summary>
    public sealed class Question3<T> : IStack<T> 
    {
        private List<IStack<T>> _stacks = new List<IStack<T>>();
        private int _stackNumber        = -1;
        private readonly uint _stackThreshold; 

        public Question3(uint stackThreshold)
        {
            _stackThreshold = stackThreshold;
        }

        public INode<T> Peak { get { return _stacks[_stackNumber].Peak; }}
        public uint Length { get { return _stacks[_stackNumber].Length; }}
        public int NumberOfStacks { get { return _stacks.Count; }} 

        public INode<T> Pop()
        {
            if ( _stackNumber == -1 )
            {
                return null;
            }

            INode<T> head = _stacks[_stackNumber].Pop();
            if ( _stacks[_stackNumber].Length == 0 )
            {
                _stacks.RemoveAt(_stackNumber);
                --_stackNumber;
            }

            return head;
        }

        public INode<T> PopAt(int index)
        {
            if ( index < 0 || index >= _stacks.Count )
            {
                return null;
            }

            return _stacks[index].Pop();
        }

        public void Push(T data)
        {
            if ( _stackNumber == -1 )
            {
                _stackNumber = 0;
                _stacks.Add(new Stack<T>());
            }

            if ( _stacks[_stackNumber].Length == _stackThreshold )
            {
                ++_stackNumber;
                _stacks.Add(new Stack<T>());
            }

            _stacks[_stackNumber].Push(data);
        }
    }
}
