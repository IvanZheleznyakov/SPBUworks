using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    ///  Class which includes expression: two numbers and operation.
    /// </summary>
    public class Expression
    {
        public string FirstNumber;
        public string SecondNumber;
        private char Operation;

        /// <summary>
        /// Add number.
        /// </summary>
        /// <param name="number"></param>
        public void Add(string number)
        {
            if (FirstNumber == null)
            {
                FirstNumber = number;
                return;
            }

            SecondNumber = number;
        }

        /// <summary>
        /// Add operation.
        /// </summary>
        /// <param name="operation"></param>
        public void Add(char operation)
        {
            Operation = operation;
        }

        /// <summary>
        /// Clear all fields.
        /// </summary>
        public void Clear()
        {
            FirstNumber = null;
            SecondNumber = null;
            Operation = ' ';
        }

        /// <summary>
        /// Count expression.
        /// </summary>
        /// <returns></returns>
        public string Count()
        {
            if (SecondNumber == null)
            {
                return FirstNumber;
            }

            switch (Operation)
            {
                case '+':
                    FirstNumber = Convert.ToString(Convert.ToDouble(FirstNumber) + Convert.ToDouble(SecondNumber));
                    return FirstNumber;
                case '-':
                    FirstNumber = Convert.ToString(Convert.ToDouble(FirstNumber) - Convert.ToDouble(SecondNumber));
                    return FirstNumber;
                case '*':
                    FirstNumber = Convert.ToString(Convert.ToDouble(FirstNumber) * Convert.ToDouble(SecondNumber));
                    return FirstNumber;
                case '/':
                    if (SecondNumber == "0")
                    {
                        FirstNumber = null;
                        SecondNumber = null;
                        return "Error";
                    }
                    FirstNumber = Convert.ToString(Convert.ToDouble(FirstNumber) / Convert.ToDouble(SecondNumber));
                    return FirstNumber;
                default:
                    return SecondNumber;
            }
        }
    }
}
