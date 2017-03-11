using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat.Countx;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion.CodingBat
{
    [TestClass]
    public class Countx 
    {
        [TestMethod]
        public void CountAllxs_EmptyInput_0Result()
        {
            int result = CountAllxs("");
            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void CountAllxs_xxxInput_3Result()
        {
            int result = CountAllxs("xxx");
            Assert.IsTrue(result == 3);
        }

        [TestMethod]
        public void CountAllxs_xxxyxxxInput_6Result()
        {
            int result = CountAllxs("xxxyxxx");
            Assert.IsTrue(result == 6);
        }

        [TestMethod]
        public void CountAllxs_yyyInput_0Result()
        {
            int result = CountAllxs("yyy");
            Assert.IsTrue(result == 0);
        }
    }
}
