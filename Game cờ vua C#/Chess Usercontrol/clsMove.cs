using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing ;
namespace Chess_Usercontrol
{
    public class clsMove
    {
        private Point _CurPos;
        private Point _NewPos;
        private int _Score;
        private ChessPieceType _PromoteTo;
        public clsMove()
        {
            this._CurPos = new Point ();
            this._NewPos = new Point ();
            this.Score = 0;
            this.PromoteTo = ChessPieceType.Null;
        }
        public clsMove(Point c, Point n)
        {
            this._CurPos = c;
            this._NewPos = n;
            this.Score = 0;
            this.PromoteTo = ChessPieceType.Null;
        }
        public clsMove(string strMove)
        {
            strMove = strMove.ToUpper();
            string strCur = "", strNew = "", strPromotion = "";

            strCur = strMove.Substring(0, 2);
            strNew = strMove.Substring(2, 2);
            if (strMove.Length == 6)
            {
                strPromotion = strMove.Substring(5, 1);
            }
            int CurX = strCur[0] - 64;
            int NewX = strNew[0] - 64;

            this._CurPos = new Point(CurX, strCur[1] - 48);
            this._NewPos = new Point(NewX, strNew[1] - 48);

            if (strPromotion == "")
                this._PromoteTo = ChessPieceType.Null;
            else if (strPromotion == "Q")
                this._PromoteTo  = ChessPieceType.Queen;
            else if (strPromotion == "B")
                this._PromoteTo = ChessPieceType.Bishop;
            else if (strPromotion == "N")
                this._PromoteTo = ChessPieceType.Knight;
            else if (strPromotion == "R")
                this._PromoteTo = ChessPieceType.Rook;
        }
        public Point CurPos
        {
            get { return this._CurPos; }
            set { this._CurPos = value; }
        }
        public Point NewPos
        {
            get { return this._NewPos; }
            set { this._NewPos = value; }
        }

        public ChessPieceType PromoteTo
        {
            get{return this._PromoteTo ;}
            set{this._PromoteTo =value; }
        }

        public  int Score
        {
            get { return this._Score; }
            set { this._Score = value; }
        }

        

        public override string  ToString()
        {
            string strMove = "";
            string strCur = "";
            string strNew = "";
            string strPromotion = "";

            strCur += Convert.ToChar(this._CurPos.X + 64).ToString() + this._CurPos.Y.ToString();
            strNew += Convert.ToChar(this._NewPos.X + 64).ToString() + this._NewPos.Y.ToString();

           if (this._PromoteTo == ChessPieceType.Queen)
                strPromotion = "=Q";
            else if (this._PromoteTo == ChessPieceType.Knight)
                strPromotion = "=N";
            else if (this._PromoteTo == ChessPieceType.Rook )
                strPromotion = "=R";
            else if (this._PromoteTo == ChessPieceType.Bishop)
                strPromotion = "=B";

            strMove = strCur + strNew;
            if (strPromotion != "")
                strMove +=strPromotion;
            return strMove;
        }
    }
}
