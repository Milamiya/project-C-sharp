using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace UIT_Pokemon
{
    class Piece:System.Windows.Forms.PictureBox
    {
        public int X, Y,ID=-1;
        public int IDAction = -1;
        public bool Locked=false;
        public Piece(int x,int y)
        {
            X = x;
            Y = y;
            ControlRegion.CreateControl(this, CollectionImage.PokemonImage[1, 0]);
            this.Location = new Point(Information.StartLocation.X+x * Information.PokemonPieceSize.Width-x*6,Information.StartLocation.Y+ y * Information.PokemonPieceSize.Height-y*3);
            //this.Anchor = AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top;
        }
        public void Default(int IDPokemon)
        {
            if (IDPokemon >= 0)
            {
                if (IDPokemon >= Information.CurrentKindGame && Information.Level >= 1)
                {
                    this.BackgroundImage = CollectionImage.PokemonImageLevel[IDPokemon - Information.CurrentKindGame,0];
                }
                else
                {
                    this.BackgroundImage = CollectionImage.PokemonImage[IDPokemon, 0];
                }
                IDAction = 0;
                ID = IDPokemon;
                this.Show();
            }
            else
            {
                this.BackgroundImage = null;
                this.Hide();
                Locked = true;
            }
            
        }
        public void Default()
        {
            if (ID >= 0)
            {
                if (ID >= Information.CurrentKindGame && Information.Level >= 1)
                {
                    this.BackgroundImage = CollectionImage.PokemonImageLevel[ID- Information.CurrentKindGame,0];
                }
                else
                {
                    this.BackgroundImage = CollectionImage.PokemonImage[ID, 0];
                }
                IDAction = 0;
            }
            else
            {
                this.Hide();
                Locked = true;
            }

        }
        public void PokemonCouple()
        {
            if (ID >= 0)
            {
                if (ID >= Information.CurrentKindGame && Information.Level >= 1)
                {
                    this.BackgroundImage = CollectionImage.PokemonImageLevel[ID - Information.CurrentKindGame, 4];
                }
                else
                {
                    this.BackgroundImage = CollectionImage.PokemonImage[ID, 4];
                }
                IDAction = 4;
            }
            else
            {
                this.Hide();
                Locked = true;
            }

        }
        public void PokemonCouple2()
        {
            if (ID >= 0)
            {
                if (ID >= Information.CurrentKindGame && Information.Level >= 1)
                {
                    this.BackgroundImage = CollectionImage.PokemonImageLevel[ID - Information.CurrentKindGame, 2];
                }
                else
                {
                    this.BackgroundImage = CollectionImage.PokemonImage[ID, 2];
                }
                IDAction = 2;
            }
            else
            {
                this.Hide();
                Locked = true;
            }

        }
        public void HighLight(int IDPokemon)
        {
            if (IDPokemon < 0)
                return;
            if (ID >= Information.CurrentKindGame && Information.Level >= 1)
            {
                this.BackgroundImage = CollectionImage.PokemonImageLevel[ID - Information.CurrentKindGame, 1];
            }
            else
            {
                this.BackgroundImage = CollectionImage.PokemonImage[ID, 1];
            }
            IDAction = 1;
        }
        public void MakePoint(int IDPokemon)
        {
            if (IDPokemon < 0)
                return;
            if (ID >= Information.CurrentKindGame && Information.Level >= 1)
            {
                this.BackgroundImage = CollectionImage.PokemonImageLevel[ID - Information.CurrentKindGame, 3];
            }
            else
            {
                this.BackgroundImage = CollectionImage.PokemonImage[ID, 3];
            }
            IDAction = 3;
        }
    }
}
