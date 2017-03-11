using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat.BunnyEars2;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion.CodingBat
{
    [TestClass]
    public class BunnyEars2 
    {
        [TestMethod]
        public void ComputeBunnyEars2_0Input_0Result()
        {
            int result = ComputeBunnyEars2(0);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void ComputeBunnyEars2_1Input_2Result()
        {
            int result = ComputeBunnyEars2(1);
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void ComputeBunnyEars2_2Input_5Result()
        {
            int result = ComputeBunnyEars2(2);
            Assert.IsTrue(result == 5);
        }

        [TestMethod]
        public void ComputeBunnyEars2_3Input_7Result()
        {
            int result = ComputeBunnyEars2(3);
            Assert.IsTrue(result == 7);
        }
    }
}
