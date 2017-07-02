using System.Linq;

namespace ProjektOkienka
{
    public class ServiceEstablishment : Client
    {
        public ServiceEstablishment(string KRS, string Password, string Name) : base(KRS, Password, Name)
        {
        }

        public override string ToString()
        {
            string line = Cards.Count() + " ";
            foreach (PaymentCard c in Cards)
                line += c.ToString();
            return base.ToString() + "Serv ; " + line + "; ";
        }
    }
}