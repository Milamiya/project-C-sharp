using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;
namespace Chess_Usercontrol
{
    public static class clsKing
    {
        private static int[,] KingTable = new int[,]
		{
          //9  8   7   6   5   4   3   2   1  0
           {0,   0,  0,  0,  0,  0,  0,  0,  0,   0}, //0

           {0,  -30, -40, -40, -50, -50, -40, -40, -30  ,0},
           {0,  -30, -40, -40, -50, -50, -40, -40, -30  ,0},
           {0,  -30, -40, -40, -50, -50, -40, -40, -30  ,0},
           {0,  -30, -40, -40, -50, -50, -40, -40, -30  ,0},
           {0,  -20, -30, -30, -40, -40, -30, -30, -20  ,0},
           {0,  -10, -20, -20, -20, -20, -20, -20, -10  ,0},
           {0,   20,  20, -5,  -5,  -5,  -5,   20,  20  ,0},
           {0,   20,  30, 10,  0,   0,  10, 30,  20  ,0},
            
           {0,   0,  0,  0,  0,  0,  0,  0,  0,   0}  //9
		};

        private static int[,] KingTableEndGame = new int[,]
		{
          //9  8   7   6   5   4   3   2   1  0
           {0,   0,  0,  0,  0,  0,  0,  0,  0,   0}, //0
           {0,  -50,-40,-30,-20,-20,-30,-40,-50,  0},
           {0,  -30,-20,-10,  0,  0,-10,-20,-30,  0},
           {0,  -30,-10, 20, 30, 30, 20,-10,-30,  0},
           {0,  -30,-10, 30, 40, 40, 30,-10,-30,  0},
           {0,  -30,-10, 30, 40, 40, 30,-10,-30,  0},
           {0,  -30,-10, 20, 30, 30, 20,-10,-30,  0},
           {0,  -30,-30,  0,  0,  0,  0,-30,-30,  0},
           {0,  -50,-30,-30,-30,-30,-30,-30,-50,  0},

           {0,   0,  0,  0,  0,  0,  0,  0,  0,   0}  //9
		};

        public static int GetPositionValue(Point pos, ChessSide eSide, bool IsEndGame)
        {
            if (IsEndGame == false)
            {
                if (eSide == ChessSide.Black)
                {
                    return KingTable[pos.Y, pos.X];
                }
                else
                {
                    return KingTable[9 - pos.Y, 9 - pos.X];
                }
            }
            else
            {
                if (eSide == ChessSide.Black)
                {
                    return KingTableEndGame[pos.Y, pos.X];
                }
                else
                {
                    return KingTableEndGame[9 - pos.Y, 9 - pos.X];
                }
            }
        }



        public static ArrayList FindAllPossibleMove(int[,] State, Point pos)
        {
            ArrayList arrMove = new ArrayList();
            int Side = State[pos.X, pos.Y] % 10;//Chẵn(0) là quân trắng, lẻ(1) là quân đen

            if (State[pos.X + 1, pos.Y] >= 0 && (State[pos.X + 1, pos.Y] == 0 || State[pos.X + 1, pos.Y] % 10 != Side))
                arrMove.Add(new Point(pos.X + 1, pos.Y));//phải

            if (State[pos.X - 1, pos.Y] >= 0 && (State[pos.X - 1, pos.Y] == 0 || State[pos.X - 1, pos.Y] % 10 != Side))
                arrMove.Add(new Point(pos.X - 1, pos.Y));//trái

            if (State[pos.X, pos.Y + 1] >= 0 && (State[pos.X, pos.Y + 1] == 0 || State[pos.X, pos.Y + 1] % 10 != Side))
                arrMove.Add(new Point(pos.X, pos.Y + 1));//trên

            if (State[pos.X, pos.Y - 1] >= 0 && (State[pos.X, pos.Y - 1] == 0 || State[pos.X, pos.Y - 1] % 10 != Side))
                arrMove.Add(new Point(pos.X, pos.Y - 1));//dưới

            if (State[pos.X + 1, pos.Y + 1] >= 0 && (State[pos.X + 1, pos.Y + 1] == 0 || State[pos.X + 1, pos.Y + 1] % 10 != Side))
                arrMove.Add(new Point(pos.X + 1, pos.Y + 1));//trên phải

            if (State[pos.X - 1, pos.Y + 1] >= 0 && (State[pos.X - 1, pos.Y + 1] == 0 || State[pos.X - 1, pos.Y + 1] % 10 != Side))
                arrMove.Add(new Point(pos.X - 1, pos.Y + 1));//trên trái

            if (State[pos.X + 1, pos.Y - 1] >= 0 && (State[pos.X + 1, pos.Y - 1] == 0 || State[pos.X + 1, pos.Y - 1] % 10 != Side))
                arrMove.Add(new Point(pos.X + 1, pos.Y - 1));//dưới phải

            if (State[pos.X - 1, pos.Y - 1] >= 0 && (State[pos.X - 1, pos.Y - 1] == 0 || State[pos.X - 1, pos.Y - 1] % 10 != Side))
                arrMove.Add(new Point(pos.X - 1, pos.Y - 1));//dưới trái


            return arrMove;
        }

        public static void AddCastlingPoint(int[,] State, ChessSide eSide, ArrayList arrMoves)
        {

            if (IsChecked(State, eSide) == false)
            {
                if (eSide == ChessSide.White)
                {
                    if (UcChessBoard.KINGsideCastling == true)//Nhập thành gần
                    {
                        int x = 5;
                        while (State[++x, 1] == 0) ;

                        if (x == 8)//Không có khoảng trống giữa vua và xe
                        {
                            if (IsChecked(State, eSide, new Point(7, 1)) == false && IsChecked(State, eSide, new Point(6, 1)) == false)
                            {
                                arrMoves.Add(new Point(7, 1));
                            }
                        }

                    }
                    if (UcChessBoard.QUEENsideCastling == true)//Nhập thành xa
                    {
                        int x = 5;
                        while (State[--x, 1] == 0) ;

                        if (x == 1)//Không có khoảng trống giữa vua và xe
                        {
                            if (IsChecked(State, eSide, new Point(3, 1)) == false && IsChecked(State, eSide, new Point(4, 1)) == false)
                            {
                                arrMoves.Add(new Point(3, 1));
                            }
                        }

                    }
                }
                else
                {
                    if (UcChessBoard.kingsideCastling == true)//Nhập thành gần
                    {
                        int x = 5;
                        while (State[++x, 8] == 0) ;

                        if (x == 8)//Không có khoảng trống giữa vua và xe
                        {
                            if (IsChecked(State, eSide, new Point(7, 8)) == false && IsChecked(State, eSide, new Point(6, 8)) == false)
                            {
                                arrMoves.Add(new Point(7, 8));
                            }
                        }

                    }
                    if (UcChessBoard.queensideCastling == true)//Nhập thành xa
                    {
                        int x = 5;
                        while (State[--x, 8] == 0) ;

                        if (x == 1)//Không có khoảng trống giữa vua và xe
                        {
                            if (IsChecked(State, eSide, new Point(3, 8)) == false && IsChecked(State, eSide, new Point(4, 8)) == false)
                            {
                                arrMoves.Add(new Point(3, 8));
                            }
                        }
                    }
                }
            }
        }

        //Hàm kiểm tra quân vua của 1 phe có đang bị chiếu hay không
        public static bool IsChecked(int[,] arrState, ChessSide eSide)
        {

            int[,] State = new int[10, 10];
            Array.Copy(arrState, State, arrState.Length);//copy mảng

            Point pKingPos = FindKingPosition(State, eSide);//Tìm vị trí quân vua đang kiểm tra

            int intSide = (int)eSide;//Phe của quân đang kiểm tra           

            for (int y = 1; y <= 8; y++)
                for (int x = 1; x <= 8; x++)
                {

                    if (State[x, y] > 0 && State[x, y] % 10 != intSide)//Nếu là quân khác phe
                    {

                        ArrayList arrMove = new ArrayList();
                        ChessPieceType eType = (ChessPieceType)(State[x, y] / 10);

                        if (eType == ChessPieceType.Bishop)
                        {
                            arrMove = clsBishop.FindAllPossibleMove(State, new Point(x, y));
                        }
                        if (eType == ChessPieceType.King)
                        {
                            arrMove = clsKing.FindAllPossibleMove(State, new Point(x, y));
                        }
                        if (eType == ChessPieceType.Knight)
                        {
                            arrMove = clsKnight.FindAllPossibleMove(State, new Point(x, y));
                        }
                        if (eType == ChessPieceType.Pawn)
                        {
                            arrMove = clsPawn.FindAllPossibleMove(State, new Point(x, y));
                        }
                        if (eType == ChessPieceType.Queen)
                        {
                            arrMove = clsQueen.FindAllPossibleMove(State, new Point(x, y));
                        }
                        if (eType == ChessPieceType.Rook)
                        {
                            arrMove = clsRook.FindAllPossibleMove(State, new Point(x, y));
                        }
                        foreach (Point p in arrMove)
                        {
                            if (p == pKingPos)
                                return true;
                        }
                    }
                }
            return false;

        }
        //Hàm Kiểm Tra 1 ô có bị khống chế hay không
        public static bool IsChecked(int[,] arrState, ChessSide eSide, Point pos)
        {

            int[,] State = new int[10, 10];
            Array.Copy(arrState, State, arrState.Length);//copy mảng            
            int intSide = (int)eSide;//Phe của quân đang kiểm tra           

            for (int y = 1; y <= 8; y++)
                for (int x = 1; x <= 8; x++)
                {

                    if (State[x, y] > 0 && State[x, y] % 10 != intSide)//Nếu là quân khác phe
                    {

                        ArrayList arrMove = new ArrayList();
                        ChessPieceType eType = (ChessPieceType)(State[x, y] / 10);

                        if (eType == ChessPieceType.Bishop)
                        {
                            arrMove = clsBishop.FindAllPossibleMove(State, new Point(x, y));
                        }
                        if (eType == ChessPieceType.King)
                        {
                            arrMove = clsKing.FindAllPossibleMove(State, new Point(x, y));
                        }
                        if (eType == ChessPieceType.Knight)
                        {
                            arrMove = clsKnight.FindAllPossibleMove(State, new Point(x, y));
                        }
                        if (eType == ChessPieceType.Pawn)
                        {
                            arrMove = clsPawn.FindAllPossibleMove(State, new Point(x, y));
                        }
                        if (eType == ChessPieceType.Queen)
                        {
                            arrMove = clsQueen.FindAllPossibleMove(State, new Point(x, y));
                        }
                        if (eType == ChessPieceType.Rook)
                        {
                            arrMove = clsRook.FindAllPossibleMove(State, new Point(x, y));
                        }
                        foreach (Point p in arrMove)
                        {
                            if (p == pos)
                                return true;
                        }
                    }
                }
            return false;
        }

        public static Point FindKingPosition(int[,] arrState, ChessSide eSide)
        {
            int intKing = 60 + (int)eSide;
            for (int y = 1; y <= 8; y++)
                for (int x = 1; x <= 8; x++)
                {
                    if (arrState[x, y] == intKing)
                    {
                        return new Point(x, y);
                    }
                }
            return new Point();
        }      

    }
}
