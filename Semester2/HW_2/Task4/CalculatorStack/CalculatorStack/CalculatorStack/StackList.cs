using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStack
{
    public class StackList<T>: IStack<T>
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
            ++numberOfElements;
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
                throw new ExtractFromEmptyStackException("You tried to extract element from empty stack.");
            }
            var temp = head.Value;
            head = head.Next;
            --numberOfElements;
            return temp;
        }

        /// <summary>
        /// Number of elements in stack.
        /// </summary>
        /// <returns></returns>
        public int CurrentSize()
        {
            return numberOfElements;
        }

        /// <summary>
        /// Check if stack is empty.
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }

        private int numberOfElements = 0;
        private StackElement head = null;
    }
}
