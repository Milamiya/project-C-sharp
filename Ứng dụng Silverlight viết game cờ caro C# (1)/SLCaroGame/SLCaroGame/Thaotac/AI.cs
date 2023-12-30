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
    public class AI
    {
        private static AI _instance;
        public static AI GetInstance()
        {
            if (_instance == null)
                _instance = new AI(true);
            return _instance;
        }

        private bool mifis;

        public int X { get; set; }

        public int Y { get; set; }

        public AI(bool ifis)
        {
            mifis = ifis;
        }

        public void Danh(int[,] banco)
        {
            int[,] q = new int[Khaibaobien.dodai, Khaibaobien.dodai];



            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (banco[i, j] != -1)
                    {
                        q[i, j] = -1;
                    }
                    else
                    {
                        q[i, j] = FindQz(i, j, banco);
                    }
                }
            }
            Gangiatrilonnhat(q);
        }

        public void Gangiatrilonnhat(int[,] q)
        {
            int max = 0;
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (q[i, j] > max)
                    {
                        X = i;
                        Y = j;
                        max = q[i, j];
                    }
                }
            }
        }

        public int FindQz(int x, int y, int[,] banco)
        {
            int qz = 0;
            const int w1 = 10000000;
            const int w2 = 50000;
            const int w3 = 10000;
            const int w4 = 5000;
            const int w5 = 1000;
            const int w6 = 500;
            const int w7 = 100;
            const int w8 = 50;
            const int w9 = -100000000;
            var move = new int[4];

            banco[x, y] = mifis ? 0 : 1;

            move[0] = Luatchoi.X1(x, y, banco);
            move[1] = Luatchoi.X2(x, y, banco);
            move[2] = Luatchoi.X3(x, y, banco);
            move[3] = Luatchoi.X4(x, y, banco);
            if (x == 7 && y == 7)
            {
                qz += 1;
            }

            for (int i = 0; i < 4; i++)
            {
                if (Trituyetdoi(move[i]) == 5)
                {
                    qz += w1;
                }
                else if (move[i] == 4)
                {
                    qz += w3;
                }
                else if (move[i] == 3)
                {
                    qz += w5;
                }
                else if (move[i] == 2)
                {
                    qz += w7;
                }

                if (mifis)
                {
                    if (Luatchoi.Fails(move, banco[x, y]))
                    {
                        qz += w9;
                    }
                }
            }

            banco[x, y] = mifis ? 1 : 0;

            move[0] = Luatchoi.X1(x, y, banco);
            move[1] = Luatchoi.X2(x, y, banco);
            move[2] = Luatchoi.X3(x, y, banco);
            move[3] = Luatchoi.X4(x, y, banco);

            for (int i = 0; i < 4; i++)
            {
                if (Trituyetdoi(move[i]) == 5)
                {
                    qz += w2;
                }
                else if (move[i] == 4)
                {
                    qz += w4;
                }
                else if (move[i] == 3)
                {
                    qz += w6;
                }
                else if (move[i] == 2)
                {
                    qz += w8;
                }
            }
            banco[x, y] = -1;
            return qz;
        }

        public int Trituyetdoi(int x)
        {
            if (x < 0)
            {
                return -x;
            }
            return x;
        }
    }
}
