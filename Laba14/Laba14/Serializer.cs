using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Text.Json;
using System.Xml.Linq;
using System.Xml;

namespace Laba14
{
    public static class Serializer
    {
        public static void XML()
        {
            Circle circle = new Circle("Oval", 360, 135);
            XmlSerializer formatter = new XmlSerializer(typeof(Circle));
            using (FileStream fs = new FileStream("circle.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, circle);
            }

            using (FileStream fs = new FileStream("circle.xml", FileMode.OpenOrCreate))
            {
                Circle newcirc = (Circle)formatter.Deserialize(fs);
                Console.WriteLine("Deserialization using the XML:");
                Console.WriteLine($"Type: {newcirc.type}\n" +
                                  $"Sum of Angles: {newcirc.angleSum}");
            }
        }

        public static void JSON()
        {
            Circle circle = new Circle("Oval", 360, 135);
            using (FileStream fs = new FileStream("circle.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, circle);
            }

            string json = File.ReadAllText("circle.json");
            Circle newcirc = JsonSerializer.Deserialize<Circle>(json);
            Console.WriteLine("Deserialization using the JSON");
            Console.WriteLine($"Type: {newcirc.type}\n" +
                              $"Sum of Angles: {newcirc.angleSum}");
        }

        public static void Binary()
        {
            Circle circle = new Circle("Oval", 360, 135);
            BinaryFormatter bin = new BinaryFormatter();
            using (FileStream fs = new FileStream("circle.dat", FileMode.OpenOrCreate))
            {
                bin.Serialize(fs, circle);
            }

            using (FileStream fs = new FileStream("circle.dat", FileMode.OpenOrCreate))
            {
                Circle newcirc = (Circle)bin.Deserialize(fs);
                Console.WriteLine("Deserialization using the Binary");
                Console.WriteLine($"Type: {newcirc.type}\n" +
                                  $"Sum of Angles: {newcirc.angleSum}");
            }
        }

        public static void ArraySerialization()
        {
            Circle circle1 = new Circle("Oval", 360, 135);
            Circle circle2 = new Circle("Ellipse", 360, 80);
            Circle circle3 = new Circle("Circle", 360, 30);
            Circle[] circles = { circle1, circle2, circle3 };
            using (FileStream fs = new FileStream("circles.json", FileMode.OpenOrCreate))
            {
                JsonSerializer.SerializeAsync(fs, circles);
            }
            string json = File.ReadAllText("circles.json");
            Circle[] newCircles = JsonSerializer.Deserialize<Circle[]>(json);
            Console.WriteLine(json);
            foreach (var circ in newCircles)
            {
                Console.WriteLine($"Type: {circ.type}\n" +
                                  $"Sum of Angles: {circ.angleSum}");
            }
        }

        public static void xPath()
        {
            Circle circle1 = new Circle("Oval", 360, 135);
            Circle circle2 = new Circle("Ellipse", 360, 80);
            Circle circle3 = new Circle("Circle", 360, 30);
            Circle[] circles = { circle1, circle2, circle3 };
            XmlSerializer formatter = new XmlSerializer(typeof(Circle[]));
            using (FileStream fs = new FileStream("circles.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, circles);
            }
            XmlDocument xml = new XmlDocument();
            xml.Load("circles.xml");
            XmlElement xRoot = xml.DocumentElement;
            XmlNodeList outer = xRoot.SelectNodes("*");
            foreach (XmlNode node in outer)
            {
                Console.WriteLine(node.OuterXml);
            }
            XmlNodeList nodes = xRoot.SelectNodes("//Circle/type");
            foreach (XmlNode node in nodes)
            {
                Console.WriteLine($"Type: {node.InnerText}");
            }
        }

        public static void LtoX()
        {
            XDocument xdoc = new XDocument(new XElement("Circles",
                new XElement("Circle",
                    new XElement("Type", "Oval"),
                    new XElement("Sum_of_Angles", "360")),
                new XElement("Circle",
                    new XElement("Type", "Ellipse"),
                    new XElement("Sum_of_Angles", "360")),
                new XElement("Circle",
                    new XElement("Type", "Circle"),
                    new XElement("Sum_of_Angles", "360"))));
            xdoc.Save("LINQcircles.xml");
        }
    }
}