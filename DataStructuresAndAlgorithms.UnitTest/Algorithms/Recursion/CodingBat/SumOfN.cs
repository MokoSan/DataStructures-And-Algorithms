using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat.SumOfN;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion.CodingBat
{
    [TestClass]
    public class SumOfN
    {
        [TestMethod]
        public void ComputeSumOfN_0Input_0Result()
        {
            int result = ComputeSumTillN(0);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void ComputeSumOfN_1Input_1Result()
        {
            int result = ComputeSumTillN(1);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void ComputeSumOfN_2Input_3Result()
        {
            int result = ComputeSumTillN(2);
            Assert.IsTrue(result == 3);
        }

        [TestMethod]
        public void ComputeSumOfN_3Input_6Result()
        {
            int result = ComputeSumTillN(3);
            Assert.IsTrue(result == 6);
        }
    }
}
