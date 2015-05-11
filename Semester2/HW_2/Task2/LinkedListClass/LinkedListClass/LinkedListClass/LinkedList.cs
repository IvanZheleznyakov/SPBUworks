using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListClass
{
    public class LinkedList
    {
        public class ListElement
        {
            public int Value { get; set; }
            public ListElement Next { get; set; }
        }

        /// <summary>
        /// Add element to list.
        /// </summary>
        /// <param name="value"></param>
        public void AddElement(int value)
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
        /// Remove element from list.
        /// </summary>
        /// <returns></returns>
        public int RemoveElement()
        {
            if (head == null)
            {
                throw new RemoveFromEmptyListException("You tried to remove element from empty list.");
            }

            int neededValue;

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
        /// Check if list is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsListEmpty()
        {
            return head == null;
        }

        private ListElement head = null;
    }
}
