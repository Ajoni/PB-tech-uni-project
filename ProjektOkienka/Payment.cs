namespace ProjektOkienka
{
    public class Payment
    {
        public string FromKRS { get; set; }
        public string FromCard { get; set; }
        public string Amount { get; set; }
        public string ToKRS { get; set; }
        public string ToCard { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }

        public Payment(string SetFromKRS, string SetFromCard, string SetAmount, string SetToKRS, string SetToCard, string SetTitle, string SetDate)
        {
            FromKRS = SetFromKRS; FromCard = SetFromCard; Amount = SetAmount; ToKRS = SetToKRS; ToCard = SetToCard; Title = SetTitle; Date = SetDate;
        }

        public override string ToString()
        {
            return $"{FromKRS};{FromCard};{Amount};{ToKRS};{ToCard};{Title};{ Date};";
        }
    }
}