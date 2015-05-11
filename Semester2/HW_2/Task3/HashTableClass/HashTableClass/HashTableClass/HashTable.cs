using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableClass
{
    public class HashTable
    {
        public HashTable(int capacity = 50)
        {
            Capacity = capacity;
            LinkedList<string>[] HashTableArray = new LinkedList<string>[Capacity];
        }

        /// <summary>
        /// Value of hash function for specified string.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int HashFunction(string value)
        {
            int result = 0;
            for (int i = 0; i != value.Length; ++i)
            {
                result += (int)value[i];
            }
            return result % Capacity;
        }

        /// <summary>
        /// Add element to hashtable.
        /// </summary>
        /// <param name="value"></param>
        public void AddHashElement(string value)
        {
            int index = HashFunction(value);
            HashTableArray[index].AddUniqueElement(value);
        }

        /// <summary>
        /// Delete element with specified value from hashtable.
        /// </summary>
        /// <param name="value"></param>
        public void DeleteElement(string value)
        {
            int index = HashFunction(value);
            HashTableArray[index].DeleteElement(value);
        }

        /// <summary>
        /// Check if element with specified value in hashtable.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsElementInHashTable(string value)
        {
            int index = HashFunction(value);
            return HashTableArray[index].IsElementInList(value);
        }
        public static int Capacity { get; private set; }
        public LinkedList<string>[] HashTableArray;
    }
}
