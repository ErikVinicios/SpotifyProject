using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public bool UsernameIsValid(string userame)
        {
            MySqlDataReader dr = SQLCommands.Read();
            while (dr.Read())
            {
                if (dr["Username"].ToString() == userame)
                    return false;
            }
            Username = userame;
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
        public string PasswordForce(string password)
        {
            if (password.Length < 8)
            {
                return "Shot";
            }

            if (Validations.StrongPassword(password))
            {
                Password = password;
                return "Strong";
            }
            else if (Validations.AveragePassword(password))
            {
                Password = password;
                return "Average";
            }
            else
            {
                Password = password;
                return "Weak";
            }
        }
    }
}
