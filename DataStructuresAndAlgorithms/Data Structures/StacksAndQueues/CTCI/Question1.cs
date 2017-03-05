namespace DataStructuresAndAlgorithms.Data_Structures.StacksAndQueues.CTCI
{
    /// <summary>
    /// Describe how you could use a single array to implement three stacks.
    /// </summary>
    public sealed class Question1<T>
    {
        private const int STACK_SIZE = 300;
        private T[] _buffer = new T[STACK_SIZE * 3];
        private readonly int[] _stackPointer = new int[] { 0, 0, 0 };

        public void Push(int stackNumber, T data)
        {
            if ( stackNumber > 3 )
            {
                return;
            }

            int stackIndex = stackNumber * STACK_SIZE + _stackPointer[stackNumber] + 1;
            ++_stackPointer[stackNumber];
            _buffer[stackIndex] = data;
        }

        public T Pop(int stackNumber)
        {
            if ( stackNumber > 3 )
            {
                return default(T);
            }

            int stackIndex = stackNumber * STACK_SIZE + _stackPointer[stackNumber];
            --_stackPointer[stackNumber];
            T value = _buffer[stackIndex];
            _buffer[stackIndex] = default(T);
            return value;
        }

        public T Peak(int stackNumber)
        {
            if ( stackNumber > 3 )
            {
                return default(T);
            }

            int stackIndex = STACK_SIZE * stackNumber + _stackPointer[stackNumber];
            return _buffer[stackIndex];
        }
    }
}
