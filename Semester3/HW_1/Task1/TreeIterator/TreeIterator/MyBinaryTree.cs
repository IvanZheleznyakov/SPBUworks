using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIterator
{
    public class MyBinaryTree<T>
    {
        private class TreeElement
        {
            public T Value { get; set; }
            public TreeElement Left { get; set; }
            public TreeElement Right { get; set; }
        }

        private TreeElement head = null;

        public void AddElement(T value)
        {
            var newElement = new TreeElement()
            {
                Value = value,
                Left = null,
                Right = null
            };

            if (head == null)
            {
                head = newElement;
                return;
            }

            var currentElement = head;
            Comparer<T> comparer = Comparer<T>.Default;
            
            while (currentElement != null)
            {
                if (comparer.Compare(newElement.Value, currentElement.Value) <= 0)
                {
                    if (currentElement.Left == null)
                    {
                        currentElement.Left = newElement;
                        return;
                    }
                    currentElement = currentElement.Left;
                }
                else
                {
                    if (currentElement.Right == null)
                    {
                        currentElement.Right = newElement;
                        return;
                    }
                    currentElement = currentElement.Right;
                }
            }

            if (comparer.Compare(newElement.Value, head.Value) <= 0)
            {
                head.Left = newElement;
                return;
            }
            head.Right = newElement;
        }
    }
}
