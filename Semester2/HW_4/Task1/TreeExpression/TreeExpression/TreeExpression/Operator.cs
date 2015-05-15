using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExpression
{
    public class Operator: ITreeElement
    {
        public char Value { get; set; }
        public ITreeElement Left { get; set; }
        public ITreeElement Right { get; set; }

        /// <summary>
        /// Add element to this operator.
        /// </summary>
        /// <param name="newTreeElement"></param>
        public void AddElement(ITreeElement newTreeElement, ref bool elementIsAdded)
        {
            if (!elementIsAdded)
            {
                if (Left == null)
                {
                    Left = newTreeElement;
                    elementIsAdded = true;
                    return;
                }

                if (Left is Operator)
                {
                    Left.AddElement(newTreeElement, ref elementIsAdded);
                }
            }

            if (!elementIsAdded)
            {
                if (Right == null)
                {
                    Right = newTreeElement;
                    elementIsAdded = true;
                    return;
                }

                if (Right is Operator)
                {
                    Right.AddElement(newTreeElement, ref elementIsAdded);
                }
            }
        }

        /// <summary>
        /// Count this element.
        /// </summary>
        /// <returns></returns>
        public int CountIt()
        {
            switch (Value)
            {
                case '+':
                    return (Left.CountIt() + Right.CountIt());
                case '-':
                    return (Left.CountIt() - Right.CountIt());
                case '*':
                    return (Left.CountIt() * Right.CountIt());
                case '/':
                    return (Left.CountIt() / Right.CountIt());
                default:
                    throw new WrongOperatorException();
            }
        }

        /// <summary>
        /// Print operator with him operands.
        /// </summary>
        /// <returns></returns>
        public string PrintElement()
        {
            return "(" + Left.PrintElement() + " " + Value.ToString() + " " + Right.PrintElement() + ")";
        }
    }
}