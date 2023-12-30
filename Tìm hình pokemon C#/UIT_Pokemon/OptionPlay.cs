using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.IO;

namespace UIT_Pokemon
{
    [Serializable()]  
    class Config
    {
        public bool effect;
        public Color color;
        public bool English;
        public int kindgame;
        public int MaxLevel;
        public Config(bool e,Color c,bool english,int kind,int max)
        {
            this.effect = e;
            this.color = c;
            this.English = english;
            this.kindgame = kind;
            this.MaxLevel = max;
        }
    }
    class OptionPlay
    {
        
        public static String filename = "config.dat";
        public static String Location = Directory.GetCurrentDirectory();
        public static void WriteConfig(Config config)
        {
            Stream s = File.Open(filename, FileMode.Create);
            BinaryFormatter binary = new BinaryFormatter();
            binary.Serialize(s, config);
            s.Close();
            try
            {
                GC.SuppressFinalize(s);
                GC.Collect();
            }
            catch
            {
                // reported
            }
        }
        public static void WriteDefault()
        {
            WriteConfig(new Config(true, Color.DarkGreen,true,1,0));
        }
        public static Config ReadConfig()
        {
            if (!File.Exists(filename))
                WriteDefault();
            Stream s = File.Open(filename, FileMode.Open);
            BinaryFormatter binary = new BinaryFormatter();
            Config config = (Config)binary.Deserialize(s);
            s.Close();
            try
            {
                GC.SuppressFinalize(s);
                GC.Collect();
            }
            catch
            { }
            return config;
        }
        public static void WriteNewConfig(Config config)
        {
            WriteConfig(config);
        }
    }
}
