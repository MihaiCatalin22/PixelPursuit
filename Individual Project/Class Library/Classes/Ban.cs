using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Classes
{
    public class Ban
    {
        public int Id { get; private set; }
        public string Reason { get; set; }
        public User User { get; private set; }
        public User Admin { get; private set; }
        public DateOnly StartDate { get; private set; }
        public DateOnly EndDate { get; set; }

        public Ban(string reason, User user, User admin, DateOnly startDate, DateOnly endDate)
        {
            Reason = reason;
            User = user;
            Admin = admin;
            StartDate = startDate;
            EndDate = endDate;
        }
        public Ban(int id, string reason, User user, User admin, DateOnly startDate, DateOnly endDate)
        {
            Id = id;
            Reason = reason;
            User = user;
            Admin = admin;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
