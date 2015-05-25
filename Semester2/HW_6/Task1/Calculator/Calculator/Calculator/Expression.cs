using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Expression
    {
        private string FirstNumber;
        private string SecondNumber;
        private char Operation;

        public void Add(string number)
        {
            if (FirstNumber == null)
            {
                FirstNumber = number;
                return;
            }

            SecondNumber = number;
        }

        public void Add(char operation)
        {
            Operation = operation;
        }

        public void Clear()
        {
            FirstNumber = "0";
            SecondNumber = null;
        }

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
