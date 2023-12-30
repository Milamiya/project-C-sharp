using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace UIT_Pokemon
{
    [Serializable]
    class ImageFile
    {
        public Bitmap ImageLevel = null;
        public int level;
        public ImageFile(Bitmap i,int l)
        {
            ImageLevel = i;
            level = l;
        }
    }
    class ReadfileImage
    {
        public static ImageFile ReadFile(String filename)
        {
            if (!File.Exists(filename))
                return null;

            Stream s = File.Open(filename, FileMode.Open);
            BinaryFormatter b = new BinaryFormatter();
            ImageFile a = (ImageFile)b.Deserialize(s);
            s.Close();
            try
            {
                GC.SuppressFinalize(s);
            }
            catch
            {
 
            }
            return a;
        }
    }
    class LevelFile
    {
        public static void WriteFile(String filename)
        {
            if (File.Exists(filename))
                return;
            Stream s = File.Open(filename, FileMode.Create);
            ImageFile a = new ImageFile(new Bitmap("C:\\Users\\Acer\\Desktop\\New Folder (4)\\game level\\level15.png"),15);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(s, a);
            s.Close();
            try
            {
                a = null;
                GC.SuppressFinalize(a);
                GC.Collect();
            }
            catch 
            { 
            }
            
        }
    }
}