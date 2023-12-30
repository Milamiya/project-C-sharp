using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Chess_Usercontrol;
using System.Data;
namespace Chess_Programming
{
    public class clsSavedGame
    {
        private GameMode  _GameMode;

        public GameMode  GameMode
        {
            get { return _GameMode; }
            set { _GameMode = value; }
        }

        private GameDifficulty _Diff;

        public GameDifficulty GameDifficulty
        {
            get { return _Diff; }
            set { _Diff = value; }
        }

        private ChessSide _OwnSide;

        public ChessSide OwnSide
        {
            get { return _OwnSide ; }
            set { _OwnSide  = value; }
        }

        private string _FEN;

        public string FEN
        {
            get { return _FEN; }
            set { _FEN = value; }
        }
        private string _MoveList;

        public string MoveList
        {
            get { return _MoveList; }
            set { _MoveList = value; }
        }

        private short _Limit;

        public short TimeLimit
        {
            get { return _Limit; }
            set { _Limit = value; }
        }
        private short _Bonus;

        public short TimeBonus
        {
            get { return _Bonus; }
            set { _Bonus = value; }
        }


        private short _mRemain1;

        public short MinutesRemaining1
        {       
            get { return _mRemain1; }
            set { _mRemain1 = value; }
        }
        private short _mRemain2;

        public short MinutesRemaining2
        {
            get { return _mRemain2; }
            set { _mRemain2 = value; }
        }

        private short _sRemain1;

        public short SecondsRemaining1
        {
            get { return _sRemain1; }
            set { _sRemain1 = value; }
        }
        private short _sRemain2;

        public short SecondsRemaining2
        {
            get { return _sRemain2; }
            set { _sRemain2 = value; }
        }	
	

        public clsSavedGame()
        {

        }
        public clsSavedGame(GameMode eGameMode,GameDifficulty eDifficulty,ChessSide eOwnSide, string strFEN,string strMoveList)
        {
            this._GameMode = eGameMode;
            this._Diff = eDifficulty;
            this._OwnSide = eOwnSide;
            this._FEN = strFEN;
            this._MoveList = strMoveList;
        }

        public void SaveToFile(string path)
        {
            CreateNewSaveFile(path);
            DataTable tbl = clsXMLProcess.GetTable(path);
            DataRow r = tbl.Rows[0];
            r["GameMode"] = (int)this._GameMode;
            r["GameDifficulty"] = (int)this._Diff;
            r["TimeLimit"] = this._Limit;
            r["TimeBonus"] = this._Bonus;
            r["mRemain1"] = this._mRemain1;
            r["sRemain1"] = this._sRemain1;
            r["mRemain2"] = this._mRemain2;
            r["sRemain2"] = this._sRemain2;
            r["OwnSide"] = (int)this._OwnSide;
            r["FEN"] = this._FEN;
            r["MoveList"] = this._MoveList.Trim();

            tbl.WriteXml(path);

        }

        private  void CreateNewSaveFile(string path)
        {
            XmlDocument doc = new XmlDocument();
            //Khai Bao Tieu De File XML
            XmlDeclaration xmlDec = doc.CreateXmlDeclaration("1.0", "utf-8", "");
            //Khai Bao Nut Goc
            XmlNode root = doc.CreateElement("SaveFile");
            //Khai Bao Nut Con            
            XmlNode xGameMode = doc.CreateElement("GameMode");
            XmlNode xGameDifficulty = doc.CreateElement("GameDifficulty");
            XmlNode xTimeLimit= doc.CreateElement("TimeLimit");
            XmlNode xTimeBonus = doc.CreateElement("TimeBonus");
            XmlNode xmRemain1 = doc.CreateElement("mRemain1");
            XmlNode xsRemain1 = doc.CreateElement("sRemain1");
            XmlNode xmRemain2 = doc.CreateElement("mRemain2");
            XmlNode xsRemain2 = doc.CreateElement("sRemain2");
            XmlNode xOwnSide = doc.CreateElement("OwnSide");
            XmlNode xFEN = doc.CreateElement("FEN");
            XmlNode xMoveList = doc.CreateElement("MoveList");

            //add node con vao node root
            root.AppendChild(xGameMode );
            root.AppendChild(xGameDifficulty);
            root.AppendChild(xTimeLimit);
            root.AppendChild(xTimeBonus );
            root.AppendChild(xmRemain1 );
            root.AppendChild(xsRemain1);
            root.AppendChild(xmRemain2);
            root.AppendChild(xsRemain2);
            root.AppendChild(xOwnSide );
            root.AppendChild(xFEN );
            root.AppendChild(xMoveList);

            //add declaration vao document
            doc.AppendChild(xmlDec);
            //add root vao document
            doc.AppendChild(root);
            //save
            doc.Save(path);
        }

	
	
	
	
	
	
	
	

    }
}
