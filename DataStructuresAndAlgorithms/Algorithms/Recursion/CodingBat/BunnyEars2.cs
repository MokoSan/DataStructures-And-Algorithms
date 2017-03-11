namespace DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat
{
    /// <summary>
    /// We have bunnies standing in a line, numbered 1, 2, ... 
    /// The odd bunnies (1, 3, ..) have the normal 2 ears. 
    /// The even bunnies (2, 4, ..) we'll say have 3 ears, because they each have a raised foot. 
    /// Recursively return the number of "ears" in the bunny line 1, 2, ... n 
    /// </summary>
    public static class BunnyEars2
    {
        public static int ComputeBunnyEars2(int numberOfBunnies)
        {
            return ComputeBunnyEars2Util(numberOfBunnies, 0);
        }

        public static int ComputeBunnyEars2Util(int numberOfBunnies, int runningSum)
        {
            if (numberOfBunnies == 0)
                return runningSum;
            runningSum += (numberOfBunnies % 2 == 0) ? 3 : 2;
            return ComputeBunnyEars2Util(numberOfBunnies - 1, runningSum);
        }
    }
}
