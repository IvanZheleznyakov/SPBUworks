using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoldFunction.Tests
{
    [TestClass]
    public class FoldFunctionTest
    {
        [TestMethod]
        public void NegativeNumbersTest()
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(-1);
            list.Add(-2);
            list.Add(2);
            list.Add(-3);
            list = FoldFunction<int>.Fold(list, x => (x < 0));
            Assert.AreEqual(3, list.Count);
            Assert.AreEqual(3, list.Count(x => (x < 0)));
        }
    }
}