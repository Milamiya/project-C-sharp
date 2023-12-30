using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace UIT_Pokemon
{
    class ControlRegion
    {
        public static void CreateControl(Control c,Bitmap b)
        {
            if(b==null)
                return;
            c.Size = new Size(b.Width, b.Height);
            if(c is System.Windows.Forms.Panel)
            {
                GraphicsPath gp=CacularBitmap(b);
                c.Region=new Region(gp);
                c.BackgroundImage=b;
            }
            if (c is PictureBox)
            {
                GraphicsPath gp = CacularBitmap(b);
                c.Region = new Region(gp);
                //c.BackgroundImage = b;
            }
            if (c is Button)
            {
                GraphicsPath gp = CacularBitmap(b);
                c.Region = new Region(gp);
                //c.BackgroundImage = b;
            }
        }
        private static GraphicsPath CacularBitmap(Bitmap b)
        {
            Color Transparent=b.GetPixel(0,0);
            GraphicsPath gp=new GraphicsPath();
            for(int i=0;i<b.Height;i++)
            {
                for(int j=0;j<b.Width;j++)
                {
                    int len=0;
                    if(b.GetPixel(j,i)!=Transparent)
                    {
                        for(len=j+1;len<b.Width;len++)
                        {
                            if(b.GetPixel(len,i)==Transparent)
                                break;
                        }
                        gp.AddRectangle(new Rectangle(j, i, len-j, 1));
                        j = len;
                    }
                }
            }
            return gp;
        }
    }
}
