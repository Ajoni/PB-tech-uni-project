using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjektOkienka
{
    public class Bank
    {
        private List<Client> Clients = new List<Client>();
        private List<PaymentCard> Cards = new List<PaymentCard>();
        public string Name { get; set; }
        public string Password { get; set; }

        public Bank(String SetName,string SetPassword)
        {
            Name = SetName;
            Password = SetPassword;
        }

        public bool Authorize()
        {
            Random rnd = new Random();
            if (rnd.Next() % 10 < 8) return true; else return false;
        }

        public PaymentCard AuthorizeCard(string ClientName,string ClientKRS, int type)
        {
            Random rnd = new Random();
            string Nr = rnd.Next(10000000, 99999999).ToString() + rnd.Next(10000000, 99999999).ToString();
            if (rnd.Next(1, 10) < 8)
            {
                if (type == 1) return new DebitCard(Nr, Name, ClientName, ClientKRS);
                else
                if (type == 2) return new CreditCard(Nr, Name, ClientName, ClientKRS);
                else
                if (type == 3) return new ATMCard(Nr, Name, ClientName, ClientKRS); else throw new InvalidValueException(type);
            }
            else throw new RequestRejectedException(Name);
        }

        public List<Client> GetClients()
        {
            return Clients;
        }

        public List<PaymentCard> GetCards()
        {
            return Cards;
        }

        public void AddClient(Client ToAdd)
        {
            Clients.Add(ToAdd);
        }

        public void RemoveClient(string ToDelete)
        {
            Clients.Remove(FindClient(ToDelete));
        }

        public void AddCard(PaymentCard ToAdd)
        {
            Cards.Add(ToAdd);
        }

        public void RemoveCard(string nr)
        {
            Cards.Remove(FindCard(nr));
        }

        public PaymentCard FindCard(string FindNr)
        {
            foreach (PaymentCard c in Cards)
            {
                if (c.GetNr().Equals(FindNr)) return c;
            }
            throw new CardNotFoundException(FindNr);
        }

        public Client FindClient(string FindKRS)
        {
            foreach (Client c in Clients)
            {
                if (c.GetKRS().Equals(FindKRS)) return c;
            }
            throw new ClientNotFoundException(FindKRS);
        }

        public override string ToString()
        {
            string line = $"{Name} ; {Password} ; {Clients.Count()} ";
            foreach (Client c in Clients)
                line += c.ToString();
            return line;
        }
    }
}