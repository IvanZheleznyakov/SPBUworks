using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListClass.Tests
{
    [TestClass]
    public class LinkedListClassTest
    {
        [TestMethod]
        public void IsListEmptyTest()
        {
            LinkedList list = new LinkedList();
            Assert.AreEqual(true, list.IsListEmpty());
            list.AddElement(1);
            Assert.AreEqual(false, list.IsListEmpty());
            list.RemoveElement();
            Assert.AreEqual(true, list.IsListEmpty());
        }

        [TestMethod]
        public void AddElementsTest()
        {
            LinkedList list = new LinkedList();
            list.AddElement(3);
            list.AddElement(5);
            list.AddElement(7);
            Assert.AreEqual(7, list.RemoveElement());
            list.AddElement(9);
            Assert.AreEqual(9, list.RemoveElement());
            list.AddElement(11);
            Assert.AreEqual(11, list.RemoveElement());
            Assert.AreEqual(5, list.RemoveElement());
            Assert.AreEqual(3, list.RemoveElement());
        }

        [TestMethod]
        [ExpectedException(typeof(RemoveFromEmptyListException))]
        public void RemoveWithoutAddTest()
        {
            LinkedList list = new LinkedList();
            list.RemoveElement();
        }
    }
}