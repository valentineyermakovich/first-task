using System;
using System.Collections.Generic;

namespace Laba_6
{
    class Program
    {
        static void Main(string[] args)
        {
            UI Ui = new UI();
            GeometricFigure Circle = new Circle("Circle", 23, 360 );
            GeometricFigure Oval = new Circle("Oval", 53, 360);
            GeometricFigure Ellipse = new Circle("Ellipse", 20, 360);
            GeometricFigure Balloon = new Circle("Balloon", 202, 360);
            GeometricFigure Rectangle = new Rectangle("Rectangle", 7, 360);
            GeometricFigure Square = new Rectangle("Square", 19, 360);
            GeometricFigure Rhombus = new Rectangle("Rhombus", 16, 360);
            GeometricFigure Box = new Rectangle("Box", 115, 360);
            Ui.add(Circle);
            Ui.add(Oval);
            Ui.add(Ellipse);
            Ui.add(Balloon);
            Ui.add(Rectangle);
            Ui.add(Square);
            Ui.add(Rhombus);
            Ui.add(Box);
            Controller.AmountOfElementsOnUI(Ui);
            Controller.Area(Ui);
            Controller.Print(Ui);
            Console.WriteLine("\nEnum.GetValues\n");
            foreach (var element in Enum.GetValues(typeof(Founders)))
            {
                Console.WriteLine(element);
            }
        }
    }
    static class Controller
    {
        public static void AmountOfElementsOnUI(UI Ui)
        {
            Console.WriteLine($"Amount of elements is {Ui.ui.Count}");
        }
        public static void Area(UI Ui)
        {
            int result = 0;
            foreach (var el in Ui.ui)
            {
                result += el.area;
            }
            Console.WriteLine($"Covered area = {result}");
        }

        public static void Print(UI Ui)
        {
            foreach (var el in Ui.ui)
            {
                Console.WriteLine($"{el.figure}");
            }
        }
    }
    public class UI 
    {
        public List<GeometricFigure> ui = new List<GeometricFigure> { };
        public void add(GeometricFigure name) 
        {
            ui.Add(name);
        }
        public void Del(GeometricFigure name)
        {
            foreach (var element in ui)
            {
                int position = 0;
                if (element == name)
                {
                    ui.RemoveAt(position);
                    break;
                }
                position++;
            }
        }
    }  
    public abstract partial class GeometricFigure : UI 
    {
        public abstract string figure { get; set;}
        public abstract int area { get; set; }
        public abstract int angles { get; set; }
    }

    class Circle : GeometricFigure
    {
        public override string figure { get; set; }
        public override int area { get; set; }
        public override int angles { get; set; }

        public Circle(string Figure, int Area, int Angles)
        {
            figure = Figure;
            area = Area;
            angles = Angles;
        }
    }

    class Rectangle : GeometricFigure
    {
        public override string figure { get; set; }
        public override int area { get; set; }
        public override int angles { get; set; }

        public Rectangle(string Figure, int Area, int Angles)
        {
            figure = Figure;
            area = Area;
            angles = Angles;
        }
    }

    struct Geometry 
    {
        public string theoreme;
        public string creator;
        public Geometry(string Theoreme, string Creator)
        {
            this.theoreme = Theoreme;
            this.creator = Creator;
        }
    }

    enum Founders
    { 
       Pythagoras, Decart, Einstein = 4, Asmyckovich, MarshallMathers, CollsonBaker, DickSucker, McDonalds
    }
}

