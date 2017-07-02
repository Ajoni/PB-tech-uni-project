using System;

namespace ProjektOkienka
{
    internal class RequestRejectedException : Exception
    {
        public string BankName { get; set; }

        public RequestRejectedException(string BankName)
        {
            this.BankName = BankName;
        }
    }
}