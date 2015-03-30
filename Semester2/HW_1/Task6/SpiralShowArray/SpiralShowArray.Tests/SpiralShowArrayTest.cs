using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpiralShowArray.Tests
{
    [TestClass]
    public class SpiralShowArrayTest
    {
        [TestMethod]
        public void SpiralShowMatrixTest()
        {
            const int sizeOfMatrix = 3;
            int[][] matrix = new int[sizeOfMatrix][];
            matrix[0] = new int[] { 0, 1, 2 };
            matrix[1] = new int[] { 1, 2, 3 };
            matrix[2] = new int[] { 2, 3, 4 };
            string testString = "2 3 4 3 2 1 0 1 2 ";
            Assert.AreEqual(testString, SpiralShowArray.Program.SpiralShowMatrix(matrix));
        }
    }
}
