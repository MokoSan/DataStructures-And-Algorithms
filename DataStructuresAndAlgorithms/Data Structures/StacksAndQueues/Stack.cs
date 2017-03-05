using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues
{
    public class Stack<T> : IStack<T>
    {
        private readonly ILinkedList<T> _linkedList = new LinkedList<T>();
           
        public uint Length { get { return _linkedList.Length; }}
        public INode<T> Peak { get { return _linkedList.Head; }} 

        public void Push(T data)
        {
            _linkedList.AddToHead(data);
        }

        public INode<T> Pop()
        {
            if ( _linkedList.Length == 0 || _linkedList.Head == null )
            {
                return null; 
            }

            INode<T> head = _linkedList.Head;
            _linkedList.RemoveFromHead();
            return head;
        }
    }
}
