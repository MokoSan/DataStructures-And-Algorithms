using Microsoft.VisualStudio.TestTools.UnitTesting;

using BS = DataStructuresAndAlgorithms.Algorithms.Searching.BinarySearch;

namespace DataStructuresAndAlgorithms.UnitTest.Algorithms.Searching
{
    [TestClass]
    public class BinarySearch
    {
        [TestMethod]
        public void Search_NullArray_NotFound()
        {
            int index = BS.Search(null, 0, 5, 5);
            Assert.IsTrue(index == -1);
        }

        [TestMethod]
        public void Search_EmptyArray_NotFound()
        {
            int[] array = new int[0];
            int index = BS.Search(array, 0, 5, 5);
            Assert.IsTrue(index == -1);
        }

        [TestMethod]
        public void Search_StartLessThan0_NotFound()
        {
            int[] array = new int[3] { 1, 2, 3 };
            int index = BS.Search(array, -23, 5, 5);
            Assert.IsTrue(index == -1);
        }

        [TestMethod]
        public void Search_StartGreaterThanLength_NotFound()
        {
            int[] array = new int[3] { 1, 2, 3 };
            int index = BS.Search(array, 4, 3, 2);
            Assert.IsTrue(index == -1);
        }

        [TestMethod]
        public void Search_EndLessThan0_NotFound()
        {
            int[] array = new int[3] { 1, 2, 3 };
            int index = BS.Search(array, 4, -1, 2);
            Assert.IsTrue(index == -1);
        }


        [TestMethod]
        public void Search_EndGreaterThanLength_NotFound()
        {
            int[] array = new int[3] { 1, 2, 3 };
            int index = BS.Search(array, 0, 5, 2);
            Assert.IsTrue(index == -1);
        }

        [TestMethod]
        public void Search_NotSorted_NotFound()
        {
            int[] array = new int[3] { 1, 3, 2 };
            int index = BS.Search(array, 0, 2, 2);
            Assert.IsTrue(index == -1);
        }

        [TestMethod]
        public void Search_ValidInputs_ValidResult()
        {
            int[] array = new int[4] { 1, 2, 3, 4 };
            int index = BS.Search(array, 0, 3, 2);
            Assert.IsTrue(index == 1);
        }
    }
}
