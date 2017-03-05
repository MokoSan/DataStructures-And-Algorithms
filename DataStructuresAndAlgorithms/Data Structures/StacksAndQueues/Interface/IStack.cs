using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.Interface
{
    public interface IStack<T>
    {
        void Push(T data);
        INode<T> Pop();
        INode<T> Peak { get; }
        uint Length { get; }
    }
}
