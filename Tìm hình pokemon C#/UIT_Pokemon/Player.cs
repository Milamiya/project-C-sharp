using System;
using System.Collections.Generic;
using System.Text;

namespace UIT_PokemonHighScore
{
    [Serializable()]
    class Player
    {
        public String name;
        public String king_of_game;
        public int score;
        public int Level;
        public int hour;
        public int minute;
        public int second;
        public Player(Player a)
        {
            this.name = a.name;
            this.king_of_game = a.king_of_game;
            this.score = a.score;
            this.Level = a.Level;
            this.hour = a.hour;
            this.minute = a.minute;
            this.second = a.second;
        }
        public Player(String name, String king_of_game,int Level, int score, int hour, int minute, int second)
        {
            this.name = name;
            this.king_of_game = king_of_game;
            this.Level = Level;
            this.score = score;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public int total_time()
        {
            return hour * 3600 + minute * 60 + second;
        }
        public String[] Convert(int index)
        {
            String[] str = new String[6];
            str[0] = index.ToString();
            str[1] = name;
            str[2] = king_of_game;
            str[3] = Level.ToString();
            str[4] = score.ToString();
            if (hour < 10)
                str[5] += "0" + hour.ToString() + " : ";
            else
                str[5] += hour.ToString() + " : ";
            if (minute < 10)
                str[5] += "0" + minute.ToString() + " : ";
            else
                str[5] += minute.ToString() + " : ";
            if (second < 10)
                str[5] += "0" + second.ToString();
            else
                str[5] += second.ToString();
            return str;
        }

    }
}
