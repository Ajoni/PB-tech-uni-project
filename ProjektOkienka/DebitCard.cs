namespace ProjektOkienka
{
    public class DebitCard : PaymentCard
    {
        public DebitCard(string nr, double funds, string bankName, string ownerName, string ownerKRS) : base(nr, funds, bankName, ownerName, ownerKRS)
        {
        }

        public DebitCard(string nr, string bankName, string ownerName, string ownerKRS) : base(nr, bankName, ownerName, ownerKRS)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "Debit" + " | ";
        }
        public override string CardType()
        {
            return "Debit";
        }
    }
}