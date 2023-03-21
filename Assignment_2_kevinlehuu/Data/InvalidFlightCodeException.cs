using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2_kevinlehuu.Data;

namespace Assignment_2_kevinlehuu.Data
{
    public class InvalidFlightCodeException : Exception //inhereit from exception class
    {
        //basic exception
        public InvalidFlightCodeException() : base("Invalid flight code : flight code entered incorrect or invalid flight code") 
        { 

        }

        //parameterized exception
        public InvalidFlightCodeException(string flightCode) : base("Invalid flight code: " + flightCode)
        {

        }
    }
}
