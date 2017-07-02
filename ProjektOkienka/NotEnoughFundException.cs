using System;

namespace ProjektOkienka
{
    internal class NotEnoughFundException : Exception
    {
        public double amount { get; set; }

        public NotEnoughFundException(double BigAmount)
        {
            amount = BigAmount;
        }
    }
}