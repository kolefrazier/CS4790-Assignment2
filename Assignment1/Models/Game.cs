using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
	public class Game
	{
		//Constructors
		public Game() { }

		//Defined constructor for pre-seed data needs.
		public Game(string n, string g, int ae, int at, string s) //Lazy Naming.
		{
			Name = n;
			Genre = g;
			AchievementsEarned = ae;
			AchievementsTotal = at;
			Status = s;
		}

		//Properties
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
				if (value <= 0)
					_AchievementsTotal = -1; //Arbitrary -1 to prevent division by zero.
				else
					_AchievementsTotal = value;
			} 
		}

		private double _AchievementPercentage;
		public string AchievementProgress
		{
			get
			{
				_AchievementPercentage = AchievementsEarned / (double)AchievementsTotal * 100;

				if (_AchievementPercentage < 0)
					_AchievementPercentage *= -1;
				else if (_AchievementPercentage > 100.00)
					_AchievementPercentage = 100.00;

				return String.Format("{0:0.00}% achievements earned", _AchievementPercentage);
			}
		}

		[Required]
		public string Status { set; get; }

		public string DisplayColor
		{
			get
			{
				if (_AchievementPercentage >= 100.0)
					//return "orange accent-3";
					return "game-completed";
				else
					//return "green lighten-2";
					return "game-regular";
			}
		}

	}
}
