using System;
using System.Windows.Forms;
using System.Drawing;

namespace Client
{
    public delegate bool PreRemoveTab(int indx);
    public class TabControlEx : TabControl
    {
        public TabControlEx()
            : base()
        {
            PreRemoveTabPage = null;
            this.DrawMode = TabDrawMode.OwnerDrawFixed;
        }

        public PreRemoveTab PreRemoveTabPage;

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            Rectangle r = e.Bounds;
            r = GetTabRect(e.Index);            
            r.Offset(1, 4);
            string title = this.TabPages[e.Index].Text;
            if (title != "Server")
            {
                string str;
                if (title.Length > 8)
                {
                    str = title.Substring(0, title.Length - 3);
                    str += "...";
                }
                else
                {
                    str = title;
                }
                Brush b = new SolidBrush(Color.Blue);
                //Font f = new Font(this.Font, FontStyle.Bold);
                Font f = this.Font;
                e.Graphics.DrawString(str, f, b, new PointF(r.X, r.Y));
                r.Offset(r.Width - 10, -3);
                int i = this.Width;
                r.Width = 7;
                r.Height = 7;
                b = new SolidBrush(Color.Gray);
                Pen p = new Pen(b, (float)1.6);
                e.Graphics.DrawLine(p, r.X, r.Y, r.X + r.Width, r.Y + r.Height);
                e.Graphics.DrawLine(p, r.X + r.Width, r.Y, r.X, r.Y + r.Height);
                b = new SolidBrush(Color.Tomato);
                p = new Pen(b, 1);
                e.Graphics.DrawRectangle(p, r.X, r.Y, 7, 7);
            }
            else
            {
                Brush b = new SolidBrush(Color.Blue);
                //Font f = new Font(this.Font,FontStyle.Bold);
                Font f = this.Font;
                e.Graphics.DrawString(title, f, b, new PointF(r.X, r.Y));
            }
        }
        protected override void OnMouseClick(MouseEventArgs e)
        {
            Point p = e.Location;
            for (int i = 0; i < TabCount; i++)
            {
                Rectangle r = GetTabRect(i);
                r.Offset(r.Width - 8, 2);
                r.Width = 7;
                r.Height = 7;
                if (r.Contains(p) && TabPages[i].Text != "Server")
                {
                    CloseTab(i);
                }
            }
        }

        private void CloseTab(int i)
        {
            if (PreRemoveTabPage != null)
            {
                bool closeIt = PreRemoveTabPage(i);
                if (!closeIt)
                    return;
            }
            TabPages.Remove(TabPages[i]);
        }
    }
}
