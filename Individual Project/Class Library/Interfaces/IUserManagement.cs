using Class_Library.Classes;
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
        public bool Update(User user);
        public bool Delete(User user);
        public User[] ReadAll();
        public User[] ReadAllUsers();
        public User[] ReadAllAdmins();
        public User[] ReadAllUsersSearch(string search);       
        public User? GetUserFromUsername(string username);
        public User? GetUserFromId(int id);
        
    }
}
