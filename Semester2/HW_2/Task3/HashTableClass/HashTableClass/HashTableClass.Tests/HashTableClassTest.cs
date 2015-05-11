using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashTableClass.Tests
{
    [TestClass]
    public class HashTableClassTest
    {
        [TestMethod]
        public void AddElementsTest()
        {
            HashTable hashTable = new HashTable();
            hashTable.AddHashElement("privet");
            hashTable.AddHashElement("yaSdam");
            hashTable.AddHashElement("progu");
            bool firstResult = hashTable.IsElementInHashTable("privet");
            bool secondResult = hashTable.IsElementInHashTable("yaSdam");
            bool thirdResult = hashTable.IsElementInHashTable("progu");
            Assert.AreEqual(true, firstResult);
            Assert.AreEqual(true, secondResult);
            Assert.AreEqual(true, thirdResult);
        }

        [TestMethod]
        public void DeleteElementsTest()
        {
            HashTable hashTable = new HashTable(30);
            hashTable.AddHashElement("privet");
            hashTable.AddHashElement("yaNeSdam");
            hashTable.AddHashElement("progu");
            hashTable.DeleteElement("yaNeSdam");
            Assert.AreEqual(false, hashTable.IsElementInHashTable("yaNeSdam"));
        }

        [TestMethod]
        public void BelongingElementWithoutAddTest()
        {
            HashTable hashTable = new HashTable();
            Assert.AreEqual(false, hashTable.IsElementInHashTable("Netu"));
            Assert.AreEqual(false, hashTable.IsElementInHashTable("dazheNeIshi"));
        }
    }
}