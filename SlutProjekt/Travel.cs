using SlutProjekt.Enums;

namespace SlutProjekt
{
    public class Travel
    {
        public int Travellers { get; set; }
        public string Destination { get; set; }
        public Country Country { get; set; }
        public Travel(int travellers, string destination, Country country)
        {
            Travellers = travellers;
            Destination = destination;
            Country = country;
        }
    }
}