using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListClass.Tests
{
    [TestClass]
    public class LinkedListClassTest
    {
        [TestMethod]
        public void AddElementsTest()
        {
            var list = new LinkedList<int>();
            list.AddElement(5);
            list.AddElement(7);
            Assert.AreEqual(7, list.RemoveElement());
            Assert.AreEqual(5, list.RemoveElement());
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            var list = new LinkedList<int>();
            list.AddElement(10);
            list.AddElement(15);
            list.AddElement(20);
            list.DeleteElement(15);
            Assert.AreEqual(false, list.IsElementInList(15));
        }

        [TestMethod]
        [ExpectedException(typeof(RemoveFromEmptyListException))]
        public void RemoveWithoutAddingTest()
        {
            var list = new LinkedList<int>();
            list.RemoveElement();
        }
    }
}
