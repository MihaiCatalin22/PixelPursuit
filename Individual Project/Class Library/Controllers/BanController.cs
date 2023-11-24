using Class_Library.Classes;
using Class_Library.Interfaces;
using Class_Library.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Controllers
{
    public class BanController
    {
        private IBanManagement banManager;

        public BanController(IBanManagement _banManager)
        {
            banManager = _banManager;
        }

        public bool Create(Ban ban)
        {
            if (ban != null)
            {
                foreach (Ban ban1 in ReadAll())
                {
                    if (ban.StartDate == ban1.StartDate && ban.EndDate == ban1.EndDate && ban.Reason == ban1.Reason && ban.User.Id == ban1.User.Id && ban.Admin.Id == ban1.Admin.Id)
                        return false;
                }
                return banManager.Create(ban);
            }
            return false;
        }

        public Ban[] ReadAll()
        {
            return banManager.ReadAll();
        }

        public Ban[] ReadAllSearch(string search)
        {
            return banManager.ReadAllSearch(search);
        }

        public bool UnbanUser(User user)
        {
            var activeBan = ReadAllSearch(user.Username).FirstOrDefault(b => b.User.Id == user.Id && b.IsActive);

            if (activeBan != null)
            {
                activeBan.IsActive = false;
                bool updateResult = banManager.Update(activeBan);

                // Log the result for debugging
                Console.WriteLine("Unban operation result: " + updateResult);

                return updateResult;
            }
            else
            {
                Console.WriteLine("No active ban found for user: " + user.Username);
                return false;
            }
        }
    }
}

