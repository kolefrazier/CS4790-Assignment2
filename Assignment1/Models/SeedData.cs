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
			GameLibrary.AddGame(new Game("NieR Automata", "RPG", 16, 20, true));
			GameLibrary.AddGame(new Game("Team Fortress 2", "FPS", 138, 275, false));
			GameLibrary.AddGame(new Game("Ori and the Blind Forest", "Platformer", 27, 30, true));
			GameLibrary.AddGame(new Game("Binding of Isaac: Rebirth", "Roguelike", 10, 80, true));
			GameLibrary.AddGame(new Game("Everspace", "Science Fiction", 3, 50, false));
		}
	}
}
