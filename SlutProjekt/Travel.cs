namespace SlutProjekt
{
    public class Travel
    {
        public int Travellers { get; set; }
        public string Destination { get; set; }

        public Travel(int travellers, string destination)
        {
            Travellers = travellers;
            Destination = destination;
        }
    }
}