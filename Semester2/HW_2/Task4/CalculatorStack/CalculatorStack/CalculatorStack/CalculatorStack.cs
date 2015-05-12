using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStack
{
    public class CalculatorStack
    {
        private IStack<int> stack;

        public CalculatorStack(IStack<int> usingStack)
        {
            stack = usingStack;
        }

        /// <summary>
        /// Check if value is operator.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsOperator(string value)
        {
            return (value == "+" || value == "-" || value == "*" || value == "/");
        }

        /// <summary>
        /// Check if value is number.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool IsNumber(string value)
        {
            try
            {
                Convert.ToInt32(value);
            }
            catch (FormatException)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Count expression with operation and two numbers in top of stack.
        /// </summary>
        /// <param name="operation"></param>
        private void CountIt(char operation)
        {
            int firstNumber = stack.Pop();
            int secondNumber = stack.Pop();

            switch (operation)
            {
                case '+':
                    stack.Push(firstNumber + secondNumber);
                    break;
                case '-':
                    stack.Push(firstNumber - secondNumber);
                    break;
                case '*':
                    stack.Push(firstNumber * secondNumber);
                    break;
                case '/':
                    if (secondNumber == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    stack.Push(firstNumber / secondNumber);
                    break;
            }
        }

        /// <summary>
        /// Add operator or operand.
        /// </summary>
        /// <param name="value"></param>
        public void AddValue(string value)
        {
            if (IsNumber(value))
            {
                stack.Push(Convert.ToInt32(value));
                return;
            }

            if (IsOperator(value))
            {
                CountIt(value[0]);
                return;
            }

            throw new AddedWrongValueToCalc("Trying to add not operand or operator.");
        }

        /// <summary>
        /// Take current expression.
        /// </summary>
        /// <returns></returns>
        public int TakeCurrentExpression()
        {
            return stack.Pop();
        }
    }
}
