﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
	public class Game
	{
		public string Name { get; set; }
		public string Genre { get; set; }
		public int AchievementsEarned { get; set; }
		public int AchievementsTotal { get; set; }
		public string AchievementProgress { get { return String.Format("{0}%", (AchievementsEarned / AchievementsTotal)); } }
		public bool Completed { get; set; }

	}
}
