using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Collections;
namespace Chess_Usercontrol
{
    public static class clsBishop
    {

        static int Side;
        static ArrayList arrMove;

        private static int[,] BishopTable = new int[,]
		{
          //9  8   7   6   5   4   3   2   1  0
           {0,   0,  0,  0,  0,  0,  0,  0,  0,   0}, //0

           {0,  -20,-10,-10,-10,-10,-10,-10,-20  ,0},
           {0,  -10,  0,  0,  0,  0,  0,  0,-10  ,0},
           {0,  -10,  0,  5, 10, 10,  5,  0,-10  ,0},
           {0,  -10,  5,  5, 10, 10,  5,  5,-10  ,0},
           {0,  -10,  0, 10, 10, 10, 10,  0,-10  ,0},
           {0,  -10, 10, 10, 10, 10, 10, 10,-10  ,0},            
           {0,  -10,  5,  0,  0,  0,  0,  5,-10  ,0},
           {0,  -20,-10,-40,-10,-10,-40,-10,-20  ,0},

           {0,   0,  0,  0,  0,  0,  0,  0,  0,   0}  //9
		};
        public static int GetPositionValue(Point pos, ChessSide eSide)
        {
            if (eSide == ChessSide.Black)
            {
                return BishopTable [pos.Y, pos.X];
            }
            else
            {
                return BishopTable[9 - pos.Y, 9 - pos.X];
            }
        }
        public static ArrayList FindAllPossibleMove(int[,] State, Point pos)
        {

            arrMove = new ArrayList();

            Side = State[pos.X, pos.Y] % 10;//Chẵn(0) là quân trắng, lẻ(1) là quân đen

            chessloop(State, pos, 1, 1);
            chessloop(State, pos, 1, -1);
            chessloop(State, pos, -1, -1);
            chessloop(State, pos, -1, 1);

            return arrMove;
        }


        static void chessloop(int[,] State, Point pos, int indexx, int indexy)
        {
            int stop = 0;
            int x = pos.X;
            int y = pos.Y;
            while (stop == 0)
            {
                x += indexx;
                y += indexy;
                
                int state = State[x, y];
                if (state == 0)
                {
                    arrMove.Add(new Point(x, y));
                }
                else if (state == -1)
                {
                    stop = 1;
                }
                else
                {
                    if (state % 10 != Side)
                    {
                        arrMove.Add(new Point(x, y));
                    }
                    stop = 1;
                }

            }
        }

    }
}
