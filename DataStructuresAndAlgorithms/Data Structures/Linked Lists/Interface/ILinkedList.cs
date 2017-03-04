namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface
{
    public interface ILinkedList<T>
    {
        INode<T> Head { get; }
        void AddToHead(T data);
        void AppendToTail(T data);
    }
}
