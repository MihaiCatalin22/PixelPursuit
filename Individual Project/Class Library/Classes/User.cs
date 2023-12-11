using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Classes
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z0-9]+$")]
        public string Username { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public DateOnly RegistrationDate { get; set; }
        public string UsernameColor { get; set; }
        public int ProfilePicture { get; set; }
        public string? Bio { get; set; }
        public bool? Banned { get; set; }
        public bool IsAdmin { get; set; }

        public User()
        {

        }


        public User(int id, string username, string password, string email, DateOnly registrationDate, string usernameColor, int profilePicture, string bio, bool banned, bool isAdmin)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            RegistrationDate = registrationDate;
            UsernameColor = usernameColor;
            ProfilePicture = profilePicture;
            Bio = bio;
            Banned = banned;
            IsAdmin = isAdmin;
        }

        public User(string username, string password, string email, bool isAdmin)
        {
            Username = username;
            Password = password;
            Email = email;
            RegistrationDate = DateOnly.FromDateTime(DateTime.Now);           
            UsernameColor = "#E8BCB3";
            ProfilePicture = 1;
            Bio = null;
            Banned = false;
            IsAdmin = isAdmin;
        }
    }
}
