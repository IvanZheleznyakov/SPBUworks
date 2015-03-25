using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simpleFactorial;

namespace simpleFactorial.Tests
{
    [TestClass]
    public class simpleFactorialTest
    {
        [TestMethod]
        public void FactorialTest()
        {
            Assert.AreEqual(1, simpleFactorial.Program.Factorial(1));
            Assert.AreEqual(24, simpleFactorial.Program.Factorial(4));
        }
    }
}