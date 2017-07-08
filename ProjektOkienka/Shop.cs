using System.Linq;

namespace ProjektOkienka
{
    public class Shop : Client
    {
        public Shop(string KRS, string Password, string Name) : base(KRS, Password, Name)
        {
        }

        public override string ToString()
        {
            string line = Cards.Count() + " ";
            foreach (PaymentCard c in Cards)
                line += c.ToString();
            return base.ToString() + "Shop ; " + line + "; ";
        }
        public override string GetType()
        {
            return "Shop";
        }
    }
}