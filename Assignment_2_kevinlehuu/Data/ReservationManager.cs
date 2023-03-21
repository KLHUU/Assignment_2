using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_kevinlehuu.Data
{
    public class ReservationManager
    {
        //create reservations list
        public static List<Reservation> Reservations = new List<Reservation>();

        //non - parameterized constructor
        public ReservationManager() 
        {

        }


        //find reservations method
        List<Reservation> FindReservations(string reservationCode, string airline, string name)
        {
            List<Reservation> matchingReservation = new List<Reservation>();

            foreach (Reservation reservation in Reservations)
            {
                if (reservation.ReservationCode == reservationCode && reservation.Airline == airline && reservation.Name == name)
                {
                    matchingReservation.Add(reservation);  //add matching reservations to list
                }
            }

            return Reservations;
        }



        //make reservation method
        /*
        public Reservation MakeReservation(Flight flight, string name, string citizenship)
        {
            int availableSeats = GetAvailableSeats(flight);

            if (availableSeats <= 0)
            {
                throw new Exception("Sorry, this flight is fully booked.");
            }

            Reservation reservation = new Reservation(flight, name, citizenship, GenerateReservationCode(flight));
            Reservations.Add(reservation);

            return reservation;
        }

        private int GetAvailableSeats(Flight flight)
        {
            int totalSeats = flight.Seats;
            int bookedSeats = Reservation.f(r => r.Flight.FlightCode == flight.FlightCode);
            return totalSeats - bookedSeats;
        }

        
        private int GetAvailableSeats(Flight flight)
        {
            return flight.Capacity - reservations.FindAll(reservation => reservation.Flight == flight).Count;
        }

        public static string GenerateReservationCode(Flight flight)
        {
            string date = DateTime.Now.ToString("yyyyMMddHHmmss");
            return $"{flight.Number}-{date}";
        }
        private int GetAvailableSeats(Flight flight)
        {
            foreach (var flight in Flight)
            {

            }
            return NoMoreSeatsException
        }


        public Reservation FindReservationByCode(string reservationCode)
        {
            
            return ;
        }*/

    }
}
