using System;
using System.Security.Cryptography.X509Certificates;

namespace Лаба_3
{
    class Airline
    {
        public string destination;
        public int flightNumber;
        public string planeType;
        public string departureTime;
        public string daysOfWeek;

        public Airline() 
        { 
            destination = "-";
            flightNumber = 0;
            planeType = "-";
            departureTime = "-";
            daysOfWeek = "-";
        }
        public Airline(string d, int fn, string pt, string dt, string dow) 
        { 
            destination = d;
            flightNumber = fn;
            planeType = pt;
            departureTime = dt;
            daysOfWeek = dow;
        }
        public Airline(string pt, string dow, string d = "Moskow", int fn = 294, string dt = "21:45") 
        {
            destination = d;
            flightNumber = fn;
            planeType = pt;
            departureTime = dt;
            daysOfWeek = dow;
        }
        public Airline(int fn, string pt, string dt, string dow, string d = "Moskow")
        {
            destination = d;
            flightNumber = fn;
            planeType = pt;
            departureTime = dt;
            daysOfWeek = dow;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Destination: {destination}; Flight Number: {flightNumber}; Type of a Plane: {planeType}; Departure time: {departureTime}; Days of a week: {daysOfWeek}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Airline parisMinsk = new Airline();
            Airline parisMoskow = new Airline("Airbus-A310","Sunday");
            Airline moskowMinsk = new Airline("Minsk", 782, "Airbus-A320", "16:50", "Monday");  
            Airline minskMoskow = new Airline(622, "Airbus-A330", "19:20", "Tuesday");
            Airline moskowParis = new Airline("Paris", 620, "Boeing-747", "04:20", "Wednesday");
            Airline minskParis = new Airline("Paris", 816, "Airbus-A310", "07:30", "Monday");
            Airline[] Planes = new Airline[6];
            Planes[0] = parisMinsk;
            Planes[1] = parisMoskow;
            Planes[2] = moskowMinsk;
            Planes[3] = minskMoskow;
            Planes[4] = moskowParis;
            Planes[5] = minskParis;
            Console.WriteLine("Enter the destination: ");
            string dest = Console.ReadLine();
            foreach(var plane in Planes)
            {
                if (dest==plane.destination) 
                {
                    plane.GetInfo();
                }
            }
            Console.WriteLine("Enter the day: ");
            string day = Console.ReadLine();
            foreach (var plane in Planes)
            {
                if (day == plane.daysOfWeek)
                {
                    plane.GetInfo();
                }
            }
        }
    }

    
}
