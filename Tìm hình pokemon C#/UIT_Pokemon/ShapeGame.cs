using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace UIT_Pokemon
{
    class ShapeGame
    {
        public int Y, X;
        public int IDPokemon;
        public int Active;
        public ShapeGame()
        {
            SetDefault();
        }
        public void SetDefault()
        {
            X = -1;
            Y = -1;
            IDPokemon = -1;
            Active = -1;
        }
        public void Action(int _X,int _Y,int _IDPokemon,int _Active)
        {
            X = _X;
            Y = _Y;
            IDPokemon = _IDPokemon;
            Active = _Active;
        }
    }
}
