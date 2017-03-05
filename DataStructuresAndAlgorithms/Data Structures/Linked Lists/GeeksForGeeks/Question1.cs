using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.GeeksForGeeks
{
    /// <summary>
    /// Given a linked list which is sorted, how will you insert in sorted way.
    /// </summary>
    public static class Question1
    {
        public static void InsertIntoSortedList(this ILinkedList<int> linkedList, int dataToInsert)
        {
            if  ( linkedList.Head == null || linkedList.Head.Data >= dataToInsert )
            {
                linkedList.AddToHead( dataToInsert );
                return;
            }

            INode<int> runner    = linkedList.Head;
            INode<int> nodeToAdd = new Node<int>( dataToInsert );

            while ( runner.Next != null && dataToInsert > runner.Next.Data )
            {
                runner = runner.Next;
            }

            nodeToAdd.Next = runner.Next;
            runner.Next    = nodeToAdd;
            linkedList.AddedElement();
        }
    }
}
