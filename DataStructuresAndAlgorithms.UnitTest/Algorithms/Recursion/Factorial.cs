using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion
{
    [TestClass]
    public class Factorial
    {
        [TestMethod]
        public void ComputeFactorial_0Input_1Output()
        {
            int result = DataStructuresAndAlgorithms.Algorithms.Recursion.Factorial.ComputeFactorial(0);
            Assert.IsTrue(result == 1);
        } 

        [TestMethod]
        public void ComputeFactorial_1Input_1Output()
        {
            int result = DataStructuresAndAlgorithms.Algorithms.Recursion.Factorial.ComputeFactorial(1);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void ComputeFactorial_5Input_120Output()
        {
            int result = DataStructuresAndAlgorithms.Algorithms.Recursion.Factorial.ComputeFactorial(5);
            Assert.IsTrue(result == 120);
        }
    }
}
