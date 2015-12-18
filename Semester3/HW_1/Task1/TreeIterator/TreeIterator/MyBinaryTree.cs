using System.Collections;
using System.Collections.Generic;

namespace TreeIterator
{
    /// <summary>
    /// Binary Tree Class.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class MyBinaryTree<T> : IEnumerable<T>
    {
        /// <summary>
        /// Element that contains in tree.
        /// </summary>
        private class TreeElement
        {
            public T Value { get; set; }
            public TreeElement Left { get; set; }
            public TreeElement Right { get; set; }
        }

        private TreeElement head = null;

        /// <summary>
        /// Add element to tree.
        /// </summary>
        /// <param name="value"></param>
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        /// <summary>
        /// Get enumerator for that tree.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            return new MyBinaryTreeEnum(this);
        }

        private class MyBinaryTreeEnum : IEnumerator<T>
        {
            private MyBinaryTree<T> tree;
            private TreeElement currentElement = null;
            private MyStack<TreeElement> stack;

            public MyBinaryTreeEnum(MyBinaryTree<T> tree)
            {
                this.tree = tree;
                stack = new MyStack<TreeElement>();
                stack.Push(tree.head);
            }

            public bool MoveNext()
            {
                if (stack.IsEmpty())
                {
                    return false;
                }
                else
                {
                    currentElement = stack.Pop();
                    if (currentElement.Left != null)
                    {
                        stack.Push(currentElement.Left);
                    }

                    if (currentElement.Right != null)
                    {
                        stack.Push(currentElement.Right);
                    }

                    return true;
                }
            }

            public void Reset()
            {
                stack.Clear();
                stack.Push(tree.head);
            }

            public object Current
            {
                get { return currentElement.Value; }
            }

            T IEnumerator<T>.Current
            {
                get { return currentElement.Value; }
            }

            public void Dispose()
            {

            }
        }
    }
}
