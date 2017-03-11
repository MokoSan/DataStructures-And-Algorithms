namespace DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat
{
    public static class Fibonacci
    {
        public static int ComputeFibonnaci(int n)
        {
            if (n == 0)
                return 0;

            if (n == 1)
                return 1;

            return ComputeFibonnaci(n - 1) + ComputeFibonnaci(n - 2);
        }
    }
}
