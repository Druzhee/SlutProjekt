using SlutProjekt.Enums;

namespace SlutProjekt
{
    public class WorkTrip : Travel
    {
        public string MeetingDetails { get; set; }

        public WorkTrip(string meetingDetails, int travellers, string destination, Country country) : base(travellers, destination, country)
        {
            MeetingDetails = meetingDetails;

        }
    }
}
