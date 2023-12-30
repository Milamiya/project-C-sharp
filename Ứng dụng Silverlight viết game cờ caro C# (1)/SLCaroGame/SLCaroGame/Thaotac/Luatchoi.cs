using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SLCaroGame.Thaotac
{
    public class Luatchoi
    {
        public static bool Exit(int x, int y, int[,] board)
        {
            if (board[x, y] != -1)
            {
                return true;
            }
            return false;
        }
        //kiem tra theo chieu doc
        public static int X1(int x, int y, int[,] board)
        {
            int flag = 0;
            int count = 1;
            //lui xuong phia duoi
            int i = x + 1;
            while (i < 15)
            {
                if (board[x, y] == board[i, y])
                {
                    count++;
                    i++;
                }
                else break;
            }
            if (i == 15)
            {
                flag++;
            }
            else
                if (board[i, y] != -1)//khong co gia tri
                {
                    flag++;//tang gia tri cua co
                }
            //theo chieu doc tien len tren
            i = x - 1;
            while (i > 0)
            {
                if (board[x, y] == board[i, y])
                {
                    count++;
                    i--;
                }
                else break;
            }
            if (i == -1)
            {
                flag++;
            }
            else
            {
                if (board[i, y] != -1)
                {
                    flag++;
                }
            }
            if (flag == 2)
            {
                return -count;
            }
            if (flag == 1 && count == 3) return -count;
            return count;
        }
        //kiem tra theo chieu ngang
        public static int X2(int x, int y, int[,] board)
        {
            int flag = 0;
            int count = 1;
            //theo chieu ngang tien sang phai
            int i = y + 1;
            while (i < 15)
            {
                if (board[x, i] == board[x, y])
                {
                    count++;
                    i++;
                }
                else break;
            }
            if (i == 15)
            {
                flag++;
            }
            else
                if (board[x, i] != -1)
                {
                    flag++;
                }
            //theo chieu ngang lui sang trai
            i = y - 1;
            while (i > 0)
            {
                if (board[x, i] == board[x, y])
                {
                    count++;
                    i--;
                }
                else break;
            }
            if (i == -1)
            {
                flag++;
            }
            else
            {
                if (board[x, y] != -1)
                {
                    flag++;
                }
            }
            if (flag == 2)
            {
                return -count;
            }
            if (flag == 1 && count == 3)
            {
                return -count;
            }
            return count;
        }
        //duong cheo chinh
        public static int X3(int x, int y, int[,] board)
        {
            int flag = 0;
            int count = 1;
            //kiem tra nua tren duong cheo chinh(tren ben trai)
            int i = x - 1;
            int j = y - 1;
            while (i > 0 && j > 0)
            {
                if (board[x, y] == board[i, j])
                {
                    count++;
                    i--;
                    j--;
                }
                else break;
            }
            if (i == -1 || j == -1)
            {
                flag++;
            }
            else
            {
                if (board[i, j] != -1)
                {
                    flag++;
                }
            }
            //kiem tra nua duoi duong cheo chinh
            i = x + 1;
            j = y + 1;
            while (i < 15 && j < 15)
            {
                if (board[x, y] == board[i, j])
                {
                    count++;
                    i++;
                    j++;
                }
                else break;
            }
            if (i == 15 || j == 15)
            {
                flag++;
            }
            else
            {
                if (board[x, y] != -1)
                {
                    flag++;
                }
            }
            if (flag == 2)
            {
                return -count;
            }
            if (flag == 1 && count == 3)
            {
                return -count;
            }
            return count;
        }
        //duong cheo phu
        public static int X4(int x, int y, int[,] board)
        {
            int flag = 0;
            int count = 1;
            //nua tren duong cheo phu(ben trai)
            int i = x - 1;
            int j = y + 1;
            while (i > 0 && j < 15)
            {
                if (board[i, j] == board[x, y])
                {
                    count++;
                    i--;
                    j++;
                }
                else break;
            }
            if (i == -1 || j == 15)
            {
                flag++;
            }
            else
            {
                if (board[i, j] != -1)
                {
                    flag++;
                }
            }
            //kiem tra nua duoi duong cheo phu(phia duoi ben trai)
            i = x + 1;
            j = y - 1;
            while (i < 15 && j >= 0)
            {
                if (board[i, j] == board[x, y])
                {
                    count++;
                    i++;
                    j--;
                }
                else break;
            }
            if (i == 15 || j == -1)
                flag++;
            else
                if (board[i, y] != -1)
                {
                    flag++;
                }
            if (flag == 2) return -count;
            if (flag == 1 && count == 3) return -count;
            return count;
        }
        public static bool Fails(int[] move, int type)
        {
            if (type == 0)
            {
                int count = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (move[i] == 3)
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    return true;
                }

            }
            return false;
        }
    
    }
}
