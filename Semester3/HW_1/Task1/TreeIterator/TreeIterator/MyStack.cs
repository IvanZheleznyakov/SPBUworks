using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIterator
{
    public class MyStack<T>
    {
        private class StackElement
        {
            public T Value { get; set; }
            public StackElement Next { get; set; }
        }

        /// <summary>
        /// Add element to stack.
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            var newElement = new StackElement()
            {
                Next = head,
                Value = value
            };
            head = newElement;
        }

        /// <summary>
        /// Remove element from stack, if it possible.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (head == null)
            {
                throw new ExtractFromEmptyStackException("You tried to extract element from empty stack");
            }
            var temp = head.Value;
            head = head.Next;
            return temp;
        }

        /// <summary>
        /// Check if stack is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }

        private StackElement head = null;
    }
}