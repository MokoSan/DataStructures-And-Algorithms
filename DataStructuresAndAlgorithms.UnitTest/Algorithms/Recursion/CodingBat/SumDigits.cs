using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat.SumDigits;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion.CodingBat
{
    [TestClass]
    public class SumDigits
    {
        [TestMethod]
        public void ComputeSumDigits_0Input_0Result()
        {
            int result = ComputeSumDigits(0);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void ComputeSumDigits_1Input_1Result()
        {
            int result = ComputeSumDigits(1);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void ComputeSumDigits_123Input_6Result()
        {
            int result = ComputeSumDigits(123);
            Assert.IsTrue(result == 6);
        }

        [TestMethod]
        public void ComputeSumDigits_666Input_18Result()
        {
            int result = ComputeSumDigits(666);
            Assert.IsTrue(result == 18);
        }
    }
}
