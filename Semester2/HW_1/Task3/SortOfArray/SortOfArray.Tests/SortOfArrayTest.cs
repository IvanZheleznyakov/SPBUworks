using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortOfArray.Tests
{
    [TestClass]
    public class SortOfArrayTest
    {
        [TestMethod]
        public void SelectionSortTest()
        {
            const int firstSizeOfArray = 5;
            const int secondSizeOfArray = 9;
            int[] firstUnsortedArray = new int[firstSizeOfArray] { 4, 3, 7, 5, 6 };
            int[] firstSortedArray = new int[firstSizeOfArray] { 3, 4, 5, 6, 7 };
            int[] secondUnsortedArray = new int[secondSizeOfArray] { -3, 6, 0, 54, 67, 6, 1000, 87, -34 };
            int[] secondSortedArray = new int[secondSizeOfArray] { -34, -3, 0, 6, 6, 54, 67, 87, 1000 };
            SortOfArray.Program.SelectionSort(firstUnsortedArray);
            SortOfArray.Program.SelectionSort(secondUnsortedArray);
            CollectionAssert.AreEqual(firstSortedArray, firstUnsortedArray);
            CollectionAssert.AreEqual(secondSortedArray, secondUnsortedArray);
        }
    }
}
