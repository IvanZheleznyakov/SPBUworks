using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simpleFactorial;

namespace simpleFactorial.Tests
{
    [TestClass]
    public class simpleFactorialTest
    {
        [TestMethod]
        public void factorialTest()
        {
            Assert.AreEqual(1, simpleFactorial.Program.factorial(1));
            Assert.AreEqual(24, simpleFactorial.Program.factorial(4));
        }
    }
}