using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.Interface
{
    public interface IQueue<T>
    {
        void Enqueue(T data);
        INode<T> Dequeue();
        INode<T> Peak { get; }
        uint Length { get; }
    }
}
