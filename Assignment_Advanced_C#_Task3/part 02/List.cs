using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Advanced_C__Task3.part_02
{
    public class List<T>
    {
        private T[] _items;
        private int _count;

        public List()
        {
            _items = new T[4];
            _count = 0;
        }

        public List(int capacity)
        {
            _items = new T[capacity];
            _count = 0;
        }

        public List(IEnumerable<T> collection)
        {
            _items = new T[collection.Count()];
            _count = 0;
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public int Count => _count;

        public int Capacity => _items.Length;

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= _count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                    throw new ArgumentOutOfRangeException(nameof(index));
                _items[index] = value;
            }
        }

        public bool Exists(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                    return true;
            }
            return false;
        }

        public T Find(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                    return _items[i];
            }
            return default;
        }

        public List<T> FindAll(Predicate<T> match)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                    result.Add(_items[i]);
            }
            return result;
        }

        public int FindIndex(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
            {
                if (match(_items[i]))
                    return i;
            }
            return -1;
        }

        public T FindLast(Predicate<T> match)
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                    return _items[i];
            }
            return default;
        }

        public int FindLastIndex(Predicate<T> match)
        {
            for (int i = _count - 1; i >= 0; i--)
            {
                if (match(_items[i]))
                    return i;
            }
            return -1;
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < _count; i++)
            {
                action(_items[i]);
            }
        }

        public bool TrueForAll(Predicate<T> match)
        {
            for (int i = 0; i < _count; i++)
            {
                if (!match(_items[i]))
                    return false;
            }
            return true;
        }

        public void Add(T item)
        {
            if (_count == _items.Length)
                Resize(_items.Length * 2);
            _items[_count++] = item;
        }

        private void Resize(int newCapacity)
        {
            T[] newItems = new T[newCapacity];
            Array.Copy(_items, 0, newItems, 0, _count);
            _items = newItems;
        }
    }
}
