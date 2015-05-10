using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StackClass.Tests
{
    [TestClass]
    public class StackClassTest
    {
        [TestMethod]
        public void IsStackEmptyTest()
        {
            Stack stack = new Stack();
            stack.Push(2);
            stack.Pop();
            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void PopOneElementTest()
        {
            Stack stack = new Stack();
            stack.Push(14);
            int result = stack.Pop();
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        public void PopTwoElementsTest()
        {
            Stack stack = new Stack();
            stack.Push(14);
            stack.Push(33);
            int result = stack.Pop();
            Assert.AreEqual(33, result);
            result = stack.Pop();
            Assert.AreEqual(14, result);
        }

        [TestMethod]
        [ExpectedException(typeof(System.NullReferenceException))]
        public void PopWithoutPushTest()
        {
            Stack stack = new Stack();
            stack.Pop();
        }
    }
}
