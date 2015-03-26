using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleFactorial;

namespace SimpleFactorial.Tests
{
    [TestClass]
    public class SimpleFactorialTest
    {
        [TestMethod]
        public void factorialTest()
        {
            Assert.AreEqual(1, SimpleFactorial.Program.Factorial(1));
            Assert.AreEqual(24, SimpleFactorial.Program.Factorial(4));
        }
    }
}