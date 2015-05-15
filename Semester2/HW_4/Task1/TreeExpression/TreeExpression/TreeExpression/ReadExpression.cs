using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExpression
{
    public class ReadExpression
    {
        public static void ReadExpressionFromString(Tree tree, string expression)
        {
            while (expression.Length != 1)
            {
                string OperatorOrOperand = expression.Remove(expression.IndexOf(' '));

                switch (OperatorOrOperand)
                {
                    case "(":
                    case ")":
                        break;
                    case "+":
                    case "-":
                    case "*":
                    case "/":
                        tree.AddTreeElement(OperatorOrOperand[0]);
                        break;
                    default:
                        tree.AddTreeElement(Int32.Parse(OperatorOrOperand));
                        break;
                }

                expression = expression.Remove(0, OperatorOrOperand.Length);
                if (expression.Length != 1)
                {
                    expression = expression.Remove(0, 1);
                }
            }
        }
    }
}
