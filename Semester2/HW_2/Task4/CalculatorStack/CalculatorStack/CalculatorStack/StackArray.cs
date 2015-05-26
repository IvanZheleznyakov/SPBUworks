using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStack
{
    public class StackArray<T>: IStack<T>
    {
        public StackArray(int capacity = 50)
        {
            currentCapacity = capacity;
            array = new T[currentCapacity];
        }

        /// <summary>
        /// Push element to stack.
        /// </summary>
        /// <param name="value"></param>
        public void Push(T value)
        {
            if (numberOfElements + 1 == currentCapacity)
            {
                currentCapacity *= 2;
                Array.Resize<T>(ref array, currentCapacity);
            }
            array[numberOfElements] = value;
            ++numberOfElements;
        }

        /// <summary>
        /// Pop element from stack.
        /// </summary>
        /// <returns></returns>
        public T Pop()
        {
            if (numberOfElements == 0)
            {
                throw new ExtractFromEmptyStackException("You tried to remove element from empty stack.");
            }

            T neededValue = array[numberOfElements - 1];
            --numberOfElements;
            return neededValue;
        }

        /// <summary>
        /// Number of elements in stack.
        /// </summary>
        /// <returns></returns>
        public int CurrentSize()
        {
            return numberOfElements;
        }

        private int numberOfElements = 0;
        private static int currentCapacity = 50;
        public T[] array;
    }
}
