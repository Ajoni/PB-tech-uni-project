using System;

namespace ProjektOkienka
{
    internal class InvalidValueException : Exception
    {
        public double val { get; set; }

        public InvalidValueException(double invalid)
        {
            val = invalid;
        }
    }
}