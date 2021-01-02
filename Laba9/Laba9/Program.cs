using System;
using System.Collections.Generic;


namespace Laba9
{
    class Program
    {
        delegate void UserHandler(int number);
        delegate void StringHandler(string text);

        static void Main(string[] args)
        {
            User somebody = new User(0, 400);
            somebody.Message += Note;
            UserHandler userHandler = somebody.Shift;
            var PrintText = new StringHandler(StringProcessing.PrintText);
            userHandler += somebody.Compression;
            userHandler(4);
            string text = "\nYou're  not  getting  better  with  time  \nIt's  fine,  Eminem,  put  down  the  pen";
            foreach (var word in StringProcessing.WordSpliter(StringProcessing.DeleteDoubleSpaces(StringProcessing.DeleteAllCommas(text))))
            {
                PrintText(StringProcessing.LowerCase(word));
            }
        }
        private static void Note(string msg)
        {
            StringProcessing.PrintText(msg);
        }
    }

    public static class StringProcessing
    {
        public static Func<string, string> DeleteAllCommas = text =>
        {
            while (text.Contains(','))
            {
                text = text.Remove(text.IndexOf(','), 1);
            }
            return text;
        };

        public static Action<string> PrintText = text => Console.WriteLine(text);
        public static Func<string, List<string>> WordSpliter = text => new List<string>(text.Split(" "));
        public static Func<string, string> LowerCase = text => text.ToLower();

        public static Func<string, string> DeleteDoubleSpaces = text =>
        {
            while (text.Contains("  "))
            {
                text = text.Remove(text.IndexOf("  "), 1);
            }
            return text;
        };
    }

    public class User
    {
        public delegate void UserHandle(string txt);
        public event UserHandle Message;
        public static int position { get; set; }
        public static int size { get; set; }

        public User(int Position, int Size)
        {
            size = Size;
            position = Position;
        }

        public void Shift(int shiftNumber)
        {
            position += shiftNumber;
            Message?.Invoke($"Previous position is {position - shiftNumber}, now it is {position}!");
        }

        public void Compression(int compressionNumber)
        {
            size /= compressionNumber;
            Message?.Invoke($"Previous size is {size * compressionNumber}, now it is {size}!");
        }
    }
}