using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Windows.Forms;

namespace UIT_Pokemon
{
    public class WayEffect:PictureBox
    {
        public Rectangle[,] RUp = new Rectangle[18, 10];
        public Rectangle[,] RDown = new Rectangle[18, 10];
        public Rectangle[,] RRight = new Rectangle[18, 10];
        public Rectangle[,] RLeft = new Rectangle[18, 10];
        Form1 form;
        public WayEffect(Form1 form)
        {
            this.Location = new Point(80, 112);
            this.Size = new Size(1500, 1300);
            //this.BackgroundImage=new Bitmap("C:\\Users\\Acer\\Desktop\\New Folder (4)\\score5.png");
            //this.Image = new Bitmap("C:\\Users\\Acer\\Desktop\\New Folder (4)\\score4.png");
            this.BackColor = Color.DarkGreen;
            this.form = form;
            for (int y = 1; y < 10; y++)
            {
                for (int x = 1; x < 17; x++)
                {
                    RUp[x,y]=new Rectangle((int)(x*66.125)-20,(int)(y*73.5)-60,8,45);
                    RDown[x, y] = new Rectangle((int)(x * 66.125) - 20, (int)(y * 73.5) - 20, 8, 40);
                    RLeft[x, y] = new Rectangle((int)(x * 66.125) - 50, (int)(y * 73.5) - 20, 38, 8);
                    RRight[x, y] = new Rectangle((int)(x * 66.125) - 20, (int)(y * 73.5) - 20, 42, 8);
                }
            }
            for (int x = 0; x < 18; x++)
            {
                RUp[x, 0] = new Rectangle(0, 0, 0, 0);
                RUp[x, 9] = new Rectangle(0, 0, 0, 0);
                RRight[x, 0] = new Rectangle(0, 0, 0, 0);
                RRight[x, 9] = new Rectangle(0, 0, 0, 0);
                //RRight[0, 9] = new Rectangle(0, 0, 0, 0);
            }
            for (int y = 0; y < 10; y++)
            {
                RUp[0, y] = new Rectangle(0, (int)(y * 73.5) - 60, 8, 45);
                RUp[17, y] = new Rectangle(1090, (int)(y * 73.5) - 60, 8, 45);
                RDown[0, y] = new Rectangle(0, (int)(y * 73.5) - 20, 8, 40);
                RDown[17, y] = new Rectangle(1090, (int)(y * 73.5) - 20, 8, 40);
                RRight[0, y] = new Rectangle(0, (int)(y * 73.5) - 20, 28, 8);
                RLeft[17, y] = new Rectangle((int)(17 * 66.125) - 50, (int)(y * 73.5) - 20, 24, 8);
            }
            RDown[0, 0] = new Rectangle(0, 5, 8, 40);
            RRight[0, 0] = new Rectangle(0, 5, 42, 8);
            RDown[17, 0] = new Rectangle(1090, 5, 8, 40);
            RLeft[17, 0] = new Rectangle(1090-20, 5, 25, 8);
            RUp[0, 9] = new Rectangle(0, 600, 8, 18);
            RUp[17, 9] = new Rectangle(1090, 600, 8, 18);
            RRight[0, 9] = new Rectangle(0, 610, 42, 8);
            RLeft[17, 9] = new Rectangle((int)(17 * 66.125) - 50, 610, 24, 8);
            for (int x = 1; x < 17; x++)
            {
                RRight[x, 0] = new Rectangle((int)(x * 66.125) - 20, 5, 42, 8);
                RDown[x, 0] = new Rectangle((int)(x * 66.125)-20, 5, 8, 30);
                RLeft[x, 0] = new Rectangle((int)(x * 66.125) - 50, 5, 38, 8);
                RUp[x, 9] = new Rectangle((int)(x * 66.125) - 20, 600, 8, 18);
                RLeft[x, 9] = new Rectangle((int)(x * 66.125) - 50, 610, 38, 8);
                RRight[x, 9] = new Rectangle((int)(x * 66.125) - 20, 610, 42, 8);
            }
                this.Click += new EventHandler(WayEffect_Click);
                this.Hide();
        }
       
        GraphicsPath AddPiece(Point p1, Point p2,bool i)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.FillMode = FillMode.Winding;
            if (i == false)
            {
                if (p2.X == p1.X)
                {
                    if (p2.Y > p1.Y)
                    {
                        gp.AddRectangle(RUp[p2.X, p2.Y]);
                    }
                    else
                    {
                        gp.AddRectangle(RDown[p2.X, p2.Y]);
                    }
                }
                else
                {
                    if (p2.X > p1.X)
                    {
                        gp.AddRectangle(RLeft[p2.X, p2.Y]);
                    }
                    else
                    {
                        gp.AddRectangle(RRight[p2.X, p2.Y]);
                    }
                }
            }
            else
            {
                if (p2.X == p1.X)
                {
                    if (p2.Y > p1.Y)
                    {
                        gp.AddRectangle(new Rectangle(RUp[p2.X, p2.Y].X, RUp[p2.X, p2.Y].Y-RUp[p2.X, p2.Y].Height/2+15,RUp[p2.X, p2.Y].Width,RUp[p2.X, p2.Y].Height/2+5));
                        //Point[] p = new Point[] { new Point(RUp[p2.X, p2.Y].X, RUp[p2.X, p2.Y].Y), new Point(RUp[p2.X, p2.Y].X + 4, RUp[p2.X, p2.Y].Y + 10), new Point(RUp[p2.X, p2.Y].X + RUp[p2.X, p2.Y].Width, RUp[p2.X, p2.Y].Y), new Point(RUp[p2.X, p2.Y].X, RUp[p2.X, p2.Y].Y)};
                        //gp.AddArc(new Rectangle(RUp[p2.X, p2.Y].X-2, RUp[p2.X, p2.Y].Y, 12, 30), 0, 180);
                        //Point[] p = new Point[] { new Point(RUp[p2.X, p2.Y].X+RUp[p2.X, p2.Y].Height/2, RUp[p2.X, p2.Y].Y ), new Point(RUp[p2.X, p2.Y].X + 4, RUp[p2.X, p2.Y].Y+RUp[p2.X, p2.Y].Height/2 + 20), new Point(RUp[p2.X, p2.Y].X + 8, RUp[p2.X, p2.Y].Y+RUp[p2.X, p2.Y].Height/2), new Point(RUp[p2.X, p2.Y].X, RUp[p2.X, p2.Y].Y+RUp[p2.X, p2.Y].Height/2) };
                        //gp.AddLines(p);
                        gp.AddPie(new Rectangle(RUp[p2.X, p2.Y].X, RUp[p2.X, p2.Y].Y-10, 8, 40), 0, 180);
                    }
                    else
                    {
                        gp.AddRectangle(new Rectangle(RDown[p2.X, p2.Y].X, RDown[p2.X, p2.Y].Y + RDown[p2.X, p2.Y].Height / 2-5, RDown[p2.X, p2.Y].Width, RDown[p2.X, p2.Y].Height/2+10));
                        //Point[] p = new Point[] { new Point(RUp[p2.X, p2.Y].X, RUp[p2.X, p2.Y].Y + RUp[p2.X, p2.Y].Height), new Point(RUp[p2.X, p2.Y].X + 4, RUp[p2.X, p2.Y].Y + RUp[p2.X, p2.Y].Height + 9), new Point(RUp[p2.X, p2.Y].X + 8, RUp[p2.X, p2.Y].Y + RUp[p2.X, p2.Y].Height), new Point(RUp[p2.X, p2.Y].X, RUp[p2.X, p2.Y].Y + RUp[p2.X, p2.Y].Height) };
                        //gp.AddLines(p);
                        gp.AddPie(new Rectangle(RUp[p2.X, p2.Y].X, RUp[p2.X, p2.Y].Y+RUp[p2.X, p2.Y].Height, 8, 40), 180, 180);
                        //Point[] p=new Point[]{new Point(100,100),new Point(100,200),new Point(200,200),new Point(100,100)};
                        //gp.AddLines(p);
                    }
                }
                else
                {
                    if (p2.X > p1.X)
                    {
                        gp.AddRectangle(new Rectangle(RLeft[p2.X, p2.Y].X, RRight[p2.X, p2.Y].Y, RRight[p2.X, p2.Y].Width / 2, RLeft[p2.X, p2.Y].Height));
                        gp.AddPie(new Rectangle(RLeft[p2.X, p2.Y].X+RLeft[p2.X,p2.Y].Width/2-30, RLeft[p2.X, p2.Y].Y, 40, 8), -90, 180);
                    }
                    else
                    {
                        gp.AddRectangle(new Rectangle(RRight[p2.X, p2.Y].X + RRight[p2.X, p2.Y].Width / 2+10, RRight[p2.X, p2.Y].Y, RRight[p2.X, p2.Y].Width / 2-10, RRight[p2.X, p2.Y].Height));
                        gp.AddPie(new Rectangle(RRight[p2.X, p2.Y].X + RRight[p2.X, p2.Y].Width/2, RRight[p2.X, p2.Y].Y, 40, 8), 90, 180);
                       
                        
                    }
                }
            }
            return gp;

        }
        public void Create_way(ArrayList a)
        {
            GraphicsPath gp = new GraphicsPath();
            
            if (a.Count == 2)
            {
                Point p1 = (Point)a[0];
                Point p2 = (Point)a[1];
                Point pLeft1=new Point(p1.X-1,p1.Y);
                Point pLeft2=new Point(p2.X-1,p2.Y);
                Point pRight1=new Point(p1.X+1,p1.Y);
                Point pRight2=new Point(p2.X+1,p2.Y);
                Point pUp1=new Point(p1.X,p1.Y-1);
                Point pUp2=new Point(p2.X,p2.Y-1);
                Point pDown1=new Point(p1.X,p1.Y+1);
                Point pDown2=new Point(p2.X,p2.Y+1);
                if (form.argument.Matrix[pLeft1.X, pLeft1.Y] == -1 && form.argument.Matrix[pLeft2.X, pLeft2.Y] == -1)
                {
                    a.Clear();
                    a.Add(p1);
                    a.Add(pLeft1);
                    a.Add(pLeft2);
                    a.Add(p2);
                }
                else if (form.argument.Matrix[pRight1.X, pRight1.Y] == -1 && form.argument.Matrix[pRight2.X, pRight2.Y] == -1)
                {
                    a.Clear();
                    a.Add(p1);
                    a.Add(pRight1);
                    a.Add(pRight2);
                    a.Add(p2);
                }
                else if (form.argument.Matrix[pUp1.X, pUp1.Y] == -1 && form.argument.Matrix[pUp2.X, pUp2.Y] == -1)
                {
                    a.Clear();
                    a.Add(p1);
                    a.Add(pUp1);
                    a.Add(pUp2);
                    a.Add(p2);
                }
                else if (form.argument.Matrix[pDown1.X, pDown1.Y] == -1 && form.argument.Matrix[pDown2.X, pDown2.Y] == -1)
                {
                    a.Clear();
                    a.Add(p1);
                    a.Add(pDown1);
                    a.Add(pDown2);
                    a.Add(p2);
                }
            }
            Point[] point = new Point[a.Count];
            for (int i = 0; i < a.Count; i++)
            {
                point[i] = (Point)a[i];
            }
            gp.AddPath(AddPiece(point[1], point[0],true), true);
            gp.AddPath(AddPiece(point[point.Length - 2], point[point.Length - 1],true), true);
            for (int i = 1; i < a.Count - 1; i++)
            {

                Point p1 = (Point)a[i - 1];
                Point p2 = (Point)a[i];
                Point p3 = (Point)a[i + 1];
                gp.AddPath(AddPiece(p1, p2,false), true);
                gp.AddPath(AddPiece(p3, p2,false), true);
            }
            gp.FillMode = FillMode.Winding;
            this.Region = new Region(gp);
            this.Show();
        }
        private void WayEffect_Click(Object obj,EventArgs e)
        {
            this.Hide();
        }
        //public Rectangle Rdoc=new Rectangle(10,10)
     
    }
}
