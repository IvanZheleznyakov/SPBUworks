﻿using System;
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
            HashTableArray = new MyLinkedList<string>[capacity];
            for (int i = 0; i != capacity; ++i)
            {
                HashTableArray[i] = new MyLinkedList<string>();
            }
        }

        /// <summary>
        /// Count hashfunction for specified value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int HashFunction(string value)
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
        public void AddElement(string value)
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
        /// Check if element with specified value is in list.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsElementInHashTable(string value)
        {
            int index = HashFunction(value);
            return HashTableArray[index].IsElementInList(value);
        }

        private int Capacity;
        private MyLinkedList<string>[] HashTableArray;
    }
}
