using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;


namespace UIT_Pokemon
{
    class LoadSaveGame
    {
        public static void SaveGame(zipgame zip, String filename)
        {
            Stream s = File.Open(filename, FileMode.Create);
            BinaryFormatter binary = new BinaryFormatter();
            try
            {
                binary.Serialize(s, zip);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi 7 :File khong the luu \n " + ex.Message);
            }
            s.Close();
            try
            {
                GC.Collect();
            }
            catch
            {
            }
        }
        public static zipgame LoadGame(String filename)
        {
            Stream s = File.Open(filename, FileMode.Open);
            BinaryFormatter binary = new BinaryFormatter();
            zipgame zip = (zipgame)binary.Deserialize(s);
            s.Close();
            try
            {
                GC.Collect();
            }
            catch
            { 
            }
            return zip;
        }
    }
}
