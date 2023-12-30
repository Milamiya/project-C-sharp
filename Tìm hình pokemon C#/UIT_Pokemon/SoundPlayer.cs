using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Media;

namespace UIT_Pokemon
{
    class UITSoundPlayer
    {
        public static SoundPlayer media_move = new SoundPlayer(global::UIT_Pokemon.Properties.Resources.move);
        public static SoundPlayer media_cantmove = new SoundPlayer(global::UIT_Pokemon.Properties.Resources.cantmove);
        public static SoundPlayer media_Die = new SoundPlayer(global::UIT_Pokemon.Properties.Resources.destroy);
        public static SoundPlayer media_Pikachu = new SoundPlayer(global::UIT_Pokemon.Properties.Resources.pikachu);
    
    }
}
