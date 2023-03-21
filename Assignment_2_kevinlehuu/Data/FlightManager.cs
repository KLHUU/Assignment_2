using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Assignment_2_kevinlehuu.Data;

namespace Assignment_2_kevinlehuu.Data
{
    public class FlightManager
    {
        //select file path for flight and airport txt files
        private const string AIRPORT_FILE = "C:\\CPRG 211\\Assignments\\Assignment_2_kevinlehuu\\Assignment_2_kevinlehuu\\Resources\\Files\\airports.txt";
        private const string FLIGHT_FILE = "C:\\CPRG 211\\Assignments\\Assignment_2_kevinlehuu\\Assignment_2_kevinlehuu\\Resources\\Files\\flights.txt";

        //create airport and flight list from files
        public static List<Airport> AirportList = new List<Airport>();
        public static List<Flight> FlightList = new List<Flight>();


        //non - parameterized constuctor
        public FlightManager()
        {
            PopulateAirports();
            PopulateFlights();
        }


        //populate airports method
        private void PopulateAirports()
        {
            Airport airport;
            foreach(string line in File.ReadAllLines(AIRPORT_FILE))
            {
                string[] parts = line.Split(',');
                string airportCode = parts[0];
                string airportName = parts[1];
                
                airport = new Airport(airportCode, airportName);
                AirportList.Add(airport);
            }
        }

        //polulate flights method
        private void PopulateFlights()
        {
            Flight flight;  //create object flight
            foreach (string line in File.ReadLines(FLIGHT_FILE))
            {
                string[] parts = line.Split(',');
                string flightCode = parts[0];
                string airline = parts[1];
                string originAirport = parts[2];
                string destAirport = parts[3];
                string day = parts[4];
                string time = parts[5];
                int seats = int.Parse(parts[6]);
                double cost = double.Parse(parts[7]);

                flight = new Flight(flightCode, airline, originAirport, destAirport, day, time, seats, cost);
                FlightList.Add(flight);  //add flight object to list
            }
        }

        //find flights method
        public static List<Flight> FindFlights(string originAirport, string destAirport, string day)
        {
            List<Flight> matchingFlights = new List<Flight>();  //create new list for matching flights

            foreach (Flight flight in FlightList)
            {
                if (flight.OriginAirport == originAirport && flight.DestAirport == destAirport && flight.Day == day && flight.Seats > 0)
                {
                    matchingFlights.Add(flight);
                }

                else if (flight.OriginAirport == originAirport && flight.DestAirport == destAirport && flight.Day == "Any" && flight.Seats > 0)  //else-if customer chooses "Any" day
                {
                    matchingFlights.Add(flight);
                }
            }
            return matchingFlights;
        }

        //find airport by code method
        public string FindAirportByCode(string airportCode)
        {
            foreach (Airport airport in AirportList)
            {
                if (airport.AirportCode == airportCode)
                {
                    return airport.AirportCode;
                }
            }
            return null;
        }

        //find flight by code method
        public static Flight FindFlightByCode(string flightCode)
        {
            foreach (Flight flight in FlightList)
            {
                if (flight.FlightCode == flightCode)
                {
                    return flight;
                }
            }
            return null;
        }


        //return airport list
        public static List<Airport> GetAirports()
        {
            return AirportList;
        }

        //return flight list
        public static List<Flight> GetFlights()
        {
            return FlightList;
        }

    }
}
