using Class_Library.DAL;
using Class_Library.Classes;
using Class_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Controllers
{
    public class LoginController
    {
        private UserController userController = new UserController(new UserDAL());
        private BanController banController = new BanController(new BanDAL());
    
        public User? LoginUsername(string username, string password)
        {
            try
            {
                foreach (User user in userController.ReadAllUsers())
                {
                    string salt = userController.GetSalt(user);
                    string hashPassword = HashPassword.GenerateHashedPassword(password, salt);

                    if (user.Username == username && user.Password == hashPassword)
                    {
                        if (!banController.IsUserCurrentlyBanned(user.Id))
                        {
                            return user;
                        }
                        else
                        {

                            return null;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }   
        }

        public User? LoginEmail(string email, string password)
        {
            try
            {
                foreach (User user in userController.ReadAllUsers())
                {
                    string salt = userController.GetSalt(user);
                    string hashPassword = HashPassword.GenerateHashedPassword(password, salt);

                    if (user.Email == email && user.Password == hashPassword)
                    {
                        if (!banController.IsUserCurrentlyBanned(user.Id))
                        {
                            return user;
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }        
        }

        public User? LoginUsernameAdmin(string username, string password)
        {
            try
            {
                foreach (User user in userController.ReadAllAdmins())
                {
                    string salt = userController.GetSalt(user);
                    string hashPassword = HashPassword.GenerateHashedPassword(password, salt);

                    if (user.Username == username && user.Password == hashPassword)
                    {
                        return user;
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }     
        }
        public bool IsUserBanned(string username)
        {
            var user = userController.GetUserFromUsername(username);
            if (user != null)
            {
                return banController.IsUserCurrentlyBanned(user.Id);
            }
            return false;
        }
    }
}

