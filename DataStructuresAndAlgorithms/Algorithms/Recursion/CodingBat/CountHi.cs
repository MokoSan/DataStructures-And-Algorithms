namespace DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat
{
    /// <summary>
    /// Counts the number of 'hi' in a string.
    /// </summary>
    public static class CountHi
    {
        public static int CountHis(string input)
        {
            if (input.Length == 0)
                return 0;

            return CountHisUtil(input, 0, 0);
        }

        public static int CountHisUtil(string input, int runningCount, int currentPosition)
        {
            if (currentPosition == input.Length - 1)
                return runningCount;

            if (input[currentPosition] == 'h' && input[currentPosition + 1] == 'i')
                ++runningCount;
            return CountHisUtil(input, runningCount, currentPosition + 1);
       }
    }
}
