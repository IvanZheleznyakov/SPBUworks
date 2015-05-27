using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FoldFunction.Tests
{
    [TestClass]
    public class FoldFunctionTest
    {
        [TestMethod]
        public void AddSubstrTest()
        {
            var list = new List<string>();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            Assert.AreEqual("0123", FoldFunction<string>.Fold(list, "0", (x, y) => x + y));
        }
    }
}
