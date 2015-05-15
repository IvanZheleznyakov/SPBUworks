using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExpression
{
    public class Operand: ITreeElement
    {
        public int Value { get; set; }

        public void AddElement(ITreeElement newTreeElement)
        {
            throw new AddToOperandException();
        }

        public int CountIt()
        {
            return Value;
        }

        public string PrintElement()
        {
            return Value.ToString();
        }
    }
}
