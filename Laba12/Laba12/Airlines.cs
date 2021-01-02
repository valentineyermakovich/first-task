using System;
using System.Collections.Generic;
using System.Text;

namespace Laba12
{
    class Airlines
    {
        public string destination;
        public int flightNumber;
        public string planeType;
        public int departureTime;
        public string daysOfWeek;

        public Airlines(string d, int fn, string pt, int dt, string dow)
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
}
