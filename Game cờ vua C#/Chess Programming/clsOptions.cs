using System;
using System.Collections.Generic;
using System.Text;
using Chess_Usercontrol;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace Chess_Programming
{
    public class clsOptions
    {
        private int _CellSize;
        private int _PieceSize;
        private bool _PlaySound;
        private ChessPieceStyle _PieceStyle;
        private ChessBoardStyle _BoardStyle;
        private string path=Application .StartupPath +"\\Config.xml";
        public clsOptions()
        {
            this._CellSize = 80;
            this._PieceSize = 64;
            this._PieceStyle = ChessPieceStyle.Classic;
            this._BoardStyle = ChessBoardStyle.Metal;
            this.PlaySound = true;
            
            LoadOptions();
        }

        public void LoadOptions()
        {
            if (File.Exists(path) == false)
            {
                clsXMLProcess.CreateNewOptions(path);
                SaveOptions();
            }
            else
            {
                DataTable tbl = clsXMLProcess.GetTable(path);
                DataRow r = tbl.Rows[0];
                this._CellSize = Convert .ToInt32 ( r["CELLSIZE"]);
                this._PieceSize = Convert .ToInt32 (r["PIECESIZE"]);
                this._BoardStyle = (ChessBoardStyle )Convert .ToInt32 (r["BOARDSTYLE"]);
                this._PieceStyle = (ChessPieceStyle ) Convert .ToInt32 (r["PIECESTYLE"]);
                this._PlaySound =Convert .ToBoolean ( r["PLAYSOUND"]);
            }

        }

        public void SaveOptions()
        {
            DataTable tbl = clsXMLProcess.GetTable(path);
            DataRow r = tbl.Rows[0];
            r["CELLSIZE"] = this._CellSize;
            r["PIECESIZE"] = this._PieceSize;
            r["BOARDSTYLE"] = (int)this._BoardStyle;
            r["PIECESTYLE"] = (int)this._PieceStyle;
            r["PLAYSOUND"] = this._PlaySound;

            tbl.WriteXml(path);
            
        }
        public int CellSize
        {
            get
            {
                return this._CellSize;
            }
            set
            {
                this._CellSize = value;
            }
        }

        public int PieceSize
        {
            get
            {
                return this._PieceSize;
            }
            set
            {
                this._PieceSize = value;
            }
        }

        public ChessBoardStyle  BoardStyle
        {
            get
            {
                return this._BoardStyle;
            }
            set
            {
                this._BoardStyle = value;
            }
        }

        public ChessPieceStyle  PieceStyle
        {
            get
            {
                return this._PieceStyle;
            }
            set
            {
                this._PieceStyle = value;
            }
        }

        public bool PlaySound
        {
            get
            {
                return this._PlaySound;
            }
            set
            {
                this._PlaySound = value;
            }
        }



    }
}
