using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyProject
{
    public class User
    {
        private string username;
        private string email;
        private string password;
        public string Username { get { return username; } set { username = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        public bool UserameIsValid(string name)
        {
            MySqlDataReader dr = SQLCommands.Read();
            while (dr.Read())
            {
                if (dr["Name"].ToString() == name)
                    return false;
            }
            Username = name;
            return true;
        }
        public bool EmailIsValid(string email)
        {
            MySqlDataReader dr = SQLCommands.Read();
            while (dr.Read())
            {
                if (dr["Email"].ToString() == email)
                {
                    return false;
                }
            }
            Email = email;
            return true;
        }
    }
}
