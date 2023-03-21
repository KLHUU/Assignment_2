using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2_kevinlehuu.Data;

namespace Assignment_2_kevinlehuu.Data
{
    //reservation class attributes
    public class Reservation
    {
        private string name;
        private string citizenship;
        private string reservationCode;
        private string code;
        private bool active;
        private string flightCode;
        private string airline;
        private double cost;
        private Flight flight;

        //public properties
        public string Name { get; set; }
        public string Airline { get; set; }
        public string Citizenship { get; set; }
        public string ReservationCode { get; set; }
        public string Code { get; set; }
        public bool Active { get; set; }

        //reservation constructor takes flight arguements
        public Reservation(string code, string flightCode, string airline, double cost, string name, string citizenship, bool active)
        {
            this.Code = code;
            this.flightCode = flightCode;
            this.airline = airline;
            this.cost = cost;
            this.Name = name;
            this.Citizenship = citizenship;
            this.Active = active;
        }

        //reservation constructor takes reservation arguements
        public Reservation(string reservationCode, Flight flight, string name, string citizenship)
        {
            this.ReservationCode= reservationCode;
            this.flight = flight;
            this.Name= name;
            this.Citizenship= citizenship;
        }


        //set name method
        public void SetName(string name)
        {
            this.Name = name;
        }

        //set citizenship method
        public void SetCitizenship(string citizenship)
        {
            this.Citizenship= citizenship;
        }


        //toString method to implement in Flights.razor
        public override string ToString()
        {
            return $"{reservationCode} {flightCode} {Airline} {Name} {Citizenship}";
        }

    }
}
