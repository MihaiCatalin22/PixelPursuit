﻿using Class_Library.Classes;
using Class_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Controllers
{
    public class UserController
    {
        private IUserManagement userManager;
        public UserController(IUserManagement _userManager)
        {
            userManager = _userManager;
        }


        public bool Create(User user)
        {
            if (user != null)
            {
                foreach (User user1 in ReadAll())
                {
                    if (user1.Username == user.Username)
                    {
                        return false;
                    }
                }
                return userManager.Create(user);
            }
            return false;
        }
        public bool Update(User user)
        {
            if (user != null && GetUserFromId(user.Id) != null)
                return userManager.Update(user);
            return false;
        }
        public bool Delete(User user)
        {
            if (user != null && GetUserFromId(user.Id) != null)
                return userManager.Delete(user);
            return false;
        }

        public User[] ReadAll()
        {
            return userManager.ReadAll();
        }

        public User[] ReadAllUsers()
        {
            return userManager.ReadAllUsers();
        }

        public User[] ReadAllAdmins()
        {
            return userManager.ReadAllAdmins();
        }

        public User[] ReadAllUsersSearch(string search)
        {
            return userManager.ReadAllUsersSearch(search);
        }

        public User? GetUserFromUsername(string username)
        {
            if (username != null)
                return userManager.GetUserFromUsername(username);
            return null;
        }

        public User? GetUserFromId(int id)
        {
            if (id != null)
                return userManager.GetUserFromId(id);
            return null;
        }
    }
}
