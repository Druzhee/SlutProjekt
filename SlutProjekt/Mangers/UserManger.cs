using System.Collections.Generic;

namespace SlutProjekt
{
    public static class UserManger
    {
        public static List<IUser> Users { get; set; } = new()
        {

            new Admin("admin", "password"),
            new User("user", "password")
            {
                Travels = new List<Travel>()
                {
                    new Vacation(true, 2, "Krakow", Enums.Country.Poland)
                    {

                    },
                    new WorkTrip("Speak to John", 2, "Paris", Enums.Country.France)
                    {

                    }
                }
            }
        };
        public static IUser? signedInUser { get; set; }

        public static bool AddUser(IUser userToAdd)
        {
            if (!ValidateUsername(userToAdd.Username))
            {
                return false;
            }

            Users.Add(userToAdd);

            return true;
        }

        public static void RemoveUser(IUser userToRemove)
        {
            Users.Remove((User)userToRemove);

        }

        private static bool ValidateUsername(string username)
        {
            bool isValidUsername = true;

            foreach (IUser user in Users)
            {
                if (user.Username == username)
                {
                    isValidUsername = false;
                }
            }
            return isValidUsername;

        }

        public static bool UpdateUsername(IUser user, string choosenUsername)
        {
            if (user == null)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(choosenUsername))
            {
                return false;
            }
            user.Username = choosenUsername;
            return true;
        }

        public static bool LogInUser(string username, string password)
        {
            foreach (IUser user in Users)
            {
                if (username == user.Username && password == user.Password)
                {
                    signedInUser = user;

                    return true;
                }
            }
            return false;
        }
    }

}
