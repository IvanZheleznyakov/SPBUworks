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

        public void AddTreeElement(int value)
        {
            var newTreeElement = new Operand()
            {
                Value = value,
            };

            head.AddElement(newTreeElement);
        }

        public int CountTree()
        {
            return head.CountIt();
        }

        public string PrintTree()
        {
            return head.PrintElement();
        }
    }
}
