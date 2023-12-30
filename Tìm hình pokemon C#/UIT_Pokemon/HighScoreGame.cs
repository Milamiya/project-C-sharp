using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
namespace UIT_PokemonHighScore
{
    class HighScoreGame
    {
        public static String filename = UIT_Pokemon.Information.fileHighScore;
        public static void WriteHighScore(List_highscore Players)
        {
            Stream s = File.Open(filename, FileMode.Create);
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(s, Players);
            s.Close();
        }
        public static void WriteDefault()
        {
            Player[] player_easy = new Player[10];
            Player[] player_mid = new Player[10];
            Player[] player_hard = new Player[10];
            for (int i = 0; i < 10; i++)
            {
                player_easy[i] = new Player("UIT", "Medium",i/2+1, i * i * 15, 1, i * 4, i * 3);
                player_mid[i] = new Player("POKEMON AWARE", "Hard",i/2+1, i * i * 22, 1, i * 6, i * 5);
                player_hard[i] = new Player("UIT POKEMON Champion", "Hardest",i/2+1, i * i * 23+ 50, 1, i * 5, i * 6);
            }
            ListPlayer list_easy = new ListPlayer(player_easy);
            ListPlayer list_mid = new ListPlayer(player_mid);
            ListPlayer list_hard = new ListPlayer(player_hard);
            list_easy.sort();
            list_mid.sort();
            list_hard.sort();
            WriteHighScore(new List_highscore(list_easy, list_mid, list_hard));
        }
        public static List_highscore ReadHighScore()
        {
            if (!File.Exists(filename))
                WriteDefault();
            Stream s = File.Open(filename, FileMode.Open);
            BinaryFormatter binary = new BinaryFormatter();
            List_highscore hs = (List_highscore)binary.Deserialize(s);
            s.Close();
            return hs;
        }
        public static void WriteNewScore(Player player, int kind)
        {

            List_highscore ls = HighScoreGame.ReadHighScore();

            if (kind == 1)
            {
                ListPlayer p = ls.player_easy;
                p.player[9] = player;
                ls.player_easy.sort();
                WriteHighScore(new List_highscore(p, ls.player_mid, ls.player_hard));
            }
            else if (kind == 2)
            {
                ListPlayer p = ls.player_mid;
                p.player[9] = player;
                ls.player_mid.sort();
                WriteHighScore(new List_highscore(ls.player_easy, p, ls.player_hard));
            }
            else
            {
                ListPlayer p = ls.player_hard;
                p.player[9] = player;
                ls.player_hard.sort();
                WriteHighScore(new List_highscore(ls.player_easy, ls.player_mid, p));
            }

        }
    }
}
