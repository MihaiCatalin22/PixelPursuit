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


        //{
        //		private IBanManagement banManager;

        //		public BanController(IBanManagement _banManager)
        //		{
        //			banManager = _banManager;
        //		}

        //		public bool Create(Ban ban)
        //		{
        //			if (ban != null)
        //			{
        //				foreach (Ban ban1 in ReadAll())
        //				{
        //					if (ban.StartDate == ban1.StartDate && ban.EndDate == ban1.EndDate && ban.Reason == ban1.Reason && ban.User.Id == ban1.User.Id && ban.Admin.Id == ban1.Admin.Id)
        //						return false;
        //				}
        //				return banManager.Create(ban);
        //			}
        //			return false;
        //		}

        //		public Ban[] ReadAll()
        //		{
        //			return banManager.ReadAll();
        //		}

        //		public Ban[] ReadAllSearch(string search)
        //		{
        //			return banManager.ReadAllSearch(search);
        //		}

        //		public bool UnbanUser(User user)
        //		{
        //			foreach (Ban ban in ReadAllSearch(user.Username))
        //			{
        //				if (ban.User == user && ban.EndDate < DateOnly.FromDateTime(DateTime.Now))
        //				{
        //					return true;
        //				}
        //			}
        //			return false;
        //		}
        //	}
    }
}
