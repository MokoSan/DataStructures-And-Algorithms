namespace DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat
{
    public static class SumDigits
    {
        public static int ComputeSumDigits(int digit)
        {
            return ComputeSumDigitsUtil(digit, 0);
        }

        public static int ComputeSumDigitsUtil(int digitsLeft, int runningSum)
        {
            if (digitsLeft == 0)
                return runningSum;
            return ComputeSumDigitsUtil(digitsLeft / 10, runningSum + digitsLeft % 10);
        }
    }
}
