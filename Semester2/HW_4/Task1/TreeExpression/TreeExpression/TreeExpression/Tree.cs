using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeExpression
{
    public class Tree
    {
        private Operator head = null;
        
        /// <summary>
        /// Add new operator to tree.
        /// </summary>
        /// <param name="value"></param>
        public void AddTreeElement(char value)
        {
            var newTreeElement = new Operator()
            {
                Value = value,
                Left = null,
                Right = null
            };

            if (head == null)
            {
                head = newTreeElement;
                return;
            }

            head.AddElement(newTreeElement);
        }

        /// <summary>
        /// Add new operand to tree.
        /// </summary>
        /// <param name="value"></param>
        public void AddTreeElement(int value)
        {
            var newTreeElement = new Operand()
            {
                Value = value,
            };

            head.AddElement(newTreeElement);
        }

        /// <summary>
        /// Count expression that is inside tree.
        /// </summary>
        /// <returns></returns>
        public int CountTree()
        {
            return head.CountIt();
        }

        /// <summary>
        /// Print expression that is inside tree.
        /// </summary>
        /// <returns></returns>
        public string PrintTree()
        {
            return head.PrintElement();
        }
    }
}
