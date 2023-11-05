namespace SlutProjekt
{
    public static class TravelManager
    {
        public static void AddTravel(Travel toAdd)
        {
            User currentUser = (User)UserManger.signedInUser;

            if (currentUser != null)
            {
                currentUser.Travels.Add(toAdd);

            }
        }

        public static void RemoveTravel(Travel toRemove)
        {

        }

    }
}
