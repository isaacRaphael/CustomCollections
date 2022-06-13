using System;

namespace CustomCollections
{
    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListNode<T> head;
        private DoublyLinkedListNode<T> tail;
        private int count;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public int Count
        {
            get { return this.count; }
        }

        public T this[int index]
        {
            get
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Out of range!");
                }
                DoublyLinkedListNode<T> currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                return currentNode.Data;
            }
            set
            {
                if (index >= count || index < 0)
                {
                    throw new ArgumentOutOfRangeException("Out of range!");
                }
                DoublyLinkedListNode<T> currentNode = this.head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Data = value;
            }
        }
        public void Add(T item)
        {
            if (this.head == null)
            {
                this.head = new DoublyLinkedListNode<T>(item);
                this.tail = this.head;
            }
            else
            {
                DoublyLinkedListNode<T> newItem = new DoublyLinkedListNode<T>(item, tail);
                this.tail = newItem;
            }
            count++;
        }

        public void Insert(T item, int index)
        {
            count++;
            if (index >= count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Out of range!");
            }
            DoublyLinkedListNode<T> newItem = new DoublyLinkedListNode<T>(item);
            int currentIndex = 0;
            DoublyLinkedListNode<T> currentItem = this.head;
            DoublyLinkedListNode<T> prevItem = null;
            while (currentIndex < index)
            {
                prevItem = currentItem;
                currentItem = currentItem.Next;
                currentIndex++;
            }
            if (index == 0)
            {
                newItem.Previous = this.head.Previous;
                newItem.Next = this.head;
                this.head.Previous = newItem;
                this.head = newItem;
            }
            else if (index == count - 1)
            {
                newItem.Previous = this.tail;
                this.tail.Next = newItem;
                newItem = this.tail;
            }
            else
            {
                newItem.Next = prevItem.Next;
                prevItem.Next = newItem;
                newItem.Previous = currentItem.Previous;
                currentItem.Previous = newItem;
            }
        }

        public void Remove(T item)
        {
            int currentIndex = 0;
            DoublyLinkedListNode<T> currentItem = this.head;
            DoublyLinkedListNode<T> prevItem = null;
            while (currentItem != null)
            {
                if ((currentItem.Data != null &&
                currentItem.Data.Equals(item)) ||
                (currentItem.Data == null) && (item == null))
                {
                    break;
                }
                prevItem = currentItem;
                currentItem = currentItem.Next;
                currentIndex++;
            }
            if (currentItem != null)
            {
                count--;
                if (count == 0)
                {
                    this.head = null;
                }
                else if (prevItem == null)
                {
                    this.head = currentItem.Next;
                    this.head.Previous = null;
                }
                else if (currentItem == tail)
                {
                    currentItem.Previous.Next = null;
                    this.tail = currentItem.Previous;
                }
                else
                {
                    currentItem.Previous.Next = currentItem.Next;
                    currentItem.Next.Previous = currentItem.Previous;
                }
            }
        }

        public void RemoveAt(int index)
        {
            if (index >= this.count || index < 0)
            {
                throw new ArgumentOutOfRangeException("Out of range!");
            }

            int currentIndex = 0;
            DoublyLinkedListNode<T> currentItem = this.head;
            DoublyLinkedListNode<T> prevItem = null;
            while (currentIndex < index)
            {
                prevItem = currentItem;
                currentItem = currentItem.Next;
                currentIndex++;
            }
            if (this.count == 0)
            {
                this.head = null;
            }
            else if (prevItem == null)
            {
                this.head = currentItem.Next;
                this.head.Previous = null;
            }
            else if (index == count - 1)
            {
                prevItem.Next = currentItem.Next;
                tail = prevItem;
                currentItem = null;
            }
            else
            {
                prevItem.Next = currentItem.Next;
                currentItem.Next.Previous = prevItem;
            }
            count--;
        }

        public int indexOf(T item)
        {
            int index = 0;
            DoublyLinkedListNode<T> currentItem = this.head;
            while (currentItem != null)
            {
                if (((currentItem.Data != null) && (item.Equals(currentItem.Data))) ||
                ((currentItem.Data == null) && (item == null)))
                {
                    return index;
                }
                index++;
                currentItem = currentItem.Next;
            }
            return -1;
        }

        public void Clear()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }

        public bool Contains(T element)
        {
            int index = indexOf(element);
            bool contains = (index != -1);
            return contains;
        }
    }
}



    


