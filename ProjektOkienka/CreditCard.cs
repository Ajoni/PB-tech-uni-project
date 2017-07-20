namespace ProjektOkienka
{
    public class CreditCard : PaymentCard
    {
        public CreditCard(string nr, double funds, string bankName, string ownerName, string ownerKRS) : base(nr, funds, bankName, ownerName, ownerKRS)
        {
        }

        public CreditCard(string nr, string bankName, string ownerName, string ownerKRS) : base(nr, bankName, ownerName, ownerKRS)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "Credit" + " | ";
        }
        public override string CardType()
        {
            return "Credit";
        }
    }
}