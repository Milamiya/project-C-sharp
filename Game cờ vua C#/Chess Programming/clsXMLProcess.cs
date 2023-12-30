using System;

using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Xml;
namespace Chess_Programming
{
    public class clsXMLProcess
    {
        public static DataTable GetTable(string path)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(path);
            return ds.Tables[0];
        }
        public static void CreateNewOptions(string path)
        {
            XmlDocument doc = new XmlDocument();
            //Khai Bao Tieu De File XML
            XmlDeclaration xmlDec = doc.CreateXmlDeclaration("1.0", "utf-8", "");
            //Khai Bao Nut Goc
            XmlNode root = doc.CreateElement("config");
            //Khai Bao Nut Con
            XmlNode CellSize = doc.CreateElement("CELLSIZE");            
            XmlNode PieceSize = doc.CreateElement("PIECESIZE");
            XmlNode BoardStyle = doc.CreateElement("BOARDSTYLE");
            XmlNode PieceStyle = doc.CreateElement("PIECESTYLE");
            XmlNode PlaySound = doc.CreateElement("PLAYSOUND");            

            //add node con vao node root
            root.AppendChild(CellSize);
            root.AppendChild(PieceSize );
            root.AppendChild(BoardStyle );
            root.AppendChild(PieceStyle );
            root.AppendChild(PlaySound);
            
            //add declaration vao document
            doc.AppendChild(xmlDec);
            //add root vao document
            doc.AppendChild(root);
            //save
            doc.Save(path);
        }

        public static void CreateNewTrainingDatabase(string path)
        {
            XmlDocument doc = new XmlDocument();
            //Khai Bao Tieu De File XML
            XmlDeclaration xmlDec = doc.CreateXmlDeclaration("1.0", "utf-8", "");
            //Khai Bao Nut Goc
            XmlNode root = doc.CreateElement("TrainingData");
            //Khai Bao Nut Con
            XmlNode Name = doc.CreateElement("Name");
            XmlNode FEN = doc.CreateElement("FEN");
            XmlNode Moves = doc.CreateElement("Moves");



            //add node con vao node root           
            root.AppendChild(Name);
            root.AppendChild(FEN);
            root.AppendChild(Moves);

            //add declaration vao document
            doc.AppendChild(xmlDec);
            //add root vao document
            doc.AppendChild(root);
            //save
            doc.Save(path);
        }

        public static void CreateNewProfile(string path)
        {
            XmlDocument doc = new XmlDocument();
            //Khai Bao Tieu De File XML
            XmlDeclaration xmlDec = doc.CreateXmlDeclaration("1.0", "utf-8", "");
            //Khai Bao Nut Goc
            XmlNode root = doc.CreateElement("profile");
            //Khai Bao Nut Con
            XmlNode PlayerName = doc.CreateElement("PlayerName");
            XmlNode Avatar= doc.CreateElement("Avatar");
            XmlNode TotalGames = doc.CreateElement("TotalGames");
            XmlNode TotalWin = doc.CreateElement("TotalWin");
            XmlNode TotalLose = doc.CreateElement("TotalLose");
            XmlNode TotalDraw = doc.CreateElement("TotalDraw");
            XmlNode Rating = doc.CreateElement("Rating");

            //add node con vao node root
            root.AppendChild(PlayerName );
            root.AppendChild(Avatar);
            root.AppendChild(TotalGames);
            root.AppendChild(TotalWin );
            root.AppendChild(TotalLose );
            root.AppendChild(TotalDraw );
            root.AppendChild(Rating );

            //add declaration vao document
            doc.AppendChild(xmlDec);
            //add root vao document
            doc.AppendChild(root);
            //save
            doc.Save(path);
        }
    }
}
