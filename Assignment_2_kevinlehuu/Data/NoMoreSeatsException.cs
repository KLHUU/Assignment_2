using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2_kevinlehuu.Data;

namespace Assignment_2_kevinlehuu.Data
{
    public class NoMoreSeatsException : Exception  //inhereit from exception class
    {
        //basic exception
        public NoMoreSeatsException() : base("No more seats : Seats must be greater than zero") 
        {
            
        }

        //parameterized exception
        public NoMoreSeatsException(int seats) : base("No more seats" + seats)
        {

        }

    }
}
