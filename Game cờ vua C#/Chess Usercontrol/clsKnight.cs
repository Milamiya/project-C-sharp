using System;
using System.Collections.Generic;
using System.Collections;
using System.Drawing;
using System.Text;

namespace Chess_Usercontrol
{
    public static class clsKnight
    {
        private static int[,] KnightTable = new int[,]
		{
          //9  8   7   6   5   4   3   2   1  0
           {0, 0,  0,  0,  0,  0,  0,  0,  0, 0}, //0
           {0,-50,-40,-30,-30,-30,-30,-40,-50,0},
           {0,-40,-20,  0,  0,  0,  0,-20,-40,0},
           {0,-30,  0, 10, 15, 15, 10,  0,-30,0},
           {0,-30,  5, 15, 20, 20, 15,  5,-30,0},
           {0,-30,  0, 15, 20, 20, 15,  0,-30,0},
           {0,-30,  5, 10, 15, 15, 10,  5,-30,0},
           {0,-40,-20,  0,  5,  5,  0,-20,-40,0},
           {0,-50,-40,-20,-30,-30,-20,-40,-50,0},
           {0, 0,  0,  0,  0,  0,  0,  0,  0, 0}  //9
		};

        public static int GetPositionValue(Point pos, ChessSide eSide)
        {
            if (eSide == ChessSide.Black)
            {
                return KnightTable[pos.Y, pos.X];
            }
            else
            {
                return KnightTable[9 - pos.Y, 9 - pos.X];
            }
        }

        public static ArrayList FindAllPossibleMove(int[,] State, Point pos)
        {
            ArrayList arrMove = new ArrayList();
            int Side = State[pos.X, pos.Y] %10;//Chẵn(2) là quân trắng, lẻ(1) là quân đen
            /*
             *       1 | 2
             *     3   |   4
             *     ----N----
             *     5   |   6
             *       7 | 8
             * Điều Kiện:
             * Vị Trí 1: X>=2 && Y<=6  (Y+2,X-1)
             * Vị Trí 2: X<=7 && Y<=6 (Y+2,X+1)
             * Vị Trí 3: X>=3 && Y<=7 (Y+1,X-2)
             * Vị Trí 4: X<=6 && Y<=7  (Y+1,X+2)
             * Vị Trí 5: X>=3 && Y>=2   (Y-1,X-2)
             * Vị Trí 6: X<=6 && Y>=2  (Y-1,X+2)
             * Vị Trí 7: X>=2 && Y>=3   (Y-2,X-1)
             * Vị Trí 8: X<=7 && Y>=3  (Y-2,X+1)
             */


            //Vị Trí 1
            if (pos.X >= 2 && pos.Y <= 6)
            {
                if (State[pos.X - 1, pos.Y + 2] % 10 != Side || State[pos.X - 1, pos.Y + 2] == 0)
                    arrMove.Add(new Point(pos.X - 1, pos.Y + 2));
            }
            //Vị Trí 2
            if (pos.X <= 7 && pos.Y <= 6)
            {
                if (State[pos.X + 1, pos.Y + 2] % 10 != Side || State[pos.X + 1, pos.Y + 2] == 0)
                    arrMove.Add(new Point(pos.X + 1, pos.Y + 2));
            }
            //Vị Trí 3
            if (pos.X >= 3 && pos.Y <= 7)
            {
                if (State[pos.X - 2, pos.Y + 1] % 10 != Side || State[pos.X - 2, pos.Y + 1] == 0)
                    arrMove.Add(new Point(pos.X - 2, pos.Y + 1));
            }
            //Vị Trí 4
            if (pos.X <= 6 && pos.Y <= 7)
            {
                if (State[pos.X + 2, pos.Y + 1] % 10 != Side || State[pos.X + 2, pos.Y + 1] == 0)
                    arrMove.Add(new Point(pos.X + 2, pos.Y + 1));
            }
            //Vị Trí 5
            if (pos.X >= 3 && pos.Y >= 2)
            {
                if (State[pos.X - 2, pos.Y - 1] % 10 != Side || State[pos.X - 2, pos.Y - 1] == 0)
                    arrMove.Add(new Point(pos.X - 2, pos.Y - 1));
            }
            //Vị Trí 6
            if (pos.X <= 6 && pos.Y >= 2)
            {
                if (State[pos.X + 2, pos.Y - 1] % 10 != Side || State[pos.X + 2, pos.Y - 1] == 0)
                    arrMove.Add(new Point(pos.X + 2, pos.Y - 1));
            }
            //Vị Trí 7
            if (pos.X >= 2 && pos.Y >= 3)
            {
                if (State[pos.X - 1, pos.Y - 2] % 10 != Side || State[pos.X - 1, pos.Y - 2] == 0)
                    arrMove.Add(new Point(pos.X - 1, pos.Y - 2));
            }
            //Vị Trí 8
            if (pos.X <= 7 && pos.Y >= 3)
            {
                if (State[pos.X + 1, pos.Y - 2] % 10 != Side || State[pos.X + 1, pos.Y - 2] == 0)
                    arrMove.Add(new Point(pos.X + 1, pos.Y - 2));
            }
            return arrMove;
        }
    }
}
