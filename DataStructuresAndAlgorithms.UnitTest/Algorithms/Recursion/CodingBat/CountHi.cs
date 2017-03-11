using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat.CountHi;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion.CodingBat
{
    [TestClass]
    public class CountHi
    {
        [TestMethod]
        public void CountHis_EmptyInput_0Result()
        {
            int result = CountHis("");
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void CountHis_hiInput_3Result()
        {
            int result = CountHis("hi");
            Assert.IsTrue(result == 1);
        }

        [TestMethod]
        public void CountHis_hellohihiInput_6Result()
        {
            int result = CountHis("hellohihi");
            Assert.IsTrue(result == 2);
        }

        [TestMethod]
        public void CountHis_xxxhixxxhixxxInput_0Result()
        {
            int result = CountHis("xxxhixxxhixxx");
            Assert.IsTrue(result == 2);
        }
    }
}
