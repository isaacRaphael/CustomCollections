namespace CustomCollections
{
    public class DoublyLinkedListNode<T>
    {
        private T _data;
        private DoublyLinkedListNode<T> _next;
        private DoublyLinkedListNode<T> _previous;


        public DoublyLinkedListNode(T data)
        {
            _data = data;
            _next = null;
            _previous = null;
        }

        public DoublyLinkedListNode(T data, DoublyLinkedListNode<T> prevNode)
        {
            _data = data;
            _previous = prevNode;
            _next = this;
        }

        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }

        public DoublyLinkedListNode<T> Next
        {
            get { return _next; }
            set { _next = value; }
        }

        public DoublyLinkedListNode<T> Previous
        {
            get { return _previous; }
            set { _previous = value; }
        }
    }
}



    


