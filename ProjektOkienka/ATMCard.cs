namespace ProjektOkienka
{
    public class ATMCard : PaymentCard
    {
        public ATMCard(string nr, double funds, string bankName, string ownerName) : base(nr, funds, bankName, ownerName)
        {
        }

        public ATMCard(string nr, string bankName, string ownerName) : base(nr, bankName, ownerName)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "ATM" + " | ";
        }
    }
}