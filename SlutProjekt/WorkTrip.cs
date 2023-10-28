namespace SlutProjekt
{
    public class WorkTrip : Travel
    {
        public string MeetingDetails { get; set; }

        public WorkTrip(string meetingDetails, int travellers, string destination) : base(travellers, destination)
        {
            MeetingDetails = meetingDetails;

        }
    }
}
