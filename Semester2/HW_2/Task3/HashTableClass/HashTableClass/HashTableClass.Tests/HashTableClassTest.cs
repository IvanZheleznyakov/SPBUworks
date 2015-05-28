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
            var hashTable = new HashTable();
            hashTable.AddElement("privet");
            hashTable.AddElement("yaSdam");
            hashTable.AddElement("progu");
            Assert.AreEqual(true, hashTable.IsElementInHashTable("yaSdam"));
            Assert.AreEqual(true, hashTable.IsElementInHashTable("progu"));
            Assert.AreEqual(true, hashTable.IsElementInHashTable("privet"));
        }

        [TestMethod]
        public void ElementsAbsenceTest()
        {
            var hashTable = new HashTable();
            hashTable.AddElement("sdam");
            Assert.AreEqual(false, hashTable.IsElementInHashTable("neSdash"));
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            var hashTable = new HashTable();
            hashTable.AddElement("deleted");
            hashTable.DeleteElement("deleted");
            Assert.AreEqual(false, hashTable.IsElementInHashTable("deleted"));
        }
    }
}
