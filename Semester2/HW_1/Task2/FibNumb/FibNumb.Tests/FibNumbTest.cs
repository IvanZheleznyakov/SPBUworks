using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibNumb.Tests
{
    [TestClass]
    public class FibNumbTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, FibNumb.Program.FibNumb(1));
            Assert.AreEqual(1, FibNumb.Program.FibNumb(2));
            Assert.AreEqual(55, FibNumb.Program.FibNumb(10));
            Assert.AreEqual(6765, FibNumb.Program.FibNumb(20));
        }
    }
}
