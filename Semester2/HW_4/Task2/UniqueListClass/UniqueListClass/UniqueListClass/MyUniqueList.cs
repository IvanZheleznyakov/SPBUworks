using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueListClass
{
    public class MyUniqueList<T>: MyLinkedList<T>
    {
        class ListElement
        {
            public T Value { get; set; }
            public ListElement Next { get; set; }
        }

        /// <summary>
        /// Add element if it is not in list.
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

            Comparer<T> comparer = Comparer<T>.Default;

            if (comparer.Compare(head.Value, value) == 0)
            {
                return;
            }

            var currentElement = head;
            while (currentElement.Next != null)
            {
                if (comparer.Compare(currentElement.Next.Value, value) == 0)
                {
                    throw new AddExistingElementException("You tried to add existing element in unique list");
                }
                currentElement = currentElement.Next;
            }
            currentElement.Next = newElement;
        }

        /// <summary>
        /// Remove element from list.
        /// </summary>
        /// <returns></returns>
        public T RemoveElement()
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

            var currentElement = head;
            while (currentElement.Next.Next != null)
            {
                currentElement = currentElement.Next;
            }
            neededValue = currentElement.Next.Value;
            currentElement.Next = null;
            return neededValue;
        }

        /// <summary>
        /// Delete element with specified value from list.
        /// </summary>
        /// <param name="value"></param>
        public void DeleteElement(T value)
        {
            if (head == null)
            {
                throw new DeleteNotExistingElementException("You tried to delete not existing element in unique list.");
            }

            Comparer<T> comparer = Comparer<T>.Default;
            if (comparer.Compare(head.Value, value) == 0)
            {
                head = null;
                return;
            }

            var currentElement = head;
            while (currentElement.Next != null && comparer.Compare(currentElement.Next.Value, value) != 0)
            {
                currentElement = currentElement.Next;
            }
            if (currentElement.Next != null)
            {
                currentElement.Next = currentElement.Next.Next;
                return;
            }

            throw new DeleteNotExistingElementException("You tried to delete not existing element in unique list.");
        }

        private ListElement head = null;
    }
}
