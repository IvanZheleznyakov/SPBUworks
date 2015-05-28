using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UniqueListClass.Tests
{
    [TestClass]
    public class UniqueListClassTest
    {
        [TestMethod]
        public void AddElementsTest()
        {
            var list = new MyUniqueList<int>();
            list.AddElement(5);
            list.AddElement(7);
            Assert.AreEqual(7, list.RemoveElement());
            Assert.AreEqual(5, list.RemoveElement());
        }

        [TestMethod]
        [ExpectedException(typeof(AddExistingElementException))]
        public void AddExistingElementTest()
        {
            var list = new MyUniqueList<int>();
            list.AddElement(10);
            list.AddElement(15);
            list.AddElement(17);
            list.AddElement(15);
        }

        [TestMethod]
        [ExpectedException(typeof(DeleteNotExistingElementException))]
        public void DeleteNotExistingElementTest()
        {
            var list = new MyUniqueList<int>();
            list.AddElement(21);
            list.AddElement(15);
            list.DeleteElement(10);
        }
    }
}
