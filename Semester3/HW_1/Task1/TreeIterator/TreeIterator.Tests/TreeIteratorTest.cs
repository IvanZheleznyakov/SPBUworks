﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TreeIterator.Tests
{
    [TestClass]
    public class TreeIteratorTest
    {
        [TestMethod]
        public void RightNumOfAddedElementsTest()
        {
            MyBinaryTree<int> firstTree = new MyBinaryTree<int>();
            firstTree.AddElement(1);
            firstTree.AddElement(3);
            firstTree.AddElement(0);
            firstTree.AddElement(2);
            firstTree.AddElement(0);
            int numOfElements = 0;
            foreach (int element in firstTree)
            {
                ++numOfElements;
            }
            Assert.AreEqual(5, numOfElements);

            MyBinaryTree<int> secondTree = new MyBinaryTree<int>();
            numOfElements = 0;
            foreach (int element in secondTree)
            {
                ++numOfElements;
            }
            Assert.AreEqual(0, numOfElements);
        }
    }
}
