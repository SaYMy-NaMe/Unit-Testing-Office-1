using System; 

namespace Prime.Services
{
    public class Stack<T>
    {
        private List<T> _items = new List<T>();

        public void Push(T item)
        {
            _items.Add(item); 
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack underflow");

            var item = _items[_items.Count - 1];
            _items.RemoveAt(_items.Count - 1);
            return item;
        }

        public T Top()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack underflow");

            return _items[_items.Count - 1];
        }

        public bool IsEmpty()
        {
            return _items.Count == 0;
        }

        public int Size()
        {
            return _items.Count;
        }
    }
}
