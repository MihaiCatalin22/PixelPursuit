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
        //private BanController banController = new BanController(new BanDAL());
        public User? LoginUsername(string username, string password)
        {
            foreach (User user in userController.ReadAllUsers())
            {               
                if (user.Username == username && user.Password == password)
                {
                    //if (banController.UnbanUser(user))
                    //{
                    //    user.Banned = false;
                    //    userController.Update(user);
                    //}
                    return user;
                }
            }
            return null;
        }

        public User? LoginEmail(string email, string password)
        {
            foreach (User user in userController.ReadAllUsers())
            {
               
                if (user.Email == email && user.Password == password)
                {
                    //if (banController.UnbanUser(user))
                    //{
                    //    user.Banned = false;
                    //    userController.Update(user);
                    //}
                    return user;
                }
            }
            return null;
        }

        public User? LoginUsernameAdmin(string username, string password)
        {
            foreach (User user in userController.ReadAllAdmins())
            {              
                if (user.Username == username && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }
    }
}

