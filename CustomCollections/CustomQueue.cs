using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    public class CustomQueue<T>
    {
        Node<T> _front;
        Node<T> _rear;

        public CustomQueue()
        {
           _front = _rear = null;
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if (_rear == null)
            {
                _front = _rear = newNode;
            }
            else
            { 
                _rear.next = newNode;
                _rear = newNode;
            }
        }

        public void Dequeue()
        { 
            if (_front == null)
            {
                return ;
            }
 
            _front = _front.next;
 
            if (_front == null)
            {
                _rear = null;
            }

        }
    }
}
