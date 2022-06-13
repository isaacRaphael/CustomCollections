using System;

namespace CustomCollections
{

        public class CustomLinkedList<T>
        {
            public CustomLinkedList()
            {
               Head = null;
            }
            public T Tail { get => GetLast();  }

            public Node<T> Head;

            public void printAllNodes()
            {
                Node<T> current = Head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }

            public T GetLast()
            {
                Node<T> current = Head;
                while (current.next != null)
                {
                    current = current.next;
                }
                return current.data;
            }


            public void AddFirst(T data)
            {
                Node<T> toAdd = new Node<T>(data);
                toAdd.next = Head;
                Head = toAdd;
            }

            public void AddLast(T data)
            {
                if (Head == null)
                {
                    Head = new Node<T>(data);
                }
                else
                {
                    Node<T> toAdd = new Node<T>(data);
                    Node<T> current = Head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }

                    current.next = toAdd;
                }
            }
        }

}
