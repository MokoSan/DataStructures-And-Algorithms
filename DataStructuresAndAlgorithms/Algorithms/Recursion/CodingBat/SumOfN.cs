namespace DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat
{
    public static class SumOfN
    {
        public static int ComputeSumTillN(int n)
        {
            return ComputeSumTillNUtil(n, 0);
        }

        public static int ComputeSumTillNUtil(int n, int runningSum)
        {
            if (n == 0)
                return runningSum;
            return ComputeSumTillNUtil(n - 1, runningSum + n);
        }
    }
}
