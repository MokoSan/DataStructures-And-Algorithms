namespace DataStructuresAndAlgorithms.Algorithms.Searching
{
    public static class BinarySearch
    {
        public static int Search(int[] array, 
                                 int start, 
                                 int end, 
                                 int element)
        {
            if ( array == null || array.Length == 0 )
            {
                return -1;
            }

            if ( start < 0 || start > array.Length || 
                 end < 0   || end > array.Length )
            {
                return -1;
            }
            
            if ( !IsSorted( array ))
            {
                return -1;
            }

            while ( start <= end )
            {
                int mid = ((end - start) / 2) + start;

                if ( array[ mid ] == element )
                {
                    return mid;
                }

                if ( element < array[ mid ] )
                {
                    end = mid - 1;
                }

                else
                {
                    start = mid + 1;
                }
            }

            return -1;
        }

        private static bool IsSorted(int[] array)
        {
            if ( array == null )
                return false;

            for(int i = 1; i < array.Length; i++)
            {
                if ( array[i - 1] > array[ i ])
                    return false;
            }

            return true;
        }
    }
}
