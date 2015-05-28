using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SetADT.Tests
{
    [TestClass]
    public class SetADTTest
    {
        [TestMethod]
        public void AddTest()
        {
            var set = new Set<int>();
            set.AddElement(2);
            set.AddElement(1);
            Assert.AreEqual(true, set.IsInSet(2));
            Assert.AreEqual(true, set.IsInSet(1));
        }

        [TestMethod]
        public void DeleteTest()
        {
            var set = new Set<int>();
            set.AddElement(2);
            set.AddElement(1);
            set.DeleteElement(2);
            Assert.AreEqual(false, set.IsInSet(2));
            Assert.AreEqual(false, set.IsInSet(-2));
        }

        [TestMethod]
        public void UnionTest()
        {
            var firstSet = new Set<int>();
            var secondSet = new Set<int>();
            firstSet.AddElement(1);
            firstSet.AddElement(3);
            firstSet.AddElement(5);
            secondSet.AddElement(2);
            secondSet.AddElement(4);
            var resultTest = Set<int>.Union(firstSet, secondSet);
            Assert.AreEqual(true, resultTest.IsInSet(1));
            Assert.AreEqual(true, resultTest.IsInSet(2));
            Assert.AreEqual(true, resultTest.IsInSet(3));
            Assert.AreEqual(true, resultTest.IsInSet(4));
            Assert.AreEqual(true, resultTest.IsInSet(5));
        }

        [TestMethod]
        public void IntersectionTest()
        {
            var firstSet = new Set<int>();
            var secondSet = new Set<int>();
            firstSet.AddElement(3);
            firstSet.AddElement(1);
            firstSet.AddElement(2);
            firstSet.AddElement(5);
            secondSet.AddElement(5);
            secondSet.AddElement(1);
            var resultTest = Set<int>.Intersection(firstSet, secondSet);
            Assert.AreEqual(true, resultTest.IsInSet(1));
            Assert.AreEqual(false, resultTest.IsInSet(2));
            Assert.AreEqual(false, resultTest.IsInSet(4));
            Assert.AreEqual(true, resultTest.IsInSet(5));
        }
    }
}
