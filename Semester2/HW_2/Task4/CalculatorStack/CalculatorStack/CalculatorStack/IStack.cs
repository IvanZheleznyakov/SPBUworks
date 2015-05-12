using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStack
{
    public interface IStack<T>
    {
        /// <summary>
        /// Push element to stack.
        /// </summary>
        /// <param name="value"></param>
        void Push(T value);

        /// <summary>
        /// Pop element from stack.
        /// </summary>
        /// <returns></returns>
        T Pop();

        /// <summary>
        /// Number of elements in stack.
        /// </summary>
        /// <returns></returns>
        int CurrentSize();
    }
}
