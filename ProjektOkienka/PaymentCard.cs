﻿namespace ProjektOkienka
{
    public class PaymentCard
    {
        private string Nr;
        private double Funds = 0.0;
        private string BankName;
        private string OwnerName;
        public string OwnerKRS { get; set; }

        public PaymentCard(string nr, double funds, string bankName, string ownerName, string ownerKRS)
        {
            Nr = nr; if (funds < 0) throw new InvalidValueException(funds); Funds = funds; BankName = bankName; OwnerName = ownerName; OwnerKRS = ownerKRS;
        }

        public PaymentCard(string nr, string bankName, string ownerName, string ownerKRS)
        {
            Nr = nr; BankName = bankName; OwnerName = ownerName; OwnerKRS = ownerKRS;
        }

        public void Pay(double amount)
        {
            if (amount < 0) throw new InvalidValueException(amount);
            if (amount > CheckFunds()) throw new NotEnoughFundException(amount);
            Funds -= amount;
            Funds -= 1;
        }

        public double CheckFunds()
        {
            return Funds;
        }

        public void AddFunds(double amount)
        {
            if (amount < 0) throw new InvalidValueException(amount);
            Funds += amount;
        }

        public string GetNr()
        {
            return Nr;
        }

        public string GetBank()
        {
            return BankName;
        }

        public string GetOwner()
        {
            return OwnerName;
        }

        public override string ToString()
        {
            return Funds.ToString() + " " + Nr + " " + BankName + " } " + OwnerName + " } ";
        }
        public virtual string CardType() { return "base"; }
    }
}