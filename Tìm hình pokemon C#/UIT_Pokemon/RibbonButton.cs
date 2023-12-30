using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
namespace UIT_Pokemon
{
    class RibbonButton : Button
    {
        private int _radius = 6;
        int _MouseEnter = 0;
        String _Text = "";
        String str = global::UIT_Pokemon.Properties.Resources.button.ToString();
        #region Constructor button ribbon
        public RibbonButton(String str)
        {
            _Text = str;
            ControlRegion.CreateControl(this, global::UIT_Pokemon.Properties.Resources.button);
            this.SetStyle(ControlStyles.Opaque, false);
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.Transparent;
            this.MouseEnter += new EventHandler(RibbonButton_MouseEnter);
            this.MouseLeave += new EventHandler(RibbonButton_MouseLeave);
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UseVisualStyleBackColor = true;
        }
        #endregion
        public void changeText(String str)
        {
            _Text = str;
        }
        #region Mouse Enter
        void RibbonButton_MouseEnter(Object obj, EventArgs e)
        {
            //this.BackgroundImage = (global::FULL_LISTBOX.Properties.Resources.nenribbonbutton);
            this.ForeColor = Color.Crimson;
            _MouseEnter = 40;
            this.Text = _Text;
        }
        #endregion

        #region Mouse Leave
        void RibbonButton_MouseLeave(Object obj, EventArgs e)
        {
            this.BackgroundImage = null;
            this.ForeColor = Color.Black;
            _MouseEnter = 0;
            this.Text = null;
        }
        #endregion

        #region Paint
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.High;
            g.DrawImage(new Bitmap(global::UIT_Pokemon.Properties.Resources.button), 0, 0, this.Width, this.Height);
            Rectangle r = new Rectangle(new Point(-1, -1), new Size(this.Width + _radius, this.Height + _radius));
            //g.RotateTransform(rotate,MatrixOrder.Append);
            DrawImage(g);
            DrawString(g);
        }
        int offsetx = 0, offsety = 0, imageheight = 0, imagewidth = 0;
        public void DrawImage(Graphics gr)
        {
            
            if (this.Image != null)
            {
                Bitmap b = (Bitmap)this.Image;
                b.MakeTransparent(b.GetPixel(0, 0));
                imageheight = this.Height - offsety * 2-8;
                imagewidth = (int)((Convert.ToDouble(imageheight) / this.Image.Height) * this.Image.Width);
                gr.DrawImage(b, new Rectangle((this.Width - imagewidth) / 2-3-_MouseEnter, (this.Height - imageheight)/2, imagewidth, imageheight));
               
            }
        }
        public void DrawString(Graphics gr)
        {
            if (this.Text != "")
            {
                int textwidth = (int)gr.MeasureString(this.Text, this.Font).Width;
                int textheight = (int)gr.MeasureString(this.Text, this.Font).Height;

                Font fontb = new Font(this.Font, FontStyle.Bold);
                string s1 = this.Text;
                LinearGradientBrush br = new LinearGradientBrush(new Point(0, 0), new Point(150, 50), this.ForeColor, this.ForeColor);
                if (this.Text.Contains("+") == false)
                {
                    if (this.ForeColor == Color.Black)
                        gr.DrawString(s1, new Font(this.Font.Name, 10, FontStyle.Regular), br, new PointF(offsetx + imagewidth + 3, this.Height / 2 - this.Font.Size - 2));
                    else
                        gr.DrawString(s1, new Font(this.Font.Name, 12, FontStyle.Regular), br, new PointF(offsetx + imagewidth - 2, this.Height / 2 - this.Font.Size - 2));

                }
                else
                {
                    char[] stringSeparators = new char[] { '+' };
                    String _tmp = this.Text;
                    String[] tmp = _tmp.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);
                    try
                    {
                        gr.DrawString(tmp[0], new Font(this.Font.Name, 10, FontStyle.Regular), br, new PointF(offsetx + imagewidth + 3, this.Height / 2 - this.Font.Size - 8));
                        if (tmp[1].Length > 28)
                        {
                            int tam = tmp[1].Length - 28;
                            tmp[1] = tmp[1].Remove(0, tam);
                            tmp[1] = tmp[1].Insert(0, "...");
                        }
                        gr.DrawString(tmp[1], new Font(this.Font.Name, 8, FontStyle.Regular), br, new PointF(offsetx + imagewidth + 3, this.Height / 2 - this.Font.Size + 10));

                    }
                    catch
                    {
                        // dinh danh khong dung
                        return;
                    }
                }
                fontb.Dispose();

            }
        }
        #endregion
    }

}
