﻿using Class_Library.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Interfaces
{
    public interface IUserManagement
    {
        public bool Create(User user);
        public User[] ReadAll();
        public User[] ReadAllUsers();
        public User[] ReadAllAdmins();
        public User[] ReadAllUsersSearch(string search);
        public bool Update(User user);
        public bool Delete(User user);
        public string? GetSalt(User user);
        public User? GetUserFromUsername(string username);
        public User? GetUserFromEmail(string email);
        public User? GetUserFromId(int id);
        public bool UpdateUserBanStatus(int userId, bool isBanned);
        public List<ProfileImage> GetAllProfilePictures();
        public string GetProfilePictureUrlById(int id);
    }
}

