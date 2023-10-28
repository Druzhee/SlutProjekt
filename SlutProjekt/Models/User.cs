using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<Travel> Travels { get; set; }
    }
}
