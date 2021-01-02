using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Laba14
{
     interface IControls
    {
         void Show() { }
         void Input() { }
         void Resize() { }
    }
    [Serializable]
    abstract public class GeometricFigure : IControls
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
        public string type { get; set; }
        public  int angleSum { get; set; }
        [XmlIgnore] [JsonIgnore] public int area { get; set;}

        public GeometricFigure() {}

        public GeometricFigure(string TypeOfFigure, int AngleSum, int Area)
        {
            type = TypeOfFigure;
            angleSum = AngleSum;
            area = Area;
        }

        public abstract override string ToString();
    }
    [Serializable]
    public class Circle : GeometricFigure, IControls
    {
        public Circle() {}

        public Circle(string TypeOfFigure, int AngleSum, int Area) : base(TypeOfFigure, AngleSum, Area) { }

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
}
