using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Microsoft.VisualBasic.CompilerServices;
namespace Laba10
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Valik","Book2");
            BookCollection<Book> collection = new BookCollection<Book>();
            collection.AddBook(book);
            collection.WriteToConsoleIfExist(book.GetName());
            Console.WriteLine("____________________________________________________________");

            collection.DelBook(book);
            collection.WriteToConsoleIfExist(book.GetName());
            Console.WriteLine("____________________________________________________________");

            List<object> someList = new List<object>();
            someList.Add("Something");
            someList.Insert(0, 351);
            someList.Add("Anything");
            someList.Add("Anybody");
            someList.Add(300);
            someList.Remove(300);
            someList.RemoveAt(2);
            Console.WriteLine("FIRST COLLECTION");
            foreach (var item in someList)
            {
                Console.WriteLine(item);
            }
            Queue<object> someQueue = new Queue<object>();
            foreach (var collectionItem in someList)
            {
                someQueue.Enqueue(collectionItem);
            }
            Console.WriteLine("SECOND COLLECTION");
            foreach (var item in someQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("____________________________________________________________");


            ObservableCollection<Book> booksObservableCollection = new ObservableCollection<Book>();
            booksObservableCollection.CollectionChanged += CollectionChanged;
            booksObservableCollection.Add(book);
            booksObservableCollection.Remove(book);
        }

        private static void CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Book b = (Book)e.NewItems[0];
                    Console.WriteLine($"{b.GetName()} is added");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Book b2 = (Book) e.OldItems[0];
                    Console.WriteLine($"{b2.GetName()} is removed");
                    break;
            }
        }
    }
}
