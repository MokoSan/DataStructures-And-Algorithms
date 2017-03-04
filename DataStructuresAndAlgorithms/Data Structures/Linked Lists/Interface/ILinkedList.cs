namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface
{
    public interface ILinkedList<T>
    {
        uint Length { get; }
        INode<T> Head { get; }

        void AddToHead(T data);
        void AppendToTail(T data);
    }
}
