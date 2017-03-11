namespace DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat
{
    public static class Count7
    {
        public static int Count7s(int digit)
        {
            return Count7sUtil(digit, 0);
        }

        public static int Count7sUtil(int digit, int runningCount)
        {
            if (digit == 0)
                return runningCount;
            bool isRightMostDigit7 = ( digit % 10 ) == 7;
            runningCount += (isRightMostDigit7) ? 1 : 0;
            return Count7sUtil(digit / 10, runningCount);
        }
    }
}
