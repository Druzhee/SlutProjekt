using System.Collections.Generic;

namespace SlutProjekt
{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public List<Travel> Travels { get; set; } = new();
    }
}
