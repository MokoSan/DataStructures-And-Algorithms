namespace DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat
{
    public static class Countx
    {
        public static int CountAllxs(string input)
        {
            return CountxUtil(input, 0, 0);
        }

        public static int CountxUtil(string input, int runningCount, int currentPosition)
        {
            if (currentPosition == input.Length)
                return runningCount;
            if (input[currentPosition] == 'x')
                runningCount += 1;
            return CountxUtil(input, runningCount, currentPosition + 1);
        }
    }
}
