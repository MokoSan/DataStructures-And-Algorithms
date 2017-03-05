﻿namespace DataStructuresAndAlgorithms.Data_Structures.Linked_Lists.Interface
{
    public interface ILinkedList<T>
    {
        uint Length { get; }
        INode<T> Head { get; }

        void AddToHead(T data);
        void RemoveFromHead();
        void AppendToTail(T data);
        void DeleteAll(T data);
        void RemovedElement();
    }
}
