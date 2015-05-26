using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    public class Stack
    {
        private class StackElement
        {
            public int Value { get; set; }
            public StackElement Next { get; set; }
        }

        /// <summary>
        /// Add element to stack.
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
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
        public int Pop()
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