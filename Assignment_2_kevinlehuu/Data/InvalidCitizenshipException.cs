using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2_kevinlehuu.Data;

namespace Assignment_2_kevinlehuu.Data
{
    public class InvalidCitizenshipException : Exception  //inhereit from exception class
    {
        //basic exception
        public InvalidCitizenshipException() : base("Invalid citizenship : citizenship entered incorrect or expired.")
        {

        }

        //parameterized exception
        public InvalidCitizenshipException(string citizenship) : base("Invalid citizenship: " + citizenship)
        {

        }
    }
}
