using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SpotifyProject
{
    public static class Validations
    {
        public static bool EmailIsValid(string email)
        {
            try
            {
                var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        public static bool StrongPassword(string password)
        {
            try
            {
                var regex = new Regex(@"^.*(?=.{8,})(?=.*[@#$%^&+=*])(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).*$");
                return regex.IsMatch(password);
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public static bool AveragePassword(string password)
        {
            try
            {
                var regex = new Regex(@"^.*(?=.{8,})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).*$");
                return regex.IsMatch(password);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
