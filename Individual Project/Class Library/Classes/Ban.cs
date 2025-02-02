﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library.Classes
{
	public class Ban
	{
		public int Id { get; private set; }
		public DateOnly StartDate { get; private set; }
		public DateOnly EndDate { get; set; }
		public string Reason { get; set; }
		public User User { get; private set; }
		public User Admin { get; private set; }
        public bool IsActive { get; set; }
        public Ban(DateOnly startDate, DateOnly endDate, string reason, User user, User admin, bool isActive)
		{
			StartDate = startDate;
			EndDate = endDate;
			Reason = reason;
			User = user;
			Admin = admin;
			IsActive = isActive;
		}

		public Ban(int id, DateOnly startDate, DateOnly endDate, string reason, User user, User admin, bool isActive)
		{
			Id = id;
			StartDate = startDate;
			EndDate = endDate;
			Reason = reason;
			User = user;
			Admin = admin;
			IsActive = isActive;
		}
	}
}
