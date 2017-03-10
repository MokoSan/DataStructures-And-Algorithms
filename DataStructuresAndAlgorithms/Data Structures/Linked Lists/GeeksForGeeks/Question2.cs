using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.GeeksForGeeks
{
    public static class Question2
    {
        public static int StrCompareForLinkedLists(ILinkedList<char> list1, ILinkedList<char> list2)
        {
            if ( list1.Head == null && list2.Head == null )
            {
                return 0;
            }

            if ( list1.Head != null && list2.Head == null )
            {
                return 1;
            }

            if ( list1.Head == null && list2.Head != null )
            {
                return -1; 
            }

            INode<char> runner1 = list1.Head;
            INode<char> runner2 = list2.Head;

            while ( runner1 != null && runner2 != null && runner1.Data == runner2.Data )
            {
                runner1 = runner1.Next;
                runner2 = runner2.Next;
            }

            if ( runner1 != null && runner2 != null )
            {
                return (runner1.Data > runner2.Data) ? -1 : 1;
            }

            else if ( runner1 == null && runner2 != null )
            {
                return 1;
            }

            else if ( runner1 != null && runner2 == null )
            {
                return -1;
            }

            return 0;
        } 
    }
}
