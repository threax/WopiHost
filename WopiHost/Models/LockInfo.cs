﻿using System;

namespace WopiHost.Models
{
	public class LockInfo
	{
		public string Lock { get; set; }

		public DateTime DateCreated { get; set; }

		public bool Expired { get { return DateCreated.AddMinutes(30) < DateTime.UtcNow; } }
	}
}
