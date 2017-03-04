using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.CTCI
{
    /// <summary>
    /// Implement an algorithm to delete a node in the 
    /// middle of a single linked list, given only access to that node.
    /// </summary>
    public static class Question3
    {
        public static void DeleteNodeInTheMiddle<T>(this ILinkedList<T> linkedList,
                                                    INode<T> nodeToDelete)
        {
            if ( nodeToDelete == null )
            {
                return;
            }

            if ( nodeToDelete.Next == null )
            {
                nodeToDelete = null;
                return;
            }

            nodeToDelete.Data = nodeToDelete.Next.Data;
            nodeToDelete.Next = nodeToDelete.Next.Next;
            linkedList.RemovedElement();
        }
    }
}
