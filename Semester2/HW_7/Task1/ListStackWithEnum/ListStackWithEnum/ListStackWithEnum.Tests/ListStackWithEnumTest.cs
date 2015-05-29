using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListStackWithEnum.Tests
{
    [TestClass]
    public class ListStackWithEnumTest
    {
        [TestMethod]
        public void ForeachTest()
        {
            var firstList = new MyLinkedList<int>();
            var secondList = new MyLinkedList<int>();
            firstList.AddElement(1);
            firstList.AddElement(3);
            firstList.AddElement(2);
            firstList.AddElement(4);
            foreach (int x in firstList)
            {
                secondList.AddElement(x);
            }
            Assert.AreEqual(true, secondList.IsElementInList(1));
            Assert.AreEqual(true, secondList.IsElementInList(2));
            Assert.AreEqual(true, secondList.IsElementInList(3));
            Assert.AreEqual(true, secondList.IsElementInList(4));
            Assert.AreEqual(false, secondList.IsElementInList(5));
        }
    }
}
