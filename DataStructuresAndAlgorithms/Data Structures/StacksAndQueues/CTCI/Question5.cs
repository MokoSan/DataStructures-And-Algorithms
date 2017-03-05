using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI
{
    /// <summary>
    /// Implement a MyQueue class which implements a queue using two stacks.
    /// </summary>
    public sealed class Question5<T> : IQueue<T>
    {
        private readonly IStack<T> _inStack  = new Stack<T>();
        private readonly IStack<T> _outStack = new Stack<T>();

        public uint Length { get { return _inStack.Length + _outStack.Length; }} 

        public INode<T> Peak
        {
            get
            {
                if ( Length == 0 )
                    return null;

                if ( _outStack.Length > 0 )
                    return _outStack.Peak;

                while( _inStack.Length > 0 )
                {
                    _outStack.Push( _inStack.Pop().Data );
                }

                return _outStack.Peak;
            }
        }

        public void Enqueue(T data)
        {
            _inStack.Push(data);
        }

        public INode<T> Dequeue()
        {
            if ( _outStack.Length > 0 )
            {
                return _outStack.Pop();
            }

            while( _inStack.Length > 0 )
            {
                _outStack.Push( _inStack.Pop().Data );
            }

            return _outStack.Pop();
        }
    }
}
