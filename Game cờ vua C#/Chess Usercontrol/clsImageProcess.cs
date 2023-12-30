using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace Chess_Usercontrol
{
    public static class clsImageProcess
    {
        /*
         * Hàm này trả về tên của hình ảnh quân cờ chứa trong resource
         * VD: Muon lay quan Mã màu Đen Style Classic
         * Bitmap img=GetChessPieceBitMap(ChessPieceSide.Black,ChessPieceType.Knight,ChessPieceStyle.Classic);
         * Hàm này lấy hình ảnh trong Resource có tên là "Black_K_1";
         */
        public static Bitmap GetChessPieceBitMap(ChessSide Side, ChessPieceType Type, ChessPieceStyle Style)
        {
            string strImg = "";

            switch (Side)
            {
                case ChessSide.Black: strImg += "Black_";
                    break;
                case ChessSide.White: strImg += "White_";
                    break;
            }

            switch (Type)
            {
                case ChessPieceType.Pawn: strImg += "P_";
                    break;
                case ChessPieceType.Bishop: strImg += "B_";
                    break;
                case ChessPieceType.Knight: strImg += "N_";
                    break;
                case ChessPieceType.Rook: strImg += "R_";
                    break;
                case ChessPieceType.Queen: strImg += "Q_";
                    break;
                case ChessPieceType.King: strImg += "K_";
                    break;
            }

            strImg += (int)Style;

            Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject(strImg);

            return img;
        }

        public static Bitmap GetChessBoardBitMap(ChessSide Side, ChessBoardStyle  Style)
        {
            string strImg = "";

            switch (Side)
            {
                case ChessSide.Black: strImg += "Black_C_";
                    break;
                case ChessSide.White: strImg += "White_C_";
                    break;
            }           

            strImg += (int)Style;

            Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject(strImg);

            return img;
        }
        public static Bitmap GetChessBoardBitMap(ChessSide Side, ChessBoardStyle Style, string Highlight)
        {
            string strImg = "";

            switch (Side)
            {
                case ChessSide.Black: strImg += "Black_C_";
                    break;
                case ChessSide.White: strImg += "White_C_";
                    break;
            }

            strImg += (int)Style;

            strImg += "_" + Highlight;


            Bitmap img = (Bitmap)Properties.Resources.ResourceManager.GetObject(strImg);

            return img;
        }
        
    }
}
