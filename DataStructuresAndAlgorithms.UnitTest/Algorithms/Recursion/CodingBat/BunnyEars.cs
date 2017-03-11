using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat.BunnyEars;
    
namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion.CodingBat
{
    [TestClass]
    public class BunnyEars
    {
        [TestMethod]
        public void ComputeEars_0Bunnies_0Result()
        {
            int result = ComputeEars(0);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void ComputeEars_1Bunnies_1Result()
        {
            int result = ComputeEars(1);
            Assert.IsTrue(result == 2);
        }
        
        [TestMethod]
        public void ComputeEars_2Bunnies_4Result()
        {
            int result = ComputeEars(2);
            Assert.IsTrue(result == 4);
        }

        [TestMethod]
        public void ComputeEars_3Bunnies_6Result()
        {
            int result = ComputeEars(3);
            Assert.IsTrue(result == 6);
        }
    }
}
