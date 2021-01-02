using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace Laba10
{
    public class BookCollection<T> where T : IBook

    {
        private List<T> _books;

        public BookCollection()
        {
            _books =  new List<T>();
        }

        public void AddBook(T book)
        {
            if (!this._books.Contains(book))
            {
                this._books.Add(book);
            }
        }
        public void DelBook(T book)
        {
            if (this._books.Contains(book))
            {
                this._books.Remove(book);
            }
        }

        public T FindBook(string name)
        {
            var book = this._books.Find(x => x.GetName() == name);
            return book;
        }

        public void WriteToConsoleIfExist(string name)
        {
            var book = this.FindBook(name);
            if (book != null)
            {
                Console.WriteLine($"{book.GetName()} {book.GetAuthor()}");
            }
            else
            {
                Console.WriteLine("Book is not found");
            }
        }
    }


}
