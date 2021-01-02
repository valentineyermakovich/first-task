using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Laba10
{
    public class Book : IBook, IDictionary<int,string>
    {
        private readonly string _author;
        private readonly string _name;
        private readonly IDictionary<int, string> _pages;

        public Book(string author, string name)
        {
            this._author = author ?? throw new ArgumentException(nameof(author));
            this._name = name ?? throw new ArgumentException(nameof(name));
            this._pages = new Dictionary<int, string>();
        }

        public string GetAuthor()
        {
            return this._author;
        }

        public string GetName()
        {
            return this._name;
        }

        public void Add(KeyValuePair<int, string> item)
        {
            if (!this._pages.ContainsKey(item.Key))
            {
                this._pages.Add(item);
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(KeyValuePair<int, string> item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(KeyValuePair<int, string>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(KeyValuePair<int, string> item)
        {
            throw new NotImplementedException();
        }

        public int Count { get; }
        public bool IsReadOnly { get; }

        public void Add(int key, string value)
        {
            if (!this._pages.ContainsKey(key))
            {
                this._pages.Add(key,value);
            }
        }

        public bool ContainsKey(int key)
        {
            throw new NotImplementedException();
        }

        public bool Remove(int key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(int key, out string value)
        {
            throw new NotImplementedException();
        }

        public string this[int key]
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public ICollection<int> Keys { get; }
        public ICollection<string> Values { get; }

        public IEnumerator<KeyValuePair<int, string>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
