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
            usingHashFunc = DefaultHashFunction;
            Capacity = capacity;
            HashTableArray = new MyLinkedList<string>[Capacity];
            for (int i = 0; i != capacity; ++i)
            {
                HashTableArray[i] = new MyLinkedList<string>();
            }
        }

        public HashTable(UsingHashFunction hashFunc, int capacity = 50)
        {
            Capacity = capacity;
            HashTableArray = new MyLinkedList<string>[Capacity];
            for (int i = 0; i != capacity; ++i)
            {
                HashTableArray[i] = new MyLinkedList<string>();
            }
            usingHashFunc = hashFunc;
        }

        /// <summary>
        /// Count default hashfunction for specified value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int DefaultHashFunction(string value)
        {
            int result = 0;
            for (int i = 0; i != value.Length; ++i)
            {
                result += (int)value[i];
            }
            return result % Capacity;
        }

        /// <summary>
        /// Remove all elements from hashtable to list.
        /// </summary>
        private MyLinkedList<string> RemoveElementsToList()
        {
            var list = new MyLinkedList<string>();
            for (int i = 0; i != Capacity; ++i)
            {
                while (!HashTableArray[i].IsEmpty())
                {
                    list.AddElement(HashTableArray[i].RemoveElement());
                }
            }
            return list;
        }

        /// <summary>
        /// Change hashfunction.
        /// </summary>
        /// <param name="hashFunc"></param>
        public void ChangeHashFunction(UsingHashFunction hashFunc)
        {
            var newList = RemoveElementsToList();
            usingHashFunc = hashFunc;
            while (!newList.IsEmpty())
            {
                this.AddElement(newList.RemoveElement());
            }
        }

        /// <summary>
        /// Add element to hashtable.
        /// </summary>
        /// <param name="value"></param>
        public void AddElement(string value)
        {
            int index = usingHashFunc(value);
            HashTableArray[index].AddUniqueElement(value);
        }

        /// <summary>
        /// Delete element with specified value from hashtable.
        /// </summary>
        /// <param name="value"></param>
        public void DeleteElement(string value)
        {
            int index = usingHashFunc(value);
            HashTableArray[index].DeleteElement(value);
        }

        /// <summary>
        /// Check if element with specified value is in list.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsElementInHashTable(string value)
        {
            int index = usingHashFunc(value);
            return HashTableArray[index].IsElementInList(value);
        }

        public delegate int UsingHashFunction(string value);

        private UsingHashFunction usingHashFunc;
        private int Capacity;
        public MyLinkedList<string>[] HashTableArray;
    }
}