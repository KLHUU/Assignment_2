using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2_kevinlehuu.Data;
//using static ObjCRuntime.Dlfcn;

//Kevin, Jas, Tristan
//March 6, 2023
//Assignment 2: Abstract Classes, Event Driven Applications and Exception Handling
namespace Assignment_2_kevinlehuu.Data
{
    public class Flight
    {
        //flight class attributes
        private string originAirport;
        private string destAirport;
        private string day;
        private string flightCode;
        private string airline;
        private string time;
        private int seats;
        private double cost;

        //public properties of attributes
        public string OriginAirport { get; set; }
        public string DestAirport { get; set; }
        public string Day { get; set; }
        public string FlightCode { get; set; }
        public string Airline { get; set; }
        public string Time { get; set; }
        public int Seats { get; set; }
        public double Cost { get; set; }


        //non - parameterized constructor
        public Flight()
        {

        }

        //paramertized constructor
        public Flight(string originAirport, string destAirport, string day, string flightCode, string airline, string time, int seats, double cost/*, string airportCode, string airportName*/)
        {
            this.OriginAirport = originAirport;
            this.DestAirport = destAirport;
            this.Day = day;
            this.FlightCode = flightCode;
            this.Airline = airline;
            this.Time = time;
            this.Seats = seats;
            this.Cost = cost;
        }


        //toString method to implement in Flights.razor
        public override string ToString()
        {
            return $"{FlightCode} {Airline} {Day} {Time} {Cost}";
        }
    }
}
