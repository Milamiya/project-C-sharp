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
	class SaveAndLoad
	{
		public static void saveGame(GameShape g, string filename)
		{
			Stream s = File.Open(filename, FileMode.Create);
			BinaryFormatter b = new BinaryFormatter();
			b.Serialize(s, g);
			s.Close();
		}

		public static GameShape loadGame(string filename)
		{
			Stream s = File.Open(filename, FileMode.Open);
			BinaryFormatter b = new BinaryFormatter();
			GameShape g = (GameShape)b.Deserialize(s);
			s.Close();
			return g;
		}
	}
}
