using System;

namespace CustomCollections
{

        public class CustomStack<T>
        {
            public Node<T> top;

            public CustomStack()
            {
                top = null;   
            }

            public void Push(T value)
            {
                Node<T> newNode = new Node<T>(value);
                if (top == null)
                {
                    newNode.next = null;
                }
                else
                {
                    newNode.next = top;
                }
                top = newNode;
            }

            public void Pop()
            {
                if (top == null)
                {
                    throw new NotSupportedException();
                }
                top = top.next;
            }

            public T Peek()
            {
                if (top == null)
                {
                    throw new NotSupportedException();
                }

                return top.data;
            }
        }

}
