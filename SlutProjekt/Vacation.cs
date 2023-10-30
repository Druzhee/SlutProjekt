using SlutProjekt.Enums;

namespace SlutProjekt
{
    public class Vacation : Travel
    {
        public bool AllInclusive { get; set; }


        public Vacation(bool allInclusive, int travellers, string destination, Country country) : base(travellers, destination, country)
        {
            AllInclusive = allInclusive;
        }
    }
}
