namespace SlutProjekt
{
    public class Vacation : Travel
    {
        public bool AllInclusive { get; set; }


        public Vacation(bool allInclusive, int travellers, string destination) : base(travellers, destination)
        {
            AllInclusive = allInclusive;
        }
    }
}
