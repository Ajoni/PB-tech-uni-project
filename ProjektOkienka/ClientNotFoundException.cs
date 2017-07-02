using System;

namespace ProjektOkienka
{
    internal class ClientNotFoundException : Exception
    {
        public string KRS { get; set; }

        public ClientNotFoundException(string invKRS)
        {
            KRS = invKRS;
        }
    }
}