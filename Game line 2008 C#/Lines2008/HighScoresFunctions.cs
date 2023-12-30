/**********************************/
/*                                */
/* Author: BUI VAN NGHIA          */
/* Email: katatunix@yahoo.com     */
/*                 [May, 2008]    */
/*                                */
/**********************************/

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lines2008
{
	class HighScoresFunctions
	{
		public static string filename = "scores.dat";
		
		public static PlayerList readHighScores()
		{
			if (!File.Exists(filename)) writeDefaultHighScores();
			Stream s = File.Open(filename, FileMode.Open);
			BinaryFormatter b = new BinaryFormatter();
			PlayerList pl = (PlayerList)b.Deserialize(s);
			s.Close();
			return pl;
		}

		public static void writeHighScores(PlayerList pl)
		{
			Stream s = File.Open(filename, FileMode.Create);
			BinaryFormatter b = new BinaryFormatter();
			b.Serialize(s, pl);
			s.Close();
		}

		public static void writeDefaultHighScores()
		{
			Player[] p = new Player[10];
			for (int i = 0; i < 10; i++)
			{
				p[i] = new Player("Kata Tunix", 5, 0, 1, 0);
			}

			writeHighScores(new PlayerList(p));
		}

		public static int getMaxScores()
		{
			PlayerList pl = readHighScores();
			return pl.list[0].scores;
		}

		public static Player getWorstPlayer()
		{
			PlayerList pl = readHighScores();
			return pl.list[9];
		}

		public static void insert(Player p)
		{
			PlayerList pl = readHighScores();
			int i, j;
			for (i = 0; i < 10; i++)
				if (Player.less(pl.list[i], p)) break;
			for (j = 9; j >= i + 1; j--)
				pl.list[j] = pl.list[j - 1];
			pl.list[i] = p;
			writeHighScores(pl);
		}
	}
}
