using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat.Factorial;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion.CodingBat
{
    [TestClass]
    public class Factorial
    {
        [TestMethod]
        public void ComputeFactorial_0Input_1Output()
        {
            int result = ComputeFactorial(0);
            Assert.IsTrue(result == 1);
        } 

        [TestMethod]
        public void ComputeFactorial_1Input_1Output()
        {
            int result = ComputeFactorial(1);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void ComputeFactorial_5Input_120Output()
        {
            int result = ComputeFactorial(5);
            Assert.IsTrue(result == 120);
        }
    }
}
