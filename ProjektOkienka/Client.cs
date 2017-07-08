using ProjektOkienka;
using System;
using System.Collections.Generic;

namespace ProjektOkienka
{
    public class Client
    {
        protected List<PaymentCard> Cards = new List<PaymentCard>();
        private string KRS;
        private string Password;
        private string Name;

        public Client(string SetKRS, string SetPassword, string SetName)
        {
            KRS = SetKRS; Password = SetPassword; Name = SetName;
        }

        public string GetKRS()
        {
            return KRS;
        }

        public string GetPassword()
        {
            return Password;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string ToSet)
        {
            Name = ToSet;
        }

        public void RequestAuthorization(PaymentCard Used, double Amount, string ToKRS, string ToCard, string Title)
        {
            PaymentCardServiceCenter.AuthorizePayment(new Payment(KRS, Used.GetNr(), Amount.ToString(), ToKRS, ToCard, Title, DateTime.Now.ToString()), Used);
        }
        public void RequestAuthorization(Payment payment,PaymentCard Card)
        {
            PaymentCardServiceCenter.AuthorizePayment(payment, Card);
        }

        public List<PaymentCard> GetCards()
        {
            return Cards;
        }

        public void RequestCard(string BankName, string ClientName, int Type)
        {
            Bank tmpBank = PaymentCardServiceCenter.FindBank(BankName);
            PaymentCard tmpCard = tmpBank.AuthorizeCard(ClientName, Type);
            AddCard(tmpCard);
        }

        public void AddCard(PaymentCard ToAdd)
        {
            Cards.Add(ToAdd);
        }

        public void RemoveCard(string ToRemove)
        {
            Cards.Remove(FindCard(ToRemove));
        }

        public PaymentCard FindCard(string ToFind)
        {
            foreach (PaymentCard c in Cards)
            {
                if (c.GetNr().Equals(ToFind)) return c;
            }
            throw new CardNotFoundException(ToFind);
        }

        public override string ToString()
        {
            string line = KRS + " " + Password + " } " + Name + " } ";
            return line;
        }
        public virtual new string GetType()
        {
            return "base";
        }
    }
}