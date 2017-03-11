namespace DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat
{
    /// <summary>
    /// We have a number of bunnies and each bunny has two big floppy ears.
    /// We want to compute the total number of ears across all the bunnies recursively.
    /// </summary>
    public static class BunnyEars
    {
        public static int ComputeEars(int numberOfBunnies)
        {
            if (numberOfBunnies == 0)
                return 0;

            return 2 + ComputeEars(numberOfBunnies - 1);
        }
    }
}
