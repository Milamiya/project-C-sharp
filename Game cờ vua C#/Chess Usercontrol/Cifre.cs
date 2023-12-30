using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;


namespace DigitalClock
{

    public class CCifre
    {
        Color foreColor = Color.Green;
        public CCifre()
        {
        }
        ~CCifre()
        {
        }

        void ver_line(Rectangle rect, Graphics pdc, bool b)
        {
            int grosime = rect.Width - rect.X;
            int inaltime = rect.Height - rect.Y;

            int dev = grosime / 2;
            int line = -1;
            Color c;
            Color fc;
            if (b)
            {
                c = Color.Black;
                fc = foreColor;
                line = 1;
            }
            else
            {
                c = Color.FromArgb(30, 30, 30); //Gray;
                fc =c;
                line = 0;
            }
            Point[] lp = new Point[6];
            lp[0].X = rect.X + dev;
            lp[0].Y = rect.Y;
            lp[1].X = rect.X + grosime;
            lp[1].Y = rect.Y + dev;
            lp[2].X = rect.X + grosime;
            lp[2].Y = rect.Height - dev;
            lp[3].X = rect.X + dev;
            lp[3].Y = rect.Height;
            lp[4].X = rect.X;
            lp[4].Y = rect.Height - dev;
            lp[5].X = rect.X;
            lp[5].Y = rect.Y + dev;
            pdc.DrawPolygon(new Pen(c, line), lp);
            FillMode newFillMode = FillMode.Winding;
            pdc.FillPolygon(new SolidBrush(fc), lp, newFillMode);
        }

        void hor_line(Rectangle rect, Graphics pdc, bool b)
        {
            int grosime = rect.Height - rect.Y;
            int inaltime = rect.Width - rect.X;
            int dev = grosime / 2;
            int line = -1;
            Color c;
            Color fc;
            if (b)
            {
                c = Color.Black;
                fc = foreColor;
                line = 1;
            }
            else
            {
                c = Color.FromArgb(30, 30, 30); //Gray;
                fc = c;
                line = 0;
            }
            Point[] lp = new Point[7];
            lp[0].X = rect.X;
            lp[0].Y = rect.Y + dev;
            lp[1].X = rect.X + dev;
            lp[1].Y = rect.Y;
            lp[2].X = rect.Width - dev;
            lp[2].Y = rect.Y;
            lp[3].X = rect.Width;
            lp[3].Y = rect.Y + dev;
            lp[4].X = rect.Width - dev;
            lp[4].Y = rect.Height;
            lp[5].X = rect.X + dev;
            lp[5].Y = rect.Height;
            lp[6].X = rect.X;
            lp[6].Y = rect.Y + dev;
            pdc.DrawPolygon(new Pen(c, line), lp);
            FillMode newFillMode = FillMode.Winding;
            pdc.FillPolygon(new SolidBrush(fc), lp, newFillMode);
        }

       

        void deseneaza_cifra(int n, Rectangle rect, Graphics pdc)
        {
            int x = rect.X;
            int x1 = rect.Width;
            int y = rect.Y;
            int y1 = rect.Height;
            //se calculeaza dreptunghiul aferent pentru fiecare din cele 7 segmente
            //segmentele trebuie sa aiba aceeasi grosime pentru a corespunde afisarii corecte
            //~un sfert din latimea cifrei
            int grosime = (x1 - x) / 5;
            //inaltimea pentru segmentele orizontale este jumatate din inaltimea cifrei
            int inaltime = (y1 - y) / 2;
            //lungimea segmentelor orizontale:
            //la sfarsit se scade 4 pentru ca sa se vada diferenta de 2 pixeli dintre segmentele orizonatle
            //si cele verticale
            int lungime = (x1 - x) - grosime - 4;
            switch (n)
            {
                case 8:
                    {
                        hor_line(new Rectangle(x + grosime / 2 + 2, y, x1 - grosime / 2 - 2, y + grosime), pdc, true);//sus
                        ver_line(new Rectangle(x, y + grosime / 2, x + grosime, y + inaltime), pdc, true);//stanga-sus
                        ver_line(new Rectangle(x, y1 - inaltime, x + grosime, y1 - grosime / 2), pdc, true);//stanga-jos
                        hor_line(new Rectangle(x + grosime / 2 + 2, y1 - grosime, x1 - grosime / 2 - 2, y1), pdc, true);//jos
                        ver_line(new Rectangle(x1 - grosime, y + inaltime, x1, y1 - grosime / 2), pdc, true);//dreapta-jos
                        ver_line(new Rectangle(x1 - grosime, y + grosime / 2, x1, y + inaltime), pdc, true);//dreapta-sus
                        hor_line(new Rectangle(x + grosime / 2 + 2, y + inaltime - grosime / 2, x1 - grosime / 2 - 2, y + inaltime + grosime / 2), pdc, true);//mijloc
                        break;
                    }
                case 0:
                    {
                        hor_line(new Rectangle(x + grosime / 2 + 2, y, x1 - grosime / 2 - 2, y + grosime), pdc, true);//sus
                        ver_line(new Rectangle(x, y + grosime / 2, x + grosime, y + inaltime), pdc, true);//stanga-sus
                        ver_line(new Rectangle(x, y1 - inaltime, x + grosime, y1 - grosime / 2), pdc, true);//stanga-jos
                        hor_line(new Rectangle(x + grosime / 2 + 2, y1 - grosime, x1 - grosime / 2 - 2, y1), pdc, true);//jos
                        ver_line(new Rectangle(x1 - grosime, y + inaltime, x1, y1 - grosime / 2), pdc, true);//dreapta-jos
                        ver_line(new Rectangle(x1 - grosime, y + grosime / 2, x1, y + inaltime), pdc, true);//dreapta-sus
                        hor_line(new Rectangle(x + grosime / 2 + 2, y + inaltime - grosime / 2, x1 - grosime / 2 - 2, y + inaltime + grosime / 2), pdc, false);//mijloc
                        break;
                    }
                case 1:
                    {
                        hor_line(new Rectangle(x + grosime / 2 + 2, y, x1 - grosime / 2 - 2, y + grosime), pdc, false);//sus
                        //								 return ;
                        ver_line(new Rectangle(x, y + grosime / 2, x + grosime, y + inaltime), pdc, false);//stanga-sus
                        ver_line(new Rectangle(x, y1 - inaltime, x + grosime, y1 - grosime / 2), pdc, false);//stanga-jos
                        hor_line(new Rectangle(x + grosime / 2 + 2, y1 - grosime, x1 - grosime / 2 - 2, y1), pdc, false);//jos
                        ver_line(new Rectangle(x1 - grosime, y + inaltime, x1, y1 - grosime / 2), pdc, true);//dreapta-jos
                        ver_line(new Rectangle(x1 - grosime, y + grosime / 2, x1, y + inaltime), pdc, true);//dreapta-sus
                        hor_line(new Rectangle(x + grosime / 2 + 2, y + inaltime - grosime / 2, x1 - grosime / 2 - 2, y + inaltime + grosime / 2), pdc, false);//mijloc
                        break;
                    }
                case 2:
                    {
                        hor_line(new Rectangle(x + grosime / 2 + 2, y, x1 - grosime / 2 - 2, y + grosime), pdc, true);//sus
                        ver_line(new Rectangle(x, y + grosime / 2, x + grosime, y + inaltime), pdc, false);//stanga-sus
                        ver_line(new Rectangle(x, y1 - inaltime, x + grosime, y1 - grosime / 2), pdc, true);//stanga-jos
                        hor_line(new Rectangle(x + grosime / 2 + 2, y1 - grosime, x1 - grosime / 2 - 2, y1), pdc, true);//jos
                        ver_line(new Rectangle(x1 - grosime, y + inaltime, x1, y1 - grosime / 2), pdc, false);//dreapta-jos
                        ver_line(new Rectangle(x1 - grosime, y + grosime / 2, x1, y + inaltime), pdc, true);//dreapta-sus
                        hor_line(new Rectangle(x + grosime / 2 + 2, y + inaltime - grosime / 2, x1 - grosime / 2 - 2, y + inaltime + grosime / 2), pdc, true);//mijloc
                        break;
                    }
                case 3:
                    {
                        hor_line(new Rectangle(x + grosime / 2 + 2, y, x1 - grosime / 2 - 2, y + grosime), pdc, true);//sus
                        ver_line(new Rectangle(x, y + grosime / 2, x + grosime, y + inaltime), pdc, false);//stanga-sus
                        ver_line(new Rectangle(x, y1 - inaltime, x + grosime, y1 - grosime / 2), pdc, false);//stanga-jos
                        hor_line(new Rectangle(x + grosime / 2 + 2, y1 - grosime, x1 - grosime / 2 - 2, y1), pdc, true);//jos
                        ver_line(new Rectangle(x1 - grosime, y + inaltime, x1, y1 - grosime / 2), pdc, true);//dreapta-jos
                        ver_line(new Rectangle(x1 - grosime, y + grosime / 2, x1, y + inaltime), pdc, true);//dreapta-sus
                        hor_line(new Rectangle(x + grosime / 2 + 2, y + inaltime - grosime / 2, x1 - grosime / 2 - 2, y + inaltime + grosime / 2), pdc, true);//mijloc
                        break;
                    }
                case 4:
                    {
                        hor_line(new Rectangle(x + grosime / 2 + 2, y, x1 - grosime / 2 - 2, y + grosime), pdc, false);//sus
                        ver_line(new Rectangle(x, y + grosime / 2, x + grosime, y + inaltime), pdc, true);//stanga-sus
                        ver_line(new Rectangle(x, y1 - inaltime, x + grosime, y1 - grosime / 2), pdc, false);//stanga-jos
                        hor_line(new Rectangle(x + grosime / 2 + 2, y1 - grosime, x1 - grosime / 2 - 2, y1), pdc, false);//jos
                        ver_line(new Rectangle(x1 - grosime, y + inaltime, x1, y1 - grosime / 2), pdc, true);//dreapta-jos
                        ver_line(new Rectangle(x1 - grosime, y + grosime / 2, x1, y + inaltime), pdc, true);//dreapta-sus
                        hor_line(new Rectangle(x + grosime / 2 + 2, y + inaltime - grosime / 2, x1 - grosime / 2 - 2, y + inaltime + grosime / 2), pdc, true);//mijloc
                        break;
                    }
                case 5:
                    {
                        hor_line(new Rectangle(x + grosime / 2 + 2, y, x1 - grosime / 2 - 2, y + grosime), pdc, true);//sus
                        ver_line(new Rectangle(x, y + grosime / 2, x + grosime, y + inaltime), pdc, true);//stanga-sus
                        ver_line(new Rectangle(x, y1 - inaltime, x + grosime, y1 - grosime / 2), pdc, false);//stanga-jos
                        hor_line(new Rectangle(x + grosime / 2 + 2, y1 - grosime, x1 - grosime / 2 - 2, y1), pdc, true);//jos
                        ver_line(new Rectangle(x1 - grosime, y + inaltime, x1, y1 - grosime / 2), pdc, true);//dreapta-jos
                        ver_line(new Rectangle(x1 - grosime, y + grosime / 2, x1, y + inaltime), pdc, false);//dreapta-sus
                        hor_line(new Rectangle(x + grosime / 2 + 2, y + inaltime - grosime / 2, x1 - grosime / 2 - 2, y + inaltime + grosime / 2), pdc, true);//mijloc
                        break;
                    }
                case 6:
                    {
                        hor_line(new Rectangle(x + grosime / 2 + 2, y, x1 - grosime / 2 - 2, y + grosime), pdc, true);//sus
                        ver_line(new Rectangle(x, y + grosime / 2, x + grosime, y + inaltime), pdc, true);//stanga-sus
                        ver_line(new Rectangle(x, y1 - inaltime, x + grosime, y1 - grosime / 2), pdc, true);//stanga-jos
                        hor_line(new Rectangle(x + grosime / 2 + 2, y1 - grosime, x1 - grosime / 2 - 2, y1), pdc, true);//jos
                        ver_line(new Rectangle(x1 - grosime, y + inaltime, x1, y1 - grosime / 2), pdc, true);//dreapta-jos
                        ver_line(new Rectangle(x1 - grosime, y + grosime / 2, x1, y + inaltime), pdc, false);//dreapta-sus
                        hor_line(new Rectangle(x + grosime / 2 + 2, y + inaltime - grosime / 2, x1 - grosime / 2 - 2, y + inaltime + grosime / 2), pdc, true);//mijloc
                        break;
                    }
                case 7:
                    {
                        hor_line(new Rectangle(x + grosime / 2 + 2, y, x1 - grosime / 2 - 2, y + grosime), pdc, true);//sus
                        ver_line(new Rectangle(x, y + grosime / 2, x + grosime, y + inaltime), pdc, false);//stanga-sus
                        ver_line(new Rectangle(x, y1 - inaltime, x + grosime, y1 - grosime / 2), pdc, false);//stanga-jos
                        hor_line(new Rectangle(x + grosime / 2 + 2, y1 - grosime, x1 - grosime / 2 - 2, y1), pdc, false);//jos
                        ver_line(new Rectangle(x1 - grosime, y + inaltime, x1, y1 - grosime / 2), pdc, true);//dreapta-jos
                        ver_line(new Rectangle(x1 - grosime, y + grosime / 2, x1, y + inaltime), pdc, true);//dreapta-sus
                        hor_line(new Rectangle(x + grosime / 2 + 2, y + inaltime - grosime / 2, x1 - grosime / 2 - 2, y + inaltime + grosime / 2), pdc, false);//mijloc
                        break;
                    }
                case 9:
                    {
                        hor_line(new Rectangle(x + grosime / 2 + 2, y, x1 - grosime / 2 - 2, y + grosime), pdc, true);//sus
                        ver_line(new Rectangle(x, y + grosime / 2, x + grosime, y + inaltime), pdc, true);//stanga-sus
                        ver_line(new Rectangle(x, y1 - inaltime, x + grosime, y1 - grosime / 2), pdc, false);//stanga-jos
                        hor_line(new Rectangle(x + grosime / 2 + 2, y1 - grosime, x1 - grosime / 2 - 2, y1), pdc, true);//jos
                        ver_line(new Rectangle(x1 - grosime, y + inaltime, x1, y1 - grosime / 2), pdc, true);//dreapta-jos
                        ver_line(new Rectangle(x1 - grosime, y + grosime / 2, x1, y + inaltime), pdc, true);//dreapta-sus
                        hor_line(new Rectangle(x + grosime / 2 + 2, y + inaltime - grosime / 2, x1 - grosime / 2 - 2, y + inaltime + grosime / 2), pdc, true);//mijloc
                        break;
                    }
            }
        }

        
        public void Set_Time(short minute, short second, Rectangle rect, Graphics pdc, Color fc)
        {
            int x = rect.X;
            int x1 = rect.Width;
            int y = rect.Y;
            int y1 = rect.Height;
            int lungime = x1 - x;
            foreColor = fc;
            //spatiul dintre doua unitati de timp este de 7% din lungimea afisajului

            int sM = lungime * 10 / 100;
            //spatiul dintre 2 cifre este de 2%
            int sm = lungime *3/ 100;
            //asta inseamna ca 2 cifre vor ocupa 30% din afisaj => 12% pentru o cifra
            //se citeste timpul
            
            int mm = minute;
            int ss = second;
            //deci, avem 6 cifre care trebuie initializate
            int[] cifra = new int[5];            
            cifra[1] = mm / 10;
            cifra[2] = mm % 10;
            cifra[3] = ss / 10;
            cifra[4] = ss % 10;

            //se calculeaza cele 6 dreptunghiuri in care vor fi desenate cifrele;
            int grosime_cifra = lungime * 20 / 100;
            int sus = (y1 - y) * 4 / 100;
            Rectangle[] dr = new Rectangle[5];
            dr[1].X = sm;
            dr[1].Width = dr[1].X + grosime_cifra;
            dr[1].Y = sus;
            dr[1].Height = y1 - sus;

            dr[2].X = dr[1].Width + sm;
            dr[2].Width = dr[2].X + grosime_cifra;
            dr[2].Y = sus;
            dr[2].Height = y1 - sus;

            dr[3].X = dr[2].Width + sM;
            dr[3].Width = dr[3].X + grosime_cifra;
            dr[3].Y = sus;
            dr[3].Height = y1 - sus;

            dr[4].X = dr[3].Width + sm;
            dr[4].Width = dr[4].X + grosime_cifra;
            dr[4].Y = sus;
            dr[4].Height = y1 - sus;            

            //se afiseaza toate cifrele
            for (int i = 1; i <= 4; i++)
                deseneaza_cifra(cifra[i], dr[i], pdc);
          
        }
    }
}