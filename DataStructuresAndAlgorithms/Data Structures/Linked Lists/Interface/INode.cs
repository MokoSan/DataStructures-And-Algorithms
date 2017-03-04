namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface
{
    public interface INode<T>
    {
        T Data { get; set; }
        INode<T> Next { get; set; }
    }
}
