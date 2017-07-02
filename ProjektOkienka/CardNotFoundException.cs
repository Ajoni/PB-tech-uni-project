using System;

namespace ProjektOkienka
{
    internal class CardNotFoundException : Exception
    {
        public string nr { get; set; }

        public CardNotFoundException(string SetNr)
        {
            nr = SetNr;
        }
    }
}