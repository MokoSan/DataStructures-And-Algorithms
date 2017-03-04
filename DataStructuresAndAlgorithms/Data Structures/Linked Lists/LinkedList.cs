using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists
{
    public sealed class LinkedList<T> : ILinkedList<T>
    {
        public uint Length { get; private set; } = 0;
        public INode<T> Head { get; private set; }

        public void AddToHead(T data)
        {
            INode<T> newNode = new Node<T>(data);
            newNode.Next = Head; 
            Head = newNode;
            ++Length;
        }

        public void AppendToTail(T data)
        {
            INode<T> newNode = new Node<T>(data);
            ++Length;

            if ( Head == null )
            {
                Head = newNode;
                return;
            }

            INode<T> temp = Head; 
            while ( temp.Next != null )
            {
                temp = temp.Next;
            }

            temp.Next = newNode;
        }
    }
}
