namespace ProjektOkienka
{
    public class ATMCard : PaymentCard
    {
        public ATMCard(string nr, double funds, string bankName, string ownerName, string ownerKRS) : base(nr, funds, bankName, ownerName, ownerKRS)
        {
        }

        public ATMCard(string nr, string bankName, string ownerName, string ownerKRS) : base(nr, bankName, ownerName, ownerKRS)
        {
        }

        public override string ToString()
        {
            return base.ToString() + "ATM" + " | ";
        }
        public override string CardType()
        {
            return "ATM";
        }
    }
}