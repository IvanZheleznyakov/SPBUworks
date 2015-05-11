using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableClass
{
    class HashTable
    {
        HashTable(int capacity = 50)
        {
            Capacity = capacity;
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
            HashTable[index].AddUniqueElement(value);
        }

        /// <summary>
        /// Check if element with specified value in hashtable.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsElementInHashTable(string value)
        {
            int index = HashFunction(value);
            return HashTable[index].IsElementInList(value);
        }
        public static int Capacity { get; private set; }
        public LinkedList<string>[] HashTable = new LinkedList<string>[Capacity];
    }
}
