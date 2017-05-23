using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment1.Models
{
	public static class GameLibrary
	{
		private static List<Game> _MyGameLibrary = new List<Game>();

		public static IEnumerable<Game> MyGameLibrary
		{
			get { return _MyGameLibrary; }
		}

		public static void AddGame(Game game)
		{
			_MyGameLibrary.Add(game);
		}
	}
}
