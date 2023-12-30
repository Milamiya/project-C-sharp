using System;
using System.Collections.Generic;
using System.Text;

namespace UIT_PokemonHighScore
{
    [Serializable()]
    class List_highscore
    {
        public ListPlayer player_easy;
        public ListPlayer player_mid;
        public ListPlayer player_hard;
        public List_highscore(ListPlayer Player_easy, ListPlayer Player_mid, ListPlayer Player_hard)
        {
            this.player_easy = Player_easy;
            this.player_mid = Player_mid;
            this.player_hard = Player_hard;
        }
        public List_highscore(List_highscore a)
        {
            this.player_easy = a.player_easy;
            this.player_mid = a.player_mid;
            this.player_hard = a.player_hard;
        }
    }
}
