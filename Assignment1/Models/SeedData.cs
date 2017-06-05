using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
	public class SeedData
	{
		public static void Initialize()
		{
			GameLibrary.AddGame(new Game("NieR Automata", "RPG", 16, 20, "Completed"));
			GameLibrary.AddGame(new Game("Team Fortress 2", "FPS", 138, 275, "Never ending"));
			GameLibrary.AddGame(new Game("Ori and the Blind Forest", "Platformer", 27, 30, "Completed"));
			GameLibrary.AddGame(new Game("Binding of Isaac: Rebirth", "Roguelike", 10, 80, "Completed"));
			GameLibrary.AddGame(new Game("Everspace", "Science Fiction", 3, 50, "In Progress"));
			GameLibrary.AddGame(new Game("TEST 100% Achievements", "FPS", 75, 75, "Completed"));
			GameLibrary.AddGame(new Game("TEST Negative Achievements", "Glitched", -1, 2, "Completed"));
			GameLibrary.AddGame(new Game("TEST 0 Achievements", "Unopened Box", 0, 1, "Still in box"));
			GameLibrary.AddGame(new Game("TEST 1 of 0 Achievements", "ERROR", 1, 0, "DIV ZERO"));
			GameLibrary.AddGame(new Game("TEST 150% Achievements", "Overachievements", 3, 2, "Completed"));
		}
	}
}
