using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class_Library.Interfaces;
namespace Class_Library.Classes
{
    public class HashPassword
    {
        public static string GenerateHashedPassword(string password, string salt)
        {
            string hashPassword = BCrypt.Net.BCrypt.HashPassword(password, salt);
            return hashPassword;
        }

        public static string GenerateSalt()
        {
            return BCrypt.Net.BCrypt.GenerateSalt();
        }
    }
}
