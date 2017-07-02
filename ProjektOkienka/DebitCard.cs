namespace ProjektOkienka
{
    public class DebitCard : PaymentCard
    {
        public DebitCard(string nr, double funds, string bankName, string ownerName) : base(nr, funds, bankName, ownerName)
        {
        }

        public DebitCard(string nr, string bankName, string ownerName) : base(nr, bankName, ownerName)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "Debit" + " | ";
        }
    }
}