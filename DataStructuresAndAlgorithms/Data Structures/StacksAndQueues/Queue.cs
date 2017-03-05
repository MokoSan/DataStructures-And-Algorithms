using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists;
using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;
using DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues
{
    public sealed class Queue<T> : IQueue<T>
    {
        private readonly ILinkedList<T> _linkedList = new LinkedList<T>();

        public uint Length { get { return _linkedList.Length; }}

        public INode<T> Peak { get { return _linkedList.Head; }}

        public void Enqueue(T data)
        {
            _linkedList.AppendToTail(data);
        }

        public INode<T> Dequeue()
        {
            if (_linkedList.Length == 0 || _linkedList.Head == null)
                return null;

            INode<T> head = _linkedList.Head;
            _linkedList.RemoveFromHead();
            return head;
        }
    }
}
