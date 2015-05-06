using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ColumnSortMatrix.Tests
{
    [TestClass]
    public class ColumnSortMatrixTest
    {
        [TestMethod]
        public void ColumnSelectionSortTest()
        {
            int[][] array = 
            {
                new int[] { 5, 3, 9, 8 },
                new int[] { 7, 6, 2, 8 },
                new int[] { 1, 1, 1, 1 }
            };
            int[][] rightArray =
            {
                new int[] { 3, 5, 8, 9 },
                new int[] { 6, 7, 8, 2 },
                new int[] { 1, 1, 1, 1 }
            };
            ColumnSortMatrix.Program.ColumnSelectionSort(array);
            for (int i = 0; i != 3; ++i)
            {
                for (int j = 0; j != 4; ++j)
                {
                    Assert.AreEqual(rightArray[i][j], array[i][j]);
                }
            }
        }
    }
}
