using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_2_kevinlehuu.Data;

namespace Assignment_2_kevinlehuu.Data
{
    public class InvalidNameException : Exception //inhereit from exception class
    {
        //basic exception
        public InvalidNameException() : base("Invalid name : name entered incorrect") 
        {

        }

        //parameterized exception
        public InvalidNameException(string name) : base("Invalid name: " + name)
        {

        }
    }
}
