using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MapFunction.Tests
{
    [TestClass]
    public class MapFunctionTest
    {
        [TestMethod]
        public void MultiplyIntTest()
        {
            var list = new List<int>();
            list.Add(3);
            list.Add(6);
            list.Add(0);
            list.Add(-10);
            list = MapFunction<int>.Map(list, x => x * 2);
            Assert.AreEqual(6, list[0]);
            Assert.AreEqual(12, list[1]);
            Assert.AreEqual(0, list[2]);
            Assert.AreEqual(-20, list[3]);
        }

        [TestMethod]
        public void AddSubstringTest()
        {
            var list = new List<string>();
            list.Add("one");
            list.Add("two");
            list.Add("MILLION");
            list = MapFunction<string>.Map(list, x => x + "substr");
            Assert.AreEqual("onesubstr", list[0]);
            Assert.AreEqual("twosubstr", list[1]);
            Assert.AreEqual("MILLIONsubstr", list[2]);
        }
    }
}
