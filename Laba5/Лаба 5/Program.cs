using System;

namespace Laba5
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometricFigure circle = new Circle("Circle", 360);
            circle.Show();
            GeometricFigure rectangle = new Rectangle("Rectangle", 360);
            rectangle.Show();
            Console.WriteLine(rectangle is Rectangle);
            Console.WriteLine(rectangle is GeometricFigure);
            GeometricFigure figure = circle as Rectangle;
            Console.WriteLine(figure);
            ControlElement controlElement = new ControlElement(true, "square");
            Console.WriteLine(controlElement.ToString());
            GeometricFigure ellipse = new Circle("Ellipse", 360);
            GeometricFigure oval = new Circle("Oval", 360);
            GeometricFigure square = new Rectangle("Square", 360);
            GeometricFigure rhombus = new Rectangle("Rhombus", 360);
            dynamic[] PrinterArr = { ellipse, oval, square, rhombus };
            Console.WriteLine("PRINTER");
            foreach (var item in PrinterArr)
            {
                Console.WriteLine(Printer.IAmPrinting(item));
            }
            Console.ReadKey();
        }
    }

    interface IControls
    {
         void Show() { }
         void Input() { }
         void Resize() { }
    }

    abstract class GeometricFigure : IControls
    {
        public void Show()
        {
            Console.WriteLine($"Type: {type}\nSum of angles: {angleSum}");
        }
        public void Input(string newType)
        {
            type = newType;
        }
        public void Resize(int newAngleSum)
        {
            angleSum = newAngleSum;
        }
        public static string type { get; set; }
        public static int angleSum { get; set; }

        public GeometricFigure(string TypeOfFigure, int AngleSum)
        {
            type = TypeOfFigure;
            angleSum = AngleSum;
        }

        public abstract override string ToString();
    }

    sealed class Circle : GeometricFigure, IControls
    {
        public Circle(string TypeOfFigure, int AngleSum) : base(TypeOfFigure, AngleSum) { }

        public void show()
        {
            Console.WriteLine($"Type: {type}\nSum of angles: {angleSum}");
        }
        public void input(string newType)
        {
            type = newType;
        }
        public void resize(int newAngleSum)
        {
            angleSum = newAngleSum;
        }

        public override string ToString()
        {
            return "GeometricFugure.Circle";
        }
    }

    class Rectangle : GeometricFigure, IControls
    {
        public Rectangle(string TypeOfFigure, int AngleSum) : base(TypeOfFigure, AngleSum) { }

        public void show()
        {
            Console.WriteLine($"Type: {type}\nSum of angles: {angleSum}");
        }
        public void input(string newType)
        {
            type = newType;
        }
        public void resize(int newAngleSum)
        {
            angleSum = newAngleSum;
        }

        public override string ToString()
        {
            return "GeometricFugure.Rectangle";
        }
    }
    class ControlElement
    {
        public bool isOnOrOff { get; set; }
        public string shape { get; set; }

        public ControlElement(bool IsOnOrOff, string Shape)
        {
            isOnOrOff = IsOnOrOff;
            shape = Shape;
        }

    }

    class CheckBox : ControlElement
    {
        public CheckBox(bool IsOnOrOff, string Shape) : base(IsOnOrOff, Shape) { }

        public override string ToString()
        {
            return "ControlElement.CheckBox";
        }
    }

    class RadioButton : ControlElement
    {
        public RadioButton(bool IsOnOrOff, string Shape) : base(IsOnOrOff, Shape) { }

        public override string ToString()
        {
            return "ControlElement.RadioButton";
        }
    }

    class Button : ControlElement
    {
        public Button(bool IsOnOrOff, string Shape) : base(IsOnOrOff, Shape) { }

        public override string ToString()
        {
            return "ControlElement.Button";
        }
    }

    static class Printer
    {
        static internal string IAmPrinting(object obj)
        {
            if (obj is GeometricFigure)
            {
                if (obj is Circle)
                {
                    GeometricFigure c = obj as Circle;
                    return Convert.ToString(c);
                }

                if (obj is Rectangle)
                {
                    GeometricFigure r = obj as Rectangle;
                    return Convert.ToString(r);
                }

                GeometricFigure gf = obj as GeometricFigure;
                return Convert.ToString(gf);
            }
            return "Error";
        }
    }
}