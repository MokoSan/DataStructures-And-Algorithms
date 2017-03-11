namespace DataStructuresAndAlgorithms.Algorithms.Recursion
{
    public static class Factorial
    {
        public static int ComputeFactorial(int n)
        {
            if ( n == 0 || n == 1 )
            {
                return 1;
            }

            return n * ComputeFactorial(n - 1);
        }
    }
}
