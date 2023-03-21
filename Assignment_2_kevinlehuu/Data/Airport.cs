//using Intents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2_kevinlehuu.Data;

namespace Assignment_2_kevinlehuu.Data
{
    public class Airport
    {
        //airport class attributes
        private string airportCode;
        private string airportName;

        //public properties
        public string AirportCode { get; set; }
        public string AirportName { get; set; }


        //non - parameterized constructor
        public Airport()
        {

        }

        //parameterized constructor
        public Airport(string airportCode, string airportName)
        {
            this.AirportCode= airportCode;
            this.AirportName= airportName;
        }


        //toString method to implement in Reservation.razor
        public override string ToString()
        {
            return $"{AirportCode} {AirportName}";
        }
    }
}
