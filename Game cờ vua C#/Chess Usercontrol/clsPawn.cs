using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;

namespace Chess_Usercontrol
{
    public static class clsPawn
    {
        //***Hàm trả về tất cả các nước đi có thể của 1 quân tốt, kể cả nước ăn quân***
        //EnPassant: Bắt Tốt Qua Đường
        private static int[,] PawnTable = new int[,]
		{
          //9  8   7   6   5   4   3   2   1  0
           {0, 0,  0,  0,  0,  0,  0,  0,  0, 0}, //0
           {0, 0,  0,  0,  0,  0,  0,  0,  0, 0}, //1
           {0, 50, 50, 50, 50, 50, 50, 50, 50, 0},//2
           {0, 10, 10, 20, 30, 30, 20, 10, 10, 0},//3
           {0, 5,  5, 10, 27, 27, 10,  5,  5, 0}, //4
           {0,-5, -5,-10, 25, 25, -5, -5,  0, 0}, //5
           {0, 5, -5,-10,  0,  0,-10, -5,  5, 0}, //6
           {0, 5, 10, 10,-25,-25, 10, 10,  5, 0}, //7
           {0, 0,  0,  0,  0,  0,  0,  0,  0, 0}, //8
           {0, 0,  0,  0,  0,  0,  0,  0,  0, 0}  //9
		};
        public static int GetPositionValue(Point pos, ChessSide eSide)
        {
            int value = 0;
            if (eSide == ChessSide.Black)
            {

                value = PawnTable[pos.Y, pos.X];
                //Tốt cánh xe bị trừ 15% giá trị
                if (pos.X == 8 || pos.X == 1)
                    value -= 15;
            }
            else
            {

                value = PawnTable[9 - pos.Y, 9 - pos.X];
                if (pos.X == 8 || pos.X == 1)
                    value -= 15;
            }
            return value;
        }


        public static ArrayList FindAllPossibleMove(int[,] State, Point pos)//, bool EnPassant)
        {
            //Từ vị trí ban đầu quân tốt có thể di chuyển về phía trước 1 hoặc 2 ô các vị trí còn lại : 1 ô
            //Nước di chuyển 2 ô có thể kích hoạt trạng thái "Bắt Tốt Qua Đường(Enpassant)"
            //Trạng thái Enpassant cỉ có hiệu lực trong 1 Nước cờ
            //(nếu đối phương ko ăn quân trong lượt đó thì trạng thái Enpassant sẽ mất hiệu lực)
            ArrayList arrMove = new ArrayList();
            /*
             * Nếu ô phía trước không bị cản thì có thể di chuyển
             */
            int Side = State[pos.X, pos.Y] % 10;//Chẵn(2) là quân trắng, lẻ(1) là quân đen

            if (Side == 2)//Quân Trắng
            {
                if (State[pos.X, pos.Y + 1] == 0)
                {
                    arrMove.Add(new Point(pos.X, pos.Y + 1));

                    if (pos.Y == 2 && State[pos.X, pos.Y + 2] == 0)//Vi tri ban dau
                        arrMove.Add(new Point(pos.X, pos.Y + 2));
                    //Phong Cấp
                    if (pos.Y == 7)
                    {
                        arrMove.Add(new Point(pos.X, pos.Y + 1));
                        arrMove.Add(new Point(pos.X, pos.Y + 1));
                        arrMove.Add(new Point(pos.X, pos.Y + 1));
                    }
                }
                //Ăn quân
                //Nếu đường chéo ở 2 ô trước mặt là quân đen
                if (State[pos.X - 1, pos.Y + 1] % 10 == 1)
                {
                    arrMove.Add(new Point(pos.X - 1, pos.Y + 1));
                    if (pos.Y == 7)
                    {
                        arrMove.Add(new Point(pos.X - 1, pos.Y + 1));
                        arrMove.Add(new Point(pos.X - 1, pos.Y + 1));
                        arrMove.Add(new Point(pos.X - 1, pos.Y + 1));
                    }
                }
                if (State[pos.X + 1, pos.Y + 1] % 10 == 1)
                {
                    arrMove.Add(new Point(pos.X + 1, pos.Y + 1));
                    if (pos.Y == 7)
                    {
                        arrMove.Add(new Point(pos.X + 1, pos.Y + 1));
                        arrMove.Add(new Point(pos.X + 1, pos.Y + 1));
                        arrMove.Add(new Point(pos.X + 1, pos.Y + 1));
                    }
                }


            }
            else if (Side == 1)
            {
                if (State[pos.X, pos.Y - 1] == 0)
                {
                    arrMove.Add(new Point(pos.X, pos.Y - 1));

                    if (pos.Y == 7 && State[pos.X, pos.Y - 2] == 0)//Vi tri ban dau
                        arrMove.Add(new Point(pos.X, pos.Y - 2));

                    if (pos.Y == 2)
                    {
                        arrMove.Add(new Point(pos.X, pos.Y - 1));
                        arrMove.Add(new Point(pos.X, pos.Y - 1));
                        arrMove.Add(new Point(pos.X, pos.Y - 1));
                    }

                }
                //Ăn quân
                //Nếu đường chéo ở 2 ô trước mặt là quân Trắng
                if (State[pos.X - 1, pos.Y - 1] % 10 == 2)
                {
                    arrMove.Add(new Point(pos.X - 1, pos.Y - 1));
                    if (pos.Y == 2)
                    {
                        arrMove.Add(new Point(pos.X - 1, pos.Y - 1));
                        arrMove.Add(new Point(pos.X - 1, pos.Y - 1));
                        arrMove.Add(new Point(pos.X - 1, pos.Y - 1));
                    }
                }

                if (State[pos.X + 1, pos.Y - 1] % 10 == 2)
                {
                    arrMove.Add(new Point(pos.X + 1, pos.Y - 1));
                    if (pos.Y == 2)
                    {
                        arrMove.Add(new Point(pos.X + 1, pos.Y - 1));
                        arrMove.Add(new Point(pos.X + 1, pos.Y - 1));
                        arrMove.Add(new Point(pos.X + 1, pos.Y - 1));
                    }
                }


            }

            Point pt = UcChessBoard._EnPassantPoint;
            if (pt != new Point())//Nếu có tọa đọ bắt tốt
            {
                if (pos.Y == 4 && Side == 1)//Nếu là quân tốt đen
                {
                    if (new Point(pos.X - 1, 3) == pt)//Đường chéo phải
                    {
                        arrMove.Add(UcChessBoard._EnPassantPoint);
                    }

                    if (new Point(pos.X + 1, 3) == pt)//Đường chéo trái
                    {
                        arrMove.Add(UcChessBoard._EnPassantPoint);
                    }
                }

                if (pos.Y == 5 && Side == 2)
                {
                    if (new Point(pos.X - 1, 6) == pt)
                    {
                        arrMove.Add(UcChessBoard._EnPassantPoint);
                    }

                    if (new Point(pos.X + 1, 6) == pt)
                    {
                        arrMove.Add(UcChessBoard._EnPassantPoint);
                    }
                }
            }
            return arrMove;

        }
        public static Point GetEnPassantPoint(int[,] State, Point pos)
        {
            if (pos.Y == 4)
                return new Point(pos.X, pos.Y - 1);
            if (pos.Y == 5)
                return new Point(pos.X, pos.Y + 1);
            return new Point();
        }

        //Nếu chơi với máy hì máy sẽ chon quân Hậu và không hieern thị form chọn
        //Nếu đóng Form thì mặc định sẽ chọn quân hậu
        public static bool Promotion(UcChessPiece UcPawn, ChessPieceType PromoteTo)
        {

            if ((UcPawn.PositionY == 8) || (UcPawn.PositionY == 1))
            {

                Bitmap queen = clsImageProcess.GetChessPieceBitMap(UcPawn.Side, ChessPieceType.Queen, UcPawn.Style);
                Bitmap root = clsImageProcess.GetChessPieceBitMap(UcPawn.Side, ChessPieceType.Rook, UcPawn.Style);
                Bitmap knight = clsImageProcess.GetChessPieceBitMap(UcPawn.Side, ChessPieceType.Knight, UcPawn.Style);
                Bitmap bishop = clsImageProcess.GetChessPieceBitMap(UcPawn.Side, ChessPieceType.Bishop, UcPawn.Style);

                if (PromoteTo == ChessPieceType.Null)
                {
                    Form f = new frmPromotion(queen, root, knight, bishop);
                    f.ShowDialog();
                    UcPawn.Type = frmPromotion.Type;
                }
                else
                {
                    UcPawn.Type = PromoteTo;
                }
                Bitmap image = clsImageProcess.GetChessPieceBitMap(UcPawn.Side, UcPawn.Type, UcPawn.Style);
                UcPawn.Image = image;
                return true;
            }
            return false;
        }

    }
}
