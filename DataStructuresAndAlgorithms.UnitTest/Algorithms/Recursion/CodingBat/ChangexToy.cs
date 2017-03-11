using Microsoft.VisualStudio.TestTools.UnitTesting;

using static DataStructuresAndAlgorithms.Algorithms.Recursion.CodingBat.Changextoy;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Recursion.CodingBat
{
    [TestClass]
    public class ChangexToy
    {
        [TestMethod]
        public void ChangexToys_EmptyInput_0Result()
        {
            string result = ChangeAllxToy(string.Empty);
            Assert.IsTrue(result == string.Empty);
        }

        [TestMethod]
        public void ChangeAllxToy_xxInput_yyResult()
        {
            string result = ChangeAllxToy("xx");
            Assert.IsTrue(result == "yy");
        }

        [TestMethod]
        public void ChangeAllxToy_xyxyInput_yyyyResult()
        {
            string result = ChangeAllxToy("xyxy");
            Assert.IsTrue(result == "yyyy");
        }

        [TestMethod]
        public void ChangeAllxToy_yyyxInput_yyyyResult()
        {
            string result = ChangeAllxToy("yyyx");
            Assert.IsTrue(result == "yyyy");
        }
    }
}
