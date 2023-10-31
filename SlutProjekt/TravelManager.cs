using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjekt
{
    public static class TravelManager
    {
        public static void AddTravel(Travel toAdd) 
        {
            User currentUser = (User)UserManger.signedInUser;
            if(currentUser != null)
            {
                currentUser.Travels.Add(toAdd);

            }
        }

        public static void RemoveTravel(Travel toRemove)
        {
           
        }
            
    }
}
