using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIterator
{
    public class MyLinkedList<T> : IEnumerable<T>
    {
        class ListElement
        {
            public T Value { get; set; }
            public ListElement Next { get; set; }
        }

        /// <summary>
        /// Get value of head.
        /// </summary>
        /// <returns></returns>
        public T GetValueOfHead()
        {
            return head.Value;
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

            var currentElement = head;
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
                    return;
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
                throw new RemoveFromEmptyListException();
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
                return;
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
            if (currentElement != null)
            {
                currentElement.Next = currentElement.Next.Next;
            }
        }

        /// <summary>
        /// Check if element with specified value is in list.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsElementInList(T value)
        {
            if (head == null)
            {
                return false;
            }

            Comparer<T> comparer = Comparer<T>.Default;
            if (comparer.Compare(head.Value, value) == 0)
            {
                return true;
            }

            var currentElement = head;
            while (currentElement.Next != null)
            {
                if (comparer.Compare(currentElement.Next.Value, value) == 0)
                {
                    return true;
                }
                currentElement = currentElement.Next;
            }

            return false;
        }

        /// <summary>
        /// Check if list is empty.
        /// </summary>
        public bool IsEmpty()
        {
            return head == null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyLinkedListEnum(this);
        }

        private class MyLinkedListEnum : IEnumerator<T>
        {
            private MyLinkedList<T> list;
            private ListElement currentElement = null;

            public MyLinkedListEnum(MyLinkedList<T> list)
            {
                this.list = list;
            }

            public bool MoveNext()
            {
                if (currentElement == null)
                {
                    currentElement = list.head;
                }
                else 
                {
                    currentElement = currentElement.Next;
                }
                return currentElement != null;
            }

            public void Reset()
            {
                currentElement = null;
            }

            public object Current
            {
                get { return currentElement.Value; }
            }

            T IEnumerator<T>.Current
            {
                get { return currentElement.Value; }
            }

            public void Dispose()
            {

            }
        }

        private ListElement head = null;
    }
}