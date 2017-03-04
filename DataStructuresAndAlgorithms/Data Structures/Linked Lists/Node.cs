using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists
{
    public sealed class Node<T> : INode<T>
    {
        public Node()
        {
            Data = default(T);
            Next = null;
        }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }

        public Node(T data, INode<T> next)
        {
            Data = data;
            Next = next;
        }
        public T Data { get; set; } 
        public INode<T> Next { get; set; }

        public override bool Equals(object obj)
        {
            INode<T> node = obj as INode<T>;
            if (node == null)
                return false;
            return ( Data.Equals( node.Data ));
        }

        public override int GetHashCode()
        {
            return 17 * Data.GetHashCode();
        }
    }
}
