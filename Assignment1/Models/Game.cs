using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
	public class Game
	{
		public Game(string n, string g, int ae, int at, bool c) //Lazy Naming.
		{
			Name = n;
			Genre = g;
			AchievementsEarned = ae;
			AchievementsTotal = at;
			Completed = c;
		}

		[Required]
		public string Name { get; set; }

		[Required]
		public string Genre { get; set; }

		public int AchievementsEarned { get; set; }

		private int _AchievementsTotal;
		public int AchievementsTotal
		{
			get { return _AchievementsTotal; }
			set
			{
				if (value == 0)
					_AchievementsTotal = -1; //Arbitrary -1 to prevent division by zero.
				else
					_AchievementsTotal = value;
			} 
		}

		public string AchievementProgress
		{
			get
			{
				double PercentageValue = AchievementsEarned / (double)AchievementsTotal * 100;
				return String.Format("{0:0.00}% completed.", PercentageValue);
			}
		}

		[Required]
		private bool Completed { get; set; }

		public string Status
		{
			get { return (Completed) ? "Finished, " : "Still playing,"; }
		}

	}
}
