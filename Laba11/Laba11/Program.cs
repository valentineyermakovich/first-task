using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Diagnostics;

namespace Laba11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.WriteLine("Enter the month length: ");
            int n = Convert.ToInt32(Console.ReadLine());
            var monthLength = from month in Months
                where month.Length == n
                select month;
            foreach (var month in monthLength)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("____________________________________________________________");

            var summerWinter = from month in Months
                where month.StartsWith("J") || month.StartsWith("Au") || month.StartsWith("D") || month.StartsWith("F")
                select month;
            foreach (var month in summerWinter)
            {
                Console.WriteLine(month);   
            }
            Console.WriteLine("____________________________________________________________");

            var alphabet = from month in Months
                orderby month
                select month;
            foreach (var month in alphabet)
            {
                Console.WriteLine(month);
            }
            Console.WriteLine("____________________________________________________________");

            var countMonths = (from month in Months
                where month.Contains("u") && month.Length == 4
                select month).Count();
            Console.WriteLine($"There's {countMonths} months");
        
            Console.WriteLine("____________________________________________________________");

            List<Airline> airlines = new List<Airline>(8);

            Airline moskowParis = new Airline("Paris", 620, "Boeing-747", 420, "Wednesday");
            Airline minskParis = new Airline("Paris", 816, "Airbus-A310", 730, "Monday");
            Airline parisMinsk = new Airline("Minsk", 922, "Boeing-747", 415, "Saturday");
            Airline parisMoskow = new Airline("Minsk", 315, "Airbus-A310", 750, "Thursday");
            Airline washingtonAnapa = new Airline("Anapa", 85, "Boeing-747", 1620, "Wednesday");
            Airline anapaWashington = new Airline("Washington", 921, "Airbus-A310", 1200, "Sunday");
            Airline sochiRostov = new Airline("Rostov", 468, "Boeing-747", 550, "Tuesday");
            Airline rostovSochi = new Airline("Sochi", 519, "Airbus-A310", 2230, "Monday");

            airlines.Add(minskParis);
            airlines.Add(moskowParis);
            airlines.Add(parisMinsk);
            airlines.Add(parisMoskow);
            airlines.Add(washingtonAnapa);
            airlines.Add(anapaWashington);
            airlines.Add(sochiRostov);
            airlines.Add(rostovSochi);

            var destinationFlights = airlines.Where(airline => airline.destination == "Anapa");
            foreach (var flight in destinationFlights)
            {
                flight.GetInfo();   
            }
            Console.WriteLine("____________________________________________________________");

            var countDay = airlines.Count(airline => airline.daysOfWeek == "Wednesday");
            Console.WriteLine($"There are {countDay} flights");
            Console.WriteLine("____________________________________________________________");

            var earliestFlight = airlines.Where(airline => airline.daysOfWeek == "Monday" && airline.departureTime < 1000);
            foreach (var flight in earliestFlight)
            {
                flight.GetInfo();
            }
            Console.WriteLine("____________________________________________________________");

            var latestFlight = airlines.Where(airline => airline.daysOfWeek == "Wednesday" || airline.daysOfWeek == "Friday" && airline.departureTime > 1500);
            foreach (var flight in latestFlight)
            {
                flight.GetInfo();
            }
            Console.WriteLine("____________________________________________________________");

            var byTheTime = from airline in airlines
                orderby airline.departureTime
                select airline;
            foreach ( var flights in byTheTime)
            {
                flights.GetInfo();
            }
            Console.WriteLine("____________________________________________________________");

            var writers1 = new Dictionary<string,string>();
            writers1["Rowling"] = "Harry Potter and the Philosophers Stone ";
            writers1["Tolkien"] = "The Lord of the Rings : Return of the King ";
            writers1["Azimov"] = "I, Robot ";
            writers1["Barto"] = "Bychok ";
            writers1["Martin"] = "The Song of Ice and Fire ";
            writers1["Sapkovsky"] = "The Witcher ";
            writers1["Pushkin"] = "Captains Daughter ";
            var books = from writer in writers1
                where writer.Key.Length > 6
                orderby writer.Value
                select writer.Value;
            foreach (var book in books)
            {
                Console.WriteLine($"The book is: {book}.");
            };
            Console.WriteLine("____________________________________________________________");

            var all = books.Aggregate((x, y) => x + y);
            Console.WriteLine(all);
            Console.WriteLine("____________________________________________________________");

            var writers2 = new Dictionary<string, string>();
            writers2["Rowling"] = "Harry Potter and the Half-blood Prince";
            writers2["Tolkien"] = "Hobbit";
            var result = from writer1 in writers1
                join writer2 in writers2 on writer1.Key equals writer2.Key
                select writer1;
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}
