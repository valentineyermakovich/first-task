using System;
using static Laba14.Serializer;

namespace Laba14
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Choose an operation:\n" +
                                  "1 - XML Serialization\n" +
                                  "2 - JSON Serialization\n" +
                                  "3 - Binary Serialization\n" +
                                  "4 - Array of Objects\n" +
                                  "5 - XPath\n" +
                                  "6 - LINQ to XML\n" +
                                  "0 - Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Serialization using the XML");
                        XML();
                        break;
                    case 2:
                        Console.WriteLine("Serialization using the JSON");
                        JSON();
                        break;
                    case 3:
                        Console.WriteLine("Serialization using the Binary");
                        Binary();
                        break;
                    case 4:
                        Console.WriteLine("Array Serialization");
                        ArraySerialization();
                        break;
                    case 5:
                        xPath();
                        break;
                    case 6:
                        LtoX();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("No such operation");
                        break;
                }
            } while (choice != 0);
        }
    }
}