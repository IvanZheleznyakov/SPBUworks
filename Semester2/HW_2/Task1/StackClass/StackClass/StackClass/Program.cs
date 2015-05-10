using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackClass
{
    public class Stack
    {
        private class StackElement
        {
            private int _value;
            public int Value
            {
                get
                {
                    return _value;
                }
                set
                {
                    _value = value;
                }
            }
            public StackElement Next { get; set; }
        }

        public void Push(int value)
        {
            var newElement = new StackElement()
            {
                Next = head,
                Value = value
            };
            head = newElement;
        }

        public int Pop()
        {
            if (head == null)
            {
                throw new NullReferenceException();
            }
            var temp = head.Value;
            head = head.Next;
            return temp;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        private StackElement head = null;
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
