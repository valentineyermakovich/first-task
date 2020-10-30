using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace Лаба_2
{
    class Program
    {
        static void Main(string[] args)
    {
           /* int variableInt = 1;
             bool variableBool = true;
             byte variableByte = 4;
             sbyte variableSByte = 6;
             char variableChar = 'j';
             decimal variableDecimal = 3.659M;
             double variableDouble = 2.42;
             float variableFloat = 3.45F;
             uint variableUInt = 2U;
             long variableLong = 4L;
             ulong variableULong = 7UL;
             short variableShort = 9;
             ushort variableUShort = 12;
             Console.WriteLine("int " + variableInt);
                 Console.WriteLine(variableBool);
                 Console.WriteLine(variableByte);
                 Console.WriteLine(variableSByte);
                 Console.WriteLine(variableChar);
                 Console.WriteLine(variableDecimal);
                 Console.WriteLine(variableDouble);
                 Console.WriteLine(variableFloat);
                 Console.WriteLine(variableUInt);
                 Console.WriteLine(variableLong);
                 Console.WriteLine(variableULong);
                 Console.WriteLine(variableShort);
                 Console.WriteLine(variableUShort);
                 */
            /*
             // 5 явных преобразований
             double variableDouble = 4.45;
             long variableLong = 52362;
             int variableInt1;
             int variableInt2;
             short variableShort1;
             short variableShort2;
             float variableFloat;
             variableInt1 = (int)variableDouble;
             variableInt2 = (int)variableLong;
             variableFloat = (float)variableDouble;
             variableShort1 = (short)variableLong;
             variableShort2 = (short)variableInt1;
             Console.WriteLine(variableInt1);
             Console.WriteLine(variableInt2);
             Console.WriteLine(variableFloat);
             Console.WriteLine(variableShort1);
             Console.WriteLine(variableShort2);
             // 5 неявных преобразований
             int num = 372463;
             long num1 = 5467;
             long longNum = num;
             double doubleNum = num;
             float floatNum = num;
             decimal decimalNum = num;
             double doubleNum1 = num1;
             Console.WriteLine(longNum);
             Console.WriteLine(doubleNum);
             Console.WriteLine(floatNum);
             Console.WriteLine(decimalNum);
             Console.WriteLine(doubleNum1);
             // класс Convert
             Convert.ToDecimal(num);
             Console.WriteLine(num);
             */
            // Упаковка, распаковка
            /*
            object pac = 5; //запаковка
            int unpac = (int)pac; //распаковка

            Console.WriteLine($"{pac.GetType()} - тип запакованной переменной, {unpac.GetType()} - тип распакованной переменной");
            */
            // Nullable
            /*
            int? a = null;
            Console.WriteLine($"{a.Value} - значение nullable перемененной а");
            */
            //Ошибка
            /*
            var taskf = -1;
            uint taskf2 = (uint)taskf; //ошибка вызвана невозможностью присвоения данного числа данному типу
            */
            //Сравнение строк
            /*
            string message1 = "hello";
            string message2 = "world";
            int result = string.Compare(message1, message2);

            if (result < 0)
            {
                Console.WriteLine("строки равны");
            }
            else Console.WriteLine("строки не равны");
            */
            //Сцепление,копирование, выделение подстроки, разделение строки на слова, вставки подстроки в заданную позицию, удаление заданной подстроки
            /*
            string task2b1 = "hello ";
            string task2b2 = "world! ";
            string task2b3 = string.Concat(task2b1, task2b2); //объединение
            Console.WriteLine($"{task2b3}");

            string task2b4 = task2b3; //копирование
            Console.WriteLine($"{task2b4} - копированная строка");

            Console.WriteLine(task2b3.Substring(2)); //вывод подстроки

            string[] task2b5 = task2b3.Split(" "); //разбиение на слова
            Console.WriteLine(task2b5);
            */
            // NullOrEmpty
            /*
            string task2c1 = "asd";
            string task2c2 = "";
            string task2c3 = null;           //метод is null or empty
            Console.WriteLine(string.IsNullOrEmpty(task2c1));
            Console.WriteLine(string.IsNullOrEmpty(task2c2));
            Console.WriteLine(string.IsNullOrEmpty(task2c3));
            */
            //StringBuilder
            /*
           StringBuilder sb = new StringBuilder("String Builder", 50);
            Console.WriteLine(sb.Remove(6, 3));
            Console.WriteLine(sb.Append("that's that"));
            Console.WriteLine(sb.Insert(0, "better"));
            */
            //Матрица
           /* int[,] array2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            for (var i = 0; i < array2D.GetLength(0); i++)
            {
                for (var j = 0; j < array2D.GetLength(1); j++)
                {
                    Console.Write($"{array2D[i, j]} ");
                }
                Console.Write("\n");
            }*/
            //-----------------------------Task 3 Part B-------------------------------
            /*string[] strings = words;
            foreach (var word in strings)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine(strings.Length);
            Console.Write("Input a position: ");
            string val = Console.ReadLine();
            int pos = Convert.ToInt32(val);
            Console.Write("Input a string: ");
            string value = Console.ReadLine();
            for (var i = 0; i < strings.Length; i++)
            {
                if (i == pos)
                {
                    strings[i] = value;
                }
            }
            foreach (var word in strings)
            {
                Console.WriteLine(word);
            }*/
            //-----------------------------Task 3 Part C-------------------------------
            /*float[][] jaggedArray = new float[3][];
            jaggedArray[0] = new float[2];
            jaggedArray[1] = new float[3];
            jaggedArray[2] = new float[4];
            for (var i = 0; i < jaggedArray.Length; i++)
            {
                for (var j = 0; j < jaggedArray[i].Length; j++)
                {
                    string newValue = Console.ReadLine();
                    jaggedArray[i][j] = Convert.ToSingle(newValue);
                }
            }
            Console.WriteLine();
            for (var i = 0; i < jaggedArray.Length; i++)
            {
                for (var j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j]}\t");
                }
                Console.WriteLine();
            }*/
            //-----------------------------Task 3 Part D-------------------------------
            /*var varIntArray = new[] { 1, 10, 100, 1000 };
            var varStringArray = new[] { "hello", null, "world" };*/
            //-----------------------------Task 4 Part A-------------------------------
           /* (int age, string firstName, char sex, string occupation, ulong _) tuple = (18, "Valentine", 'm', "Student", 41412L);*/
            //-----------------------------Task 4 Part B-------------------------------
           /* Console.WriteLine(tuple);
            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item3);
            Console.WriteLine(tuple.Item4);*/
            //-----------------------------Task 4 Part C-------------------------------
            /*var age = tuple.Item1;
            var firstName = tuple.Item2;
            var sex = tuple.Item3;
            var occupation = tuple.Item4;
            var randomNumber = tuple.Item5;*/
            /*var age = tuple.age;
            var firstName = tuple.firstName;
            var sex = tuple.sex;
            var occupation = tuple.occupation;
            var randomNumber = tuple.randomNumber;*/
            /*var age = tuple.age;
            var firstName = tuple.firstName;
            var sex = tuple.sex;
            var occupation = tuple.occupation;*/
            //var randomNumber = tuple.randomNumber << compiler throws away this value from the tuple
            //-----------------------------Task 4 Part D-------------------------------
            /*(int age, string firstName, char sex, string occupation, ulong randomNumber) tuple2 = (18, "Valentine", 'm', "Student", 41412L);
            Console.WriteLine(tuple.CompareTo(tuple2));*/
            //-----------------------------Task 5--------------------------------------
            /*static (int max, int min, int sum, char firstLetter) localFunc(int[] array, string str)
            {
                int max = 0;
                int min = 9999;
                int sum = 0;
                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }

                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                    sum += array[i];
                }
                char firstLetter = str[0];
                return (max, min, sum, firstLetter);
            }
            var localTuple = localFunc(varIntArray, str);
            Console.WriteLine(localTuple);*/
            //-----------------------------Task 6 Part A-------------------------------
            /*static int intLocalFunc1(int num)
            {
                checked
                {
                    num = Int32.MaxValue;
                }
                return num;
            }

            static int intLocalFunc2(int num)
            {
                unchecked
                {
                    num = Int32.MaxValue + 1;
                }
                return num;
            }
            Console.WriteLine(intLocalFunc1(Int32.MaxValue));
            Console.WriteLine(intLocalFunc2(Int32.MaxValue));*/
        }

    }
    
    
}
