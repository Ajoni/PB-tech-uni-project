namespace ProjektOkienka
{
    public class CreditCard : PaymentCard
    {
        public CreditCard(string nr, double funds, string bankName, string ownerName) : base(nr, funds, bankName, ownerName)
        {
        }

        public CreditCard(string nr, string bankName, string ownerName) : base(nr, bankName, ownerName)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "Credit" + " | ";
        }
    }
}