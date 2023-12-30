using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
namespace UIT_Pokemon
{
    public class Argument
    {
        public int[,] Matrix = new int[18, 10];
        /*
         Matrix[x,y]>=0 ten nhan vat
         Matrix[x,y]<0 o trong
         */
        Form1 form;
        public List<int> LimitPokemon = new List<int>();
        public List<int> AutoRand=new List<int>();
        public int RemainPokemon = 128;
        public int Level = 1;
        public Argument(Form1 form)
        {
            this.form = form;
        }

        #region Clear
        private void Clear()
        {
            AutoRand.Clear();
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 16; x++)
                {
                    //Matrix[x, y] = -1;
                    AutoRand.Add(y * 16 + x);
                }
            }
            for (int y = 0; y < 10; y++)
                for (int x = 0; x < 18; x++)
                {
                    Matrix[x, y] = -1;
                    //CacularMatrix[x, y] = -1;
                }
          
            /* testting
            String test="";
            for(int i=0;i<LimitPokemon.Count;i++)
                test+=" *"+LimitPokemon[i].ToString()+"* ";
            MessageBox.Show(test);
            */
        }
        #endregion

        #region New game
        public void NewGame()
        {
            RemainPokemon = 128;
            Clear();
            LimitPokemon.Clear();
            Level = form.Level;
            for (int i = 0; i < Information.PokemonNumber * 4; i++)
            {
                LimitPokemon.Add(i / 4);
            }
            Random rand_ID = new Random();
            Random rand_Location = new Random();
            // make sure having enough PokemonNumber
            for (int i = 0; i < Information.PokemonNumber; i++)
            {
                int tmp_Location = rand_Location.Next(AutoRand.Count);
                Matrix[AutoRand[tmp_Location] % 16+1, AutoRand[tmp_Location] / 16+1] = i;
                AutoRand.RemoveAt(tmp_Location);
                // find Couple
                tmp_Location = rand_Location.Next(AutoRand.Count);
                Matrix[AutoRand[tmp_Location] % 16+1, AutoRand[tmp_Location] / 16+1] = i;
                AutoRand.RemoveAt(tmp_Location);
            }
            //make sure not too much any pokemon(<=5 couple)
            while (AutoRand.Count > 0)
            {
                int tmp_ID = rand_ID.Next(LimitPokemon.Count);
                
                int tmp_Location = rand_Location.Next(AutoRand.Count);
                Matrix[AutoRand[tmp_Location] % 16+1, AutoRand[tmp_Location] / 16+1] = LimitPokemon[tmp_ID];
                AutoRand.RemoveAt(tmp_Location);
                // find Couple
                tmp_Location = rand_Location.Next(AutoRand.Count);
                Matrix[AutoRand[tmp_Location] % 16+1, AutoRand[tmp_Location] / 16+1] = LimitPokemon[tmp_ID];
                AutoRand.RemoveAt(tmp_Location);
                LimitPokemon.RemoveAt(tmp_ID);
            }
            /* testing
             Matrix[2, 2] =Matrix[3,3]= 0;
            Matrix[3, 2] = Matrix[2, 3] = 1;
            Matrix[4, 4] = 9;
            Matrix[5, 5] = 9;
            RemainPokemon = 6;
             */
        }
        #endregion


        #region Tinh Toan an hop le
        public ArrayList min_way(int[,] a, int X1, int Y1, int X2, int Y2)
        {
            #region dieu chinh cac thuoc tinh
            // X1,Y1 la toa do diem di
            // X2,Y2 la toa do diem den
            X1+=1;
            Y1+=1;
            X2+=1;
            Y2+=1;
            if (X1 == X2 && Y1 == Y2)
                return null;
            List<Point> numone = new List<Point>();
            List<Point> numtwo = new List<Point>();
            int[,] dad = new int[18, 10];
            for(int j=0;j<10;j++)
                for(int i=0;i<18;i++)
                {
                    dad[i,j]=0;
                }
            bool huong1, huong2, huong3, huong4;
            // Diem bat dau tinh
            huong1 = huong2 = huong3 = huong4 = true;
            #endregion


            #region Diem so 1
            for (int i = 1; i < 17; i++)
            {
                #region  Huong 1
                if (huong1 == true)
                {
                    if (X1 - i >= 0)
                    {
                        if (X1 - i == X2 & Y1 == Y2)
                        {
                            return TH1(X1,Y1,X2,Y2);
                        }
                        else
                        {
                            if (a[X1 - i, Y1] < 0)
                            {
                                dad[X1 - i, Y1] = i;
                                numone.Add(new Point(X1 - i, Y1));
                            }
                            else
                                huong1 = false;
                        }
                    }
                    else
                    {
                        huong1 = false;
                    }
                }
                #endregion
                #region Huong 2
                if (huong2 == true)
                {
                    if (X1 + i <= 17)
                    {
                        if (X1 + i == X2 & Y1 == Y2)
                        {
                            return TH1(X1, Y1, X2, Y2);
                        }
                        else
                        {
                            if (a[X1 + i, Y1] < 0)
                            {
                                dad[X1 + i, Y1] = i;
                                numone.Add(new Point(X1 + i, Y1));
                            }
                            else
                                huong2 = false;
                        }
                    }
                    else
                    {
                        huong2 = false;
                    }
                }
                #endregion
                #region huong 3
                if (huong3 == true)
                {
                    if (Y1 - i >= 0)
                    {
                        if (X1 == X2 & Y1 - i == Y2)
                        {
                            return TH1(X1, Y1, X2, Y2);
                        }
                        else
                        {
                            if (a[X1, Y1 - i] < 0)
                            {
                                dad[X1, Y1 - i] = i;
                                numone.Add(new Point(X1, Y1-i));
                            }
                            else
                                huong3 = false;
                        }
                    }
                    else
                    {
                        huong3 = false;
                    }
                }
                #endregion
                #region huong 4
                if (huong4 == true)
                {
                    if (Y1 + i <= 9)
                    {
                        if (X1 == X2 & Y1 + i == Y2)
                        {
                            return TH1(X1, Y1, X2, Y2);
                        }
                        else
                        {
                            if (a[X1, Y1 + i] < 0)
                            {
                                dad[X1, Y1 + i] = i;
                                numone.Add(new Point(X1, Y1+i));
                            }
                            else
                                huong4 = false;
                        }
                    }
                    else
                    {
                        huong4 = false;
                    }
                }
                #endregion
                if (huong1==false &&huong2==false && huong3==false && huong4==false)
                {
                     break;
                }

            }
            #endregion


            #region diem so 2
            huong1 =huong2=huong3=huong4=true;
            for (int i = 1; i < 17; i++)
            {
                #region Huong 1(qua trai)
                if (huong1 == true)
                {
                    if (X2 - i >= 0)
                    {
                        if (dad[X2 - i, Y2] > 0)
                        {
                            return TH2(X1,Y1,X2,Y2,X2-i,Y2);
                        }
                        else
                        {
                            if (a[X2-i, Y2] < 0)
                            {
                                dad[X2-i, Y2] = -1;
                                numtwo.Add(new Point(X2 - i, Y2));
                            }
                            else
                                huong1 = false;
                        }
                    }
                    else
                    {
                        huong1 = false;
                    }
                }
                #endregion

                #region Huong 2 (qua phai)
                if (huong2 == true)
                {
                    if (X2 + i <= 17)
                    {
                        if (dad[X2 + 1, Y2] > 0)
                        {
                            return TH2(X1, Y1, X2, Y2, X2 + i, Y2);// return TH2
                        }
                        else
                        {
                            if (a[X2+i, Y2] < 0)
                            {
                                dad[X2+i, Y2] = -1;
                                numtwo.Add(new Point(X2 + i, Y2));
                            }
                            else
                                huong2 = false;
                        }
                    }
                    else
                    {
                        huong2 = false;
                    }
                }
                #endregion

                #region Huong 3(di len)
                if (huong3 == true)
                {
                    if (Y2 - i >= 0)
                    {
                        if (dad[X2, Y2 - i] > 0)
                        {
                            return TH2(X1, Y1, X2, Y2, X2, Y2-i);
                        }
                        else
                        {
                            if (a[X2, Y2 - i] < 0)
                            {
                                dad[X2, Y2 - i] = -1;
                                numtwo.Add(new Point(X2, Y2-i));
                            }
                            else
                                huong3 = false;
                        }
                    }
                    else
                    {
                        huong3 = false;
                    }
                }
                #endregion

                #region Huong 4(di xuong)
                if (huong4 == true)
                {
                    if (Y2 + i <= 9)
                    {
                        if (dad[X2, Y2 + 1] > 0)
                        {
                            return TH2(X1, Y1, X2, Y2, X2, Y2 + i);
                        }
                        else
                        {
                            if (a[X2, Y2 + i] < 0)
                            {
                                dad[X2, Y2 + i] = -1;
                                numtwo.Add(new Point(X2, Y2+i));
                            }
                            else
                                huong4 = false;
                        }
                    }
                    else
                    {
                        huong4 = false;
                    }
                }
                #endregion
                if (huong1==false &&huong2==false && huong3==false && huong4==false)
                {
                     break;
                }
            }
            #endregion


            #region Xet cho truong hop con lai
            foreach (Point p1 in numone)
            {
                foreach (Point p2 in numtwo)
                {
                    if (p1.X == p2.X)
                    {
                        int small = p1.Y < p2.Y ? p1.Y : p2.Y;
                        int big = p1.Y > p2.Y ? p1.Y : p2.Y;
                        bool tmp = true;
                        for (int i = small; i <= big; i++)
                        {
                            if (a[p1.X, i] != -1)
                            {
                                tmp = false;
                                break;
                            }
                        }
                        if (tmp == true)
                        {
                            //MessageBox.Show("OK X" + p1.ToString() + p2.ToString());
                            return TH3(X1, Y1, X2, Y2, p1.X, p1.Y, p2.X, p2.Y);
                        }
                    }
                    else if (p1.Y == p2.Y)
                    {
                        int small = p1.X < p2.X ? p1.X : p2.X;
                        int big = p1.X > p2.X ? p1.X : p2.X;
                        bool tmp = true;
                        for (int i = small; i <= big; i++)
                        {
                            if (a[i, p1.Y] != -1)
                            {
                                tmp = false;
                                break;
                            }
                        }
                        if (tmp == true)
                        {
                            //MessageBox.Show("OK Y" + p1.ToString() + p2.ToString());
                            return TH3(X1, Y1, X2, Y2, p1.X, p1.Y, p2.X, p2.Y);
                        }
                    }
                }
            }
            #endregion
            
            return null;
        }
        #region TH1
        public ArrayList TH1(int X1, int Y1, int X2, int Y2)
        {
            ArrayList a = new ArrayList();
            if (X1 == X2)
            {
                if (Y1 < Y2)
                {
                    for (int i = Y1; i <= Y2; i++)
                    {
                        a.Add(new Point(X1, i));
                    }
                }
                else
                {
                    for (int i = Y1; i >= Y2; i--)
                    {
                        a.Add(new Point(X1, i));
                    }
                }
            }
            else
            {
                if (X1 < X2)
                {
                    for (int i = X1; i <= X2; i++)
                    {
                        a.Add(new Point(i, Y1));
                    }
                }
                else
                {
                    for (int i = X1; i >= X2; i--)
                    {
                        a.Add(new Point(i, Y1));
                    }
                }
            }
            //MessageBox.Show(a.Count.ToString()); ;
            return a;
        }
        #endregion

        #region TH2
        public ArrayList TH2(int X1, int Y1, int X2, int Y2,int tmpX,int tmpY)
        {
            ArrayList a = TH1(X1, Y1, tmpX, tmpY);
            ArrayList b = TH1(tmpX, tmpY, X2, Y2);
            ArrayList c=new ArrayList();
            for (int i = 0; i < a.Count; i++)
            {
                Point p=(Point)a[i];
                c.Add(p);
            }
            if (b.Count>0)
            {
                for (int i = 1; i < b.Count; i++)
                {
                    Point p = (Point)b[i];
                    c.Add(p);
                }
            }
            return c;
        }
        #endregion

        #region TH3
        public ArrayList TH3(int X1, int Y1, int X2, int Y2, int tmpX1, int tmpY1,int tmpX2,int tmpY2)
        {
            ArrayList a1 = TH1(X1, Y1, tmpX1, tmpY1);
            ArrayList a2 = TH1(tmpX1, tmpY1,tmpX2, tmpY2);
            ArrayList a3 = TH1(tmpX2, tmpY2, X2, Y2);
            ArrayList b = new ArrayList();
            for (int i = 0; i < a1.Count; i++)
            {
                Point p = (Point)a1[i];
                b.Add(p);
            }
            if (a2.Count > 1)
            {
                for (int i = 1; i < a2.Count-1; i++)
                {
                    Point p = (Point)a2[i];
                    b.Add(p);
                }
            }
            for (int i = 0; i < a3.Count; i++)
            {
                Point p = (Point)a3[i];
                b.Add(p);
            }
            return b;
        }
        #endregion
        #endregion
        
        public void HavePoint(int x1,int y1,int x2,int y2)
        {
            
            Matrix[x1+1, y1+1] = Matrix[x2+1, y2+1] = -1;
            RemainPokemon -= 2;
            LawLevel(Level, x1, y1, x2, y2);
            
        }
        public void RandomAgain()
        {
            LimitPokemon.Clear();
            for (int y = 1; y < 9; y++)
            {
                for (int x = 1; x < 17; x++)
                {
                    if (Matrix[x, y] != -1)
                        LimitPokemon.Add(Matrix[x, y]);
                }
            }
            if (LimitPokemon.Count == 128)
            {
                NewGame();
            }
            else
            {
                Clear();
                // open wide

                Random rand_ID = new Random();
                Random rand_Location = new Random();
                String str = "";
                while (true)
                {
                    int tmp_ID = rand_ID.Next(LimitPokemon.Count);
                    int tmp_Location = rand_Location.Next(AutoRand.Count);

                    Matrix[AutoRand[tmp_Location] % 16 + 1, AutoRand[tmp_Location] / 16 + 1] = LimitPokemon[tmp_ID];
                    LimitPokemon.RemoveAt(tmp_ID);
                    AutoRand.RemoveAt(tmp_Location);
                    // find Couple
                    tmp_ID = rand_ID.Next(LimitPokemon.Count);
                    tmp_Location = rand_Location.Next(AutoRand.Count);
                    Matrix[AutoRand[tmp_Location] % 16 + 1, AutoRand[tmp_Location] / 16 + 1] = LimitPokemon[tmp_ID];
                    AutoRand.RemoveAt(tmp_Location);
                    LimitPokemon.RemoveAt(tmp_ID);
                    str += LimitPokemon.Count.ToString() + "  ";
                    if (LimitPokemon.Count == 0)
                        break;
                }
                RepairRandomLevel();
            }
            //MessageBox.Show(str);
        }
        public List<Point> FindCouple()
        {
            for (int i = 0; i < Information.PokemonNumber; i++)
            {
                List<Point> l = Couple(colect(i));
                if (l != null)
                    return l;
            }
            return null;
        }
        private List<Point> colect(int i)
        {
            List<Point> a = new List<Point>();
            for (int y = 1; y < 9; y++)
            {
                for (int x = 1; x < 17; x++)
                {
                    if (Matrix[x, y] == i)
                    {
                        a.Add(new Point(x, y));
                    }
                }
            }
            if (a.Count == 0)
                return null;
            return a;
        }
        public List<Point> Couple(List<Point> a)
        {
            if (a == null || a.Count == 0)
                return null;
            List<Point> l = new List<Point>();
            for (int i = 0; i < a.Count-1; i++)
            {
                for (int j = i + 1; j < a.Count; j++)
                {
                    if (min_way(Matrix, a[i].X-1, a[i].Y-1, a[j].X-1, a[j].Y-1) != null)
                    {
                        l.Add(a[i]);
                        l.Add(a[j]);
                        return l;
                    }
                }
            }
            return null;
        }
        public void RepairRandomLevel()
        {
            if (Level == 1)
                return;
            else if (Level == 2)
            {
                for(int y=1;y<8;y++)
                    for (int x = 0; x < 16; x++)
                    {
                        if(Matrix[x+1,y+1]==-1)
                            LevelDown(x, y, 0, 7);
                    }
            }
            else if (Level == 3)
            {
                for (int y = 6; y >= 0; y--)
                    for (int x = 0; x < 16; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelUp(x, y, 0, 7);
                    }
            }
            else if (Level == 4)
            {
                for(int y=0;y<8;y++)
                    for (int x = 14; x >=0; x--)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelLeft(x, y, 0, 15);
                    }
            }
            else if (Level == 5)
            {
                for (int y = 0; y < 8; y++)
                {
                    for (int x = 1; x < 16; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelRight(x, y, 0, 15);
                    }
                }
            }
            else if (Level == 6)
            {
                for (int y = 0; y < 8; y++)
                {

                    for (int x = 6; x >= 0; x--)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelLeft(x, y, 0, 7);
                    }
                    for (int x = 9; x < 16; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                        {
                            LevelRight(x, y, 8, 15);
                        }
                    }
                }
            }
            else if (Level == 7)
            {

                for (int x = 0; x < 16; x++)
                {
                    for (int y = 2; y >= 0; y--)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelUp(x, y, 0, 3);
                    }
                    for (int y = 5; y < 8; y++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelDown(x, y, 4, 7);
                    }
                }
            }
            else if (Level == 8)
            {
                for (int y = 0; y < 8; y++)
                {

                    for (int x = 14; x >= 8; x--)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelLeft(x, y, 8, 15);
                    }
                    for (int x = 1; x <= 7; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                        {
                            LevelRight(x, y, 0, 7);
                        }
                    }
                }
            }
            else if (Level == 9)
            {

                for (int x = 0; x < 16; x++)
                {
                    for (int y = 6; y >= 4; y--)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelUp(x, y, 4, 7);
                    }
                    for (int y = 1; y <= 3; y++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelDown(x, y, 0, 3);
                    }
                }
            }
            else if (Level == 10)
            {
                for (int y = 1; y < 8; y++)
                    for (int x = 0; x < 8; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelDown(x, y, 0, 7);
                    }
                for (int y = 6; y >= 0; y--)
                    for (int x = 8; x < 16; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelUp(x, y, 0, 7);
                    }
            }
            else if (Level == 11)
            {
                for (int y = 6; y >= 0; y--)
                    for (int x = 0; x < 8; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelUp(x, y, 0, 7);
                    }
                for (int y = 1; y < 8; y++) 
                    for (int x = 8; x < 16; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelDown(x, y, 0, 7);
                    }
            }
            else if (Level == 12)
            {
                for (int y = 0; y < 4; y++)
                    for (int x = 14; x >= 0; x--)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelLeft(x, y, 0, 15);
                    }
                for (int y = 4; y < 8; y++)
                {
                    for (int x = 1; x < 16; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelRight(x, y, 0, 15);
                    }
                }
            }
            else if (Level == 13)
            {
                for (int y = 0; y < 4; y++)
                    for (int x = 1; x < 16; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelRight(x, y, 0, 15);
                    }
                for (int y = 4; y < 8; y++)
                {
                    for (int x = 14; x >= 0; x--)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                            LevelLeft(x, y, 0, 15);
                    }
                }
            }
            else if (Level == 14)
            {
                for (int y = 0; y < 8; y++)
                {
                    for (int x = 1; x < 16; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                        {
                            LevelRight(x, y, y * 2 + 1, 15);
                        }
                    }
                    for (int x = 14; x >= 0; x--)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                        {
                            LevelLeft(x, y, 0, y * 2);
                        }
                    }
                }
            }
            else if (Level == 15)
            {
                for (int y = 0; y < 8; y++)
                {
                    for (int x = 1; x < 16; x++)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                        {
                            LevelRight(x, y, 15 - y * 2, 15);
                        }
                    }
                    for (int x = 14; x >= 0; x--)
                    {
                        if (Matrix[x + 1, y + 1] == -1)
                        {
                            LevelLeft(x, y, 0, 15 - y * 2 - 1);
                        }
                    }
                }
            }
                /*String str = "";
                for(int y=0;y<10;y++)
                    for (int x = 0; x < 18; x++)
                    {
                        str += "";
                    }*/
            
        }
        public void LawLevel(int i,int x1,int y1,int x2,int y2)
        {
            if (Level == 1)
            {
                Matrix[x1 + 1, y1 + 1] = Matrix[x2 + 1, y2 + 1] = -1;
            }
            else if (Level == 2)
            {
                if (y1 <= y2)
                {
                    LevelDown(x1, y1, 0, 7);
                    LevelDown(x2, y2, 0, 7);
                }
                else
                {
                    LevelDown(x2, y2, 0, 7);
                    LevelDown(x1, y1, 0, 7);
                }
            }
            else if (Level == 3)
            {
                if (y1 <= y2)
                {
                    LevelUp(x2, y2, 0, 7);
                    LevelUp(x1, y1, 0, 7);
                }
                else
                {
                    LevelUp(x1, y1, 0, 7);
                    LevelUp(x2, y2, 0, 7);
                }
            }
            else if (Level == 4)
            {
                if (x1 <= x2)
                {
                    LevelLeft(x2, y2, 0, 15);
                    LevelLeft(x1, y1, 0, 15);
                }
                else
                {
                    LevelLeft(x1, y1, 0, 15);
                    LevelLeft(x2, y2, 0, 15);
                }
            }

            else if (Level == 5)
            {
                if (x1 >= x2)
                {
                    LevelRight(x2, y2, 0, 15);
                    LevelRight(x1, y1, 0, 15);
                }
                else
                {
                    LevelRight(x1, y1, 0, 15);
                    LevelRight(x2, y2, 0, 15);
                }
            }
            else if (Level == 6)
            {
                if (x1 >= x2)
                {
                    LevelRight(x2, y2, 8, 15);
                    LevelRight(x1, y1, 8, 15);
                }
                else
                {
                    LevelRight(x1, y1, 8, 15);
                    LevelRight(x2, y2, 8, 15);
                }
                if (x1 <= x2)
                {
                    LevelLeft(x2, y2, 0, 7);
                    LevelLeft(x1, y1, 0, 7);
                }
                else
                {
                    LevelLeft(x1, y1, 0, 7);
                    LevelLeft(x2, y2, 0, 7);
                }
            }
            else if (Level == 7)
            {
                if (y1 <= y2)
                {
                    LevelDown(x1, y1, 4, 7);
                    LevelDown(x2, y2, 4, 7);
                }
                else
                {
                    LevelDown(x2, y2, 4, 7);
                    LevelDown(x1, y1, 4, 7);
                }
                if (y1 <= y2)
                {
                    LevelUp(x2, y2, 0, 3);
                    LevelUp(x1, y1, 0, 3);
                }
                else
                {
                    LevelUp(x1, y1, 0, 3);
                    LevelUp(x2, y2, 0, 3);
                }
            }
            else if (Level == 8)
            {
                if (x1 >= x2)
                {
                    LevelRight(x2, y2, 0, 7);
                    LevelRight(x1, y1, 0, 7);
                }
                else
                {
                    LevelRight(x1, y1, 0, 7);
                    LevelRight(x2, y2, 0, 7);
                }
                if (x1 <= x2)
                {
                    LevelLeft(x2, y2, 8, 15);
                    LevelLeft(x1, y1, 8, 15);
                }
                else
                {
                    LevelLeft(x1, y1, 8, 15);
                    LevelLeft(x2, y2, 8, 15);
                }
            }
            else if (Level == 9)
            {
                if (y1 <= y2)
                {
                    LevelDown(x1, y1, 0, 3);
                    LevelDown(x2, y2, 0, 3);
                }
                else
                {
                    LevelDown(x2, y2, 0, 3);
                    LevelDown(x1, y1, 0, 3);
                }
                if (y1 <= y2)
                {
                    LevelUp(x2, y2, 4, 7);
                    LevelUp(x1, y1, 4, 7);
                }
                else
                {
                    LevelUp(x1, y1, 4, 7);
                    LevelUp(x2, y2, 4, 7);
                }
            }
            else if (Level == 10)
            {
                if (y1 <= y2)
                {
                    if(x1>=0&&x1<8)
                        LevelDown(x1, y1, 0, 7);
                    if (x2 >= 0 && x2 < 8)
                        LevelDown(x2, y2, 0, 7);
                }
                else
                {
                    if (x2 >= 0 && x2 < 8)
                        LevelDown(x2, y2, 0, 7);
                    if (x1 >= 0 && x1 < 8)
                        LevelDown(x1, y1, 0, 7);
                }
                if (y1 <= y2)
                {
                    if(x2>7&&x2<16)
                        LevelUp(x2, y2, 0, 7);
                    if (x1 > 7 && x1 < 16)
                        LevelUp(x1, y1, 0, 7);
                }
                else
                {
                    if (x1 > 7 && x1 < 16)
                        LevelUp(x1, y1, 0, 7);
                    if (x2 > 7 && x2 < 16)
                        LevelUp(x2, y2, 0, 7);
                }
            }
            else if (Level == 11)
            {
                if (y1 <= y2)
                {
                    if (x1 > 7 && x1 < 16)
                        LevelDown(x1, y1, 0, 7);
                    if (x2 >7 && x2 < 16)
                        LevelDown(x2, y2, 0, 7);
                }
                else
                {
                    if (x2 >7 && x2 < 16)
                        LevelDown(x2, y2, 0, 7);
                    if (x1 >7 && x1 < 16)
                        LevelDown(x1, y1, 0, 7);
                }
                if (y1 <= y2)
                {
                    if (x2 >=0 && x2 < 8)
                        LevelUp(x2, y2, 0, 7);
                    if (x1 >= 0 && x1 < 8)
                        LevelUp(x1, y1, 0, 7);
                }
                else
                {
                    if (x1 >=0 && x1 < 8)
                        LevelUp(x1, y1, 0, 7);
                    if (x2 >= 0 && x2 < 8)
                        LevelUp(x2, y2, 0, 7);
                }
            }
            else if (Level == 12)
            {
                if (x1 <= x2)
                {
                    if(y2>=0&&y2<4)
                        LevelLeft(x2, y2, 0, 15);
                    if (y1 >= 0 && y1 < 4)
                        LevelLeft(x1, y1, 0, 15);
                }
                else
                {
                    if (y1 >= 0 && y1 < 4)
                        LevelLeft(x1, y1, 0, 15);
                    if (y2 >= 0 && y2 < 4)
                        LevelLeft(x2, y2, 0, 15);
                }
                if (x1 >= x2)
                {
                    if(y2>3&&y2<8)
                        LevelRight(x2, y2, 0, 15);
                    if (y1 > 3 && y1 < 8)
                    LevelRight(x1, y1, 0, 15);
                }
                else
                {
                    if (y1 > 3 && y1 < 8)
                        LevelRight(x1, y1, 0, 15);
                    if (y2 > 3 && y2 < 8)
                        LevelRight(x2, y2, 0, 15);
                }
            }
            else if (Level == 13)
            {
                if (x1 <= x2)
                {
                    if (y2 >3 && y2 < 8)
                        LevelLeft(x2, y2, 0, 15);
                    if (y1 >3 && y1 < 8)
                        LevelLeft(x1, y1, 0, 15);
                }
                else
                {
                    if (y1 >3 && y1 < 8)
                        LevelLeft(x1, y1, 0, 15);
                    if (y2 >3 && y2 < 8)
                        LevelLeft(x2, y2, 0, 15);
                }
                if (x1 >= x2)
                {
                    if (y2 >= 0 && y2 < 4)
                        LevelRight(x2, y2, 0, 15);
                    if (y1 >=0 && y1 < 4)
                        LevelRight(x1, y1, 0, 15);
                }
                else
                {
                    if (y1 >= 0 && y1 < 4)
                        LevelRight(x1, y1, 0, 15);
                    if (y2 >=0 && y2 < 4)
                        LevelRight(x2, y2, 0, 15);
                }
            }
            else if (Level == 14)
            {
                if (x1 <= x2)
                {
                        LevelLeft(x2, y2, 0, y2*2);
                        LevelLeft(x1, y1, 0, y1*2);
                }
                else
                {
                        LevelLeft(x1, y1, 0, y1*2);
                        LevelLeft(x2, y2, 0, y2*2);
                }
                if (x1 >= x2)
                {
                        LevelRight(x2, y2, y2 * 2+1, 15);
                        LevelRight(x1, y1, y1*2+1, 15);
                }
                else
                {
                        LevelRight(x1, y1, y1*2+1,15 );
                        LevelRight(x2, y2, y2 * 2+1, 15);
                }
               
            }
            else if (Level == 15)
            {
                if (x1 <= x2)
                {
                    LevelLeft(x2, y2, 0,15-y2 * 2-1);
                    LevelLeft(x1, y1, 0, 15-y1 * 2-1);
                }
                else
                {
                    LevelLeft(x1, y1, 0, 15-y1 * 2-1);
                    LevelLeft(x2, y2, 0, 15-y2 * 2-1);
                }
                if (x1 >= x2)
                {
                    LevelRight(x2, y2, 15-y2 * 2 , 15);
                    LevelRight(x1, y1, 15-y1 * 2 , 15);
                }
                else
                {
                    LevelRight(x1, y1, 15-y1 * 2 , 15);
                    LevelRight(x2, y2, 15-y2 * 2, 15);
                }

            }

        }
        private void LevelDown(int x1, int y1, int ymin, int ymax)
        {
            int y;
            if (y1 >= ymin && y1 <= ymax)
            {
                for (y = y1 + 1; y > ymin+1; y--)
                {
                    Matrix[x1 + 1, y] = Matrix[x1 + 1, y - 1];
                }
                Matrix[x1 + 1, ymin+1] = -1;
            }
        }
        private void LevelUp(int x1, int y1, int ymin, int ymax)
        {
            int y;
            if (y1 >= ymin && y1 <= ymax)
            {
                for (y = y1 + 1; y < ymax+1; y++)
                {
                    Matrix[x1 + 1, y] = Matrix[x1 + 1, y + 1];
                }
                Matrix[x1 + 1, ymax+1] = -1;
            }
            
            //MessageBox.Show(y.ToString());
            
        }
        private void LevelLeft(int x1, int y1, int xmin, int xmax)
        {
            int x;
            if (x1 >= xmin && x1 <= xmax)
            {
                for (x = x1 + 1; x < xmax+1; x++)
                {
                    Matrix[x, y1+1] = Matrix[x+1, y1+1];
                }
                Matrix[x,y1+1 ] = -1;
            }
            //MessageBox.Show(y.ToString());
        }
        private void LevelRight(int x1, int y1, int xmin, int xmax)
        {
            int x;
            if (x1 >= xmin && x1 <= xmax)
            {
                for (x = x1 + 1; x > xmin + 1; x--)
                {
                    Matrix[x, y1+1] = Matrix[x-1, y1+1];
                }
                Matrix[x, y1+1] = -1;
            }
        }
        public void ComeBackLastStep(int[,] m)
        {

        }
        
    }
}
