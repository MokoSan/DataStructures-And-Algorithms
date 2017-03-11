using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat.Count7;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion.CodingBat
{
    [TestClass]
    public class Count7 
    {
        [TestMethod]
        public void Count7s_0Input_0Result()
        {
            int result = Count7s(0);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void Count7s_7Input_1Result()
        {
            int result = Count7s(7);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void Count7s_777Input_3Result()
        {
            int result = Count7s(777);
            Assert.IsTrue(result == 3);
        }

        [TestMethod]
        public void Count7s_727Input_2Result()
        {
            int result = Count7s(727);
            Assert.IsTrue(result == 2);
        }
    }
}
