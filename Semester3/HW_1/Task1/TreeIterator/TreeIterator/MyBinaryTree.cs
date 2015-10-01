using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeIterator
{
    public class MyBinaryTree<T> : IEnumerable<T>
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

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new MyBinaryTreeEnum(this);
        }

        private class MyBinaryTreeEnum : IEnumerator<T>
        {
            private MyBinaryTree<T> tree;
            private TreeElement currentElement = null;
 //           private MyStack<TreeElement> stack;
            private MyLinkedList<TreeElement> list;

            public MyBinaryTreeEnum(MyBinaryTree<T> tree)
            {
                this.tree = tree;
            }

            //private void MoveElementToStack(TreeElement treeElement)
            //{
            //    stack.Push(treeElement);
            //    if (treeElement.Left != null)
            //    {
            //        MoveElementToStack(treeElement.Left);
            //    }
            //    if (treeElement.Right != null)
            //    {
            //        MoveElementToStack(treeElement.Right);
            //    }
            //}

            private void MoveElementToList(TreeElement treeElement)
            {
                list.AddElement(treeElement);
                if (treeElement.Left != null)
                {
                    MoveElementToList(treeElement.Left);
                }
                if (treeElement.Right != null)
                {
                    MoveElementToList(treeElement.Right);
                }
            }

            public bool MoveNext()
            {
                //if (stack.IsEmpty())
                //{
                //    currentElement = stack.head;
                //}
                //else
                //{
                //    currentElement = stack.Pop();
                //}
                //return currentElement != null;
                if (currentElement == null)
                {
                    currentElement = list.GetValueOfHead();
                }
                else
                {
                    currentElement = ;
                }
            }

            public void Reset()
            {
                currentElement = null;
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
