using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableClass
{
    class LinkedList<T>
    {
        class ListElement
        {
            public T Value { get; set; }
            public ListElement Next { get; set; }
        }

        /// <summary>
        /// Add element to list.
        /// </summary>
        /// <param name="value"></param>
        public void AddElement(T value)
        {
            var newElement = new ListElement()
            {
                Value = value,
                Next = null
            };

            if (head == null)
            {
                head = newElement;
                return;
            }

            ListElement currentElement = head;
            while (currentElement.Next != null)
            {
                currentElement = currentElement.Next;
            }
            currentElement.Next = newElement;     
        }

        /// <summary>
        /// Add element if it is not in list.
        /// </summary>
        /// <param name="value"></param>
        public void AddUniqueElement(T value)
        {
            var newElement = new ListElement()
            {
                Value = value,
                Next = null
            };

            if (head == null)
            {
                head = newElement;
                return;
            }

            ListElement currentElement = head;
            Comparer<T> comparer = Comparer<T>.Default;
            while (currentElement.Next != null && comparer.Compare(currentElement.Value, value) != 0)
            {
                currentElement = currentElement.Next;
            }
            if (comparer.Compare(currentElement.Value, value) == 0)
            {
                return;
            }
            currentElement.Next = newElement;     
        }

        /// <summary>
        /// Remove element from list.
        /// </summary>
        /// <returns></returns>
        public T RemoveElementFromTail()
        {
            if (head == null)
            {
                throw new RemoveFromEmptyListException("You tried to remove element from empty list.");
            }

            T neededValue;

            if (head.Next == null)
            {
                neededValue = head.Value;
                head = null;
                return neededValue;
            }

            ListElement currentElement = head;
            while (currentElement.Next.Next != null)
            {
                currentElement = currentElement.Next;
            }
            neededValue = currentElement.Next.Value;
            currentElement.Next = null;
            return neededValue;
        }

        /// <summary>
        /// Delete element with specified value from list if it is in list.
        /// </summary>
        /// <param name="value"></param>
        public void DeleteElement(T value)
        {
            if (head == null)
            {
                return;
            }

            Comparer<T> comparer = Comparer<T>.Default;
            if (comparer.Compare(head.Value, value) == 0)
            {
                head = head.Next;
            }

            ListElement currentElement = head;
            while (comparer.Compare(currentElement.Next.Value, value) != 0)
            {
                currentElement = currentElement.Next;
            }
            currentElement.Next = currentElement.Next.Next;
        }

        /// <summary>
        /// Check if element with specified value in list.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsElementInList(T value)
        {
            var currentElement = head;
            Comparer<T> comparer = Comparer<T>.Default;
            while (currentElement!=null && comparer.Compare(currentElement.Value, value) != 0)
            {
                currentElement = currentElement.Next;
            }
            return currentElement != null;
        }

        private ListElement head = null;
    }
}
