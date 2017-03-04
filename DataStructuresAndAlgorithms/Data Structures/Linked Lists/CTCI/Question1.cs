using System.Collections.Generic;

using DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface;

namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.CTCI
{
    /// <summary>
    /// Write code to remove duplicates from a linked list.
    /// Linked List is unsorted.
    /// </summary>
    public static class Question1
    {
        public static void RemoveDuplicatesWithTempBufffer<T>(this ILinkedList<T> linkedList)
        {
            if ( linkedList == null || linkedList.Head == null )
            {
                return;
            }

            HashSet<T> alreadyEncounteredData = new HashSet<T>();

            INode<T> previous = null;
            INode<T> next = linkedList.Head;

            while( next != null )
            {
                if ( alreadyEncounteredData.Contains( next.Data ))
                {
                    previous.Next = next.Next;
                }

                else
                {
                    alreadyEncounteredData.Add(next.Data);
                    previous = next;
                }

                next = next.Next;
            }
        }
    }
}
