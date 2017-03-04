using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.CTCI
{
    /// <summary>
    /// Implement an algorithm to find the nth to last element of 
    /// a singly linked list
    /// </summary>
    public static class Question2
    {
        public static INode<T> FindNthFromLast<T>(this ILinkedList<T> linkedList,
                                                  int n)
        {
            if ( linkedList == null || linkedList.Head == null )
            {
                return null;
            }

            INode<T> runner      = linkedList.Head;
            INode<T> nthFromLast = linkedList.Head;

            // (N - n - 1)th Position is position of the nth Element 
            // from the last. 
            for(int i = 0; i < n - 1; i++)
            {
                if ( runner == null )
                {
                    return null;
                }

                runner = runner.Next;
            }

            while (runner.Next != null)
            {
                nthFromLast = nthFromLast.Next;
                runner = runner.Next;
            }

            return nthFromLast; 
        }
    }
}
