using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace UIT_Pokemon
{
    [Serializable()]
    public class zipgame
    {
        public int[,] Matrix;
        public int score, hour, minute, second, number_pokemon;
        public int Remainpokemon,percent;
        public int level=1;
        public int helpclick, randomclick, smarteye;
        public int kindgame,sumfirstpokemon;
        public int Lifetime;
        public zipgame(int kind,int sum,int Life,int[,] Matrix,int _level, int number_ball, int score,int remain,int _percent,int help,int random,int smart, int hour, int minute, int second)
        {
            this.kindgame = kind;
            this.sumfirstpokemon = sum;
            this.Lifetime = Life;
            this.Matrix = Matrix;
            this.score = score;
            this.hour = hour;
            this.minute = minute;
            this.second = second;
            this.number_pokemon = number_ball;
            this.Remainpokemon = remain;
            this.percent = _percent;
            this.level = _level;
            this.helpclick = help;
            this.randomclick = random;
            this.smarteye = smart;
        }

    }
}
