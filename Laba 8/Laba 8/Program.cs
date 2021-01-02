using System;
using System.Collections.Generic;
using System.IO;

namespace Laba_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {3, 5, 9, 14, 18, 11};
            List<int> numbers_2 = new List<int> { 30, 50, 90, 15, 19, 17 };
            List<float> floatNumbers = new List<float> { 3.23F, 5.67F, 9.28F, 14.21F, 18.74F, 11.91F };
            List<string> strings = new List<string> { "Pavel", "Victor", "Adam", "Alex", "Dean", "Dmytro"};
            CollectionType<int> Something = new CollectionType<int>(numbers);
            CollectionType<int> SomethingElse = new CollectionType<int>(numbers_2);
            CollectionType<float> AnythingElse = new CollectionType<float>(floatNumbers);
            CollectionType<string> Somebody = new CollectionType<string>(strings);
            Something.add(Something, SomethingElse);
            Somebody.delete(Somebody, "Adam");
            AnythingElse.watch(AnythingElse);
            string way = @"D:\file.txt";
            using (StreamWriter writer = new StreamWriter(way, false, System.Text.Encoding.Default)) 
            {
                foreach (var el in Somebody.collection)
                {
                    writer.WriteLine(el);
                }
            }
            using (StreamReader reader = new StreamReader(way, System.Text.Encoding.Default))
            {
                string str ;
                while ((str = reader.ReadLine())!= null )
                {
                    Console.WriteLine(str);
                }
            }
        }

    }

    interface ISomeInterface<T>
    {
        void add(CollectionType<T> element, CollectionType<T>  element_2)
        {

        }

        void delete(CollectionType<T> element, T element_2)
        {

        }

        void watch(CollectionType<T> element)
        {

        }
    }
    public class CollectionType<T> : ISomeInterface<T>
    {
        public List<T> collection { get; set; }

        public CollectionType(List<T> Collection)
        {
            collection = Collection;
        }
        public void add(CollectionType<T> element, CollectionType<T> element_2)
        {
            foreach(var el in element_2.collection)
            {
                element.collection.Add(el); 
            }
        }

        public void delete(CollectionType<T> element, T element_2)
        {
            element.collection.Remove(element_2);
        }

        public void watch(CollectionType<T> element)
        {
            foreach (var el in element.collection)
            {
                Console.WriteLine(el);
            }
        }
    }
}
