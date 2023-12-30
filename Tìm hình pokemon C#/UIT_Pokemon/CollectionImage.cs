using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace UIT_Pokemon
{
    static class CollectionImage
    {
        public static Bitmap[,] PokemonImage = CreatePokemon(global::UIT_Pokemon.Properties.Resources.pokemongame113,31, 5);
        public static Bitmap[,] PokemonImageLevel = CreatePokemon(global::UIT_Pokemon.Properties.Resources.PokemonAllLevel, 20, 5);
        public static Bitmap[] PokemonLevel = CreatePokemon(global::UIT_Pokemon.Properties.Resources.boom, 18);
        public static Bitmap[] Button_u_Panel = CreatePokemon(global::UIT_Pokemon.Properties.Resources.buttonchoose, 6);
        public static Bitmap[] Button_u_Panel_choose = CreatePokemon(global::UIT_Pokemon.Properties.Resources.buttonchooselight, 6);
        public static Bitmap[] Button_option = CreatePokemon(global::UIT_Pokemon.Properties.Resources.button_option, 6);
        public static Bitmap[] Button_option_choose = CreatePokemon(global::UIT_Pokemon.Properties.Resources.Option_panel_light, 6);
        static Bitmap[,] CreatePokemon(Bitmap bigbitmap, int PoNumber, int PoAction)
        {
            Bitmap[,] bm = new Bitmap[PoNumber, PoAction];
            float _Height = (float)bigbitmap.Height / PoAction;
            float _Width = (float)bigbitmap.Width / PoNumber;
            for(int i=0;i<PoNumber;i++)
                for (int j = 0; j < PoAction; j++)
                {
                    bm[i, j] = bigbitmap.Clone(new Rectangle((int)(i * _Width), (int)(j * _Height), (int)_Width, (int)_Height), System.Drawing.Imaging.PixelFormat.DontCare);
                }
            return bm;
        }
        public static Bitmap[] CreatePokemon(Bitmap bigbitmap, int number)
        {
            bigbitmap.MakeTransparent(Color.FromArgb(0, 0, 0));
            Bitmap[] bm = new Bitmap[number];
            float _Height = (float)bigbitmap.Height;
            float _Width = (float)bigbitmap.Width / number;
            for (int j = 0; j < number; j++)
            {
                bm[j] = bigbitmap.Clone(new Rectangle((int)(j * _Width), 0, (int)_Width, (int)_Height), System.Drawing.Imaging.PixelFormat.DontCare);
            }
            return bm;
        }
    }
}
