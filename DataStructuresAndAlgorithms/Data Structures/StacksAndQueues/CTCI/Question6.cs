using System;

namespace DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI
{
    /// <summary>
    /// Animal Shlelter 
    /// An animal shelter holds only dogs and cats, and operates on a strictly "first in, first out" basis.
    /// People must adopt either the "oldest" (based on arrival time) of all animals at the shelter, 
    /// or they can select whether they would prefer a dog or a cat(and will receive the oldest animal of that type). 
    /// They cannot select which specific animal they would like.
    /// Create the data structures to maintain this system and implement operations such as enqueue, dequeueAny, dequeueDog
    /// and dequeueCat.You may use the built-in LinkedList data structure.
    /// </summary>
    public class Question6
    {
        private readonly Queue<Dog> _dogs = new Queue<Dog>();
        private readonly Queue<Cat> _cats = new Queue<Cat>();

        private DateTime _dogTimeStamp = DateTime.MinValue;
        private DateTime _catTimeStamp = DateTime.MinValue;

        public void Enqueue(Animal animal)
        {
            if ( animal is Dog )
            {
                _dogs.Enqueue((Dog)animal);
                _dogTimeStamp = DateTime.Now; 
            }

            else
            {
                _cats.Enqueue((Cat)animal);
                _catTimeStamp = DateTime.Now; 
            }
        }

        public Animal DequeueAny()
        {
            if ( _dogTimeStamp < _catTimeStamp )
            {
                return _cats.Dequeue()?.Data; 
            }

            else
            {
                return _dogs.Dequeue()?.Data; 
            }
        }

        public Dog DequeueDog()
        {
            return _dogs.Dequeue()?.Data;
        }

        public Cat DequeueCat()
        {
            return _cats.Dequeue()?.Data;
        } 
    } 

    public class Animal
    {
        public DateTime TimeStamp { get; set; }
    } 

    public class Cat : Animal {}

    public class Dog : Animal {}
}
