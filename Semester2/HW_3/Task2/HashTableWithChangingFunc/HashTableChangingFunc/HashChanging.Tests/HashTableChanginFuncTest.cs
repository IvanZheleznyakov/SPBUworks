using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashChanging.Tests
{
    [TestClass]
    public class HashTableChanginFuncTest
    {
        [TestMethod]
        public void AddElementsTest()
        {
            var hashTable = new HashTableClass.HashTable();
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
            var hashTable = new HashTableClass.HashTable();
            hashTable.AddElement("sdam");
            Assert.AreEqual(false, hashTable.IsElementInHashTable("neSdash"));
        }

        [TestMethod]
        public void DeleteElementTest()
        {
            var hashTable = new HashTableClass.HashTable();
            hashTable.AddElement("deleted");
            hashTable.DeleteElement("deleted");
            Assert.AreEqual(false, hashTable.IsElementInHashTable("deleted"));
        }

        public int TestFunc(string value)
        {
            return 1;
        }

        [TestMethod]
        public void ChangeHashFuncTest()
        {
            var hashTable = new HashTableClass.HashTable(50);
            hashTable.AddElement("a");
            hashTable.ChangeHashFunction(TestFunc);
        }
    }
}
