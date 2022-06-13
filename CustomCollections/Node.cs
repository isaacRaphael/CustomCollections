namespace CustomCollections
{
    
        public class Node<T>
        {
            public Node(T value)
            {
                data = value;
                next = null;
            }
            public Node<T> next;
            public T data;
        }
    
}
