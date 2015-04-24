using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_BubbleSortGenMethod.Tests
{
    [TestClass]
    public class BubbleSortGenMethodTest
    {
        [TestMethod]
        public void BubbleSortIntTest()
        {
            const int sizeOfList = 5;
            List<int> list = new List<int>(sizeOfList);
            list.Add(0);
            list.Add(-2);
            list.Add(-5);
            list.Add(7);
            list.Add(6);
            List<int> needList = new List<int>(list);
            needList.Sort();
            Comparer<int> comparer = Comparer<int>.Default;
            Test_BubbleSortGenMethod.Program.BubbleSort<int>(list, comparer);
            for (int i = 0; i != sizeOfList; ++i)
            {
                Assert.AreEqual(needList[i], list[i]);
            }
        }

        [TestMethod]
        public void BubbleSortStringTest()
        {
            const int sizeOfList = 7;
            List<string> list = new List<string>(sizeOfList);
            list.Add("cbba");
            list.Add("aaaa");
            list.Add("aaba");
            list.Add("cabb");
            list.Add("aaaaa");
            list.Add("babc");
            list.Add("cabb");
            List<string> needList = new List<string>(list);
            needList.Sort();
            Comparer<string> comparer = Comparer<string>.Default;
            Test_BubbleSortGenMethod.Program.BubbleSort<string>(list, comparer);
            for (int i = 0; i != sizeOfList; ++i)
            {
                Assert.AreEqual(needList[i], list[i]);
            }
        }
    }
}
