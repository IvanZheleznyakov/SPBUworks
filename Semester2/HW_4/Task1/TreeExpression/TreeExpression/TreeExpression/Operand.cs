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

        /// <summary>
        /// Trying to add element to operand.
        /// </summary>
        /// <param name="newTreeElement"></param>
        public void AddElement(ITreeElement newTreeElement)
        {
            throw new AddToOperandException();
        }

        /// <summary>
        /// Count this element, i.e. return value.
        /// </summary>
        /// <returns></returns>
        public int CountIt()
        {
            return Value;
        }

        /// <summary>
        /// Print operand.
        /// </summary>
        /// <returns></returns>
        public string PrintElement()
        {
            return Value.ToString();
        }
    }
}
