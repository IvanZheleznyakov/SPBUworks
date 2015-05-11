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
        }
    }
}
            //LinkedList list = new LinkedList();
            //list.AddElement(3);
            //list.AddElement(5);
            //list.AddElement(7);
            //Console.WriteLine(list.RemoveElement());
            //list.AddElement(9);
            //Console.WriteLine(list.RemoveElement());
            //list.AddElement(11);
            //Console.WriteLine(list.RemoveElement());
            //Console.WriteLine(list.RemoveElement());
            //Console.WriteLine(list.RemoveElement());
            //Console.WriteLine(list.RemoveElement());