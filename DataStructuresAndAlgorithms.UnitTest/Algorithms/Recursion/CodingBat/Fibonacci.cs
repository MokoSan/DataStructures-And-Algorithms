using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat.Fibonacci;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion.CodingBat
{
    [TestClass]
    public class Fibonacci 
    {
        [TestMethod]
        public void ComputeFibonacci_0Input_0Result()
        {
            int result = ComputeFibonnaci(0);
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void ComputeFibonacci_1Input_1Result()
        {
            int result = ComputeFibonnaci(1);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void ComputeFibonacci_2Input_1Result()
        {
            int result = ComputeFibonnaci(2);
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void ComputeFibonacci_3Input_2Result()
        {
            int result = ComputeFibonnaci(3);
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void ComputeFibonacci_4Input_3Result()
        {
            int result = ComputeFibonnaci(4);
            Assert.IsTrue(result == 3);
        }
    }
}