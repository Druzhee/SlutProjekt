namespace SlutProjekt
{
    public class Admin : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public object Travels { get; internal set; }

        public Admin(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
