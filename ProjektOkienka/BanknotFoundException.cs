using System;

namespace ProjektOkienka
{
    internal class BanknotFoundException : Exception
    {
        public string bank { get; set; }

        public BanknotFoundException(string name)
        {
            bank = name;
        }
    }
}