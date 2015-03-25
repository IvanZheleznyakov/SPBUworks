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
            Assert.AreEqual(1, FibNumb.Program.fibNumb(1));
            Assert.AreEqual(1, FibNumb.Program.fibNumb(2));
            Assert.AreEqual(55, FibNumb.Program.fibNumb(10));
            Assert.AreEqual(6765, FibNumb.Program.fibNumb(20));
        }
    }
}
