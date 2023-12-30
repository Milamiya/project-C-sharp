using System;
using System.Collections.Generic;
using System.Text;

namespace UIT_PokemonHighScore
{
    [Serializable()]
    class ListPlayer
    {
        public Player[] player;
        public ListPlayer(Player[] play)
        {
            this.player = play;
        }
        public Player Getplayer(int index)
        {
            Player a = player[index];
            return a;
        }
        public int GetMinScore()
        {
            int minScore = player[0].score;
            for (int i = 1; i < player.Length; i++)
            {
                if (minScore > player[i].score)
                    minScore = player[i].score;
            }
            return minScore;
        }
        public int GetMaxScore()
        {
            int MaxScore = player[0].score;
            for (int i = 1; i < player.Length; i++)
            {
                if (MaxScore < player[i].score)
                    MaxScore = player[i].score;
            }
            return MaxScore;
        }
        public int GetMinTime()
        {
            int minTime = player[0].total_time();
            for (int i = 1; i < player.Length; i++)
            {
                if (minTime > player[i].total_time())
                    minTime = player[i].score;
            }
            return minTime;
        }
        public void swap(int i, int j)
        {
            Player a = new Player(player[i]);
            Player b = new Player(player[j]);
            player[i] = new Player(b);
            player[j] = new Player(a);
        }
        public void sort()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (player[i].score < player[j].score)
                        swap(i, j);
                    else if (player[i].score == player[j].score)
                    {
                        if (player[i].Level < player[j].Level)
                            swap(i, j);
                        else if(player[i].Level==player[j].Level)
                        {
                            if (player[i].total_time() > player[j].total_time())
                                swap(i, j);
                            else if (player[i].total_time() == player[j].total_time())
                            {

                                if (player[i].name.CompareTo(player[j].name) > 0)
                                    swap(i, j);
                            }
                        }
                    }
                }
            }
        }
    }
}
