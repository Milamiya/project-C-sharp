using System;
using System.Windows.Forms;
using System.Drawing;

namespace Server
{
    public class MultilineListBox : ListBox
    {
        TextBox tbox = new TextBox();
        public MultilineListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.ScrollAlwaysVisible = true;
            tbox.Multiline = true;
            tbox.Hide();
            Controls.Add(tbox);
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            if (Site != null)
                return;
            if (e.Index > -1)
            {
                string s = Items[e.Index].ToString();
                SizeF sf = e.Graphics.MeasureString(s, Font, Width);
                int htex = (s.Length <= Width) ? 2 : 12;
                e.ItemHeight = (int)sf.Height + htex;
                e.ItemWidth = Width;
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (Site != null)
                return;

            if (e.Index > -1)
            {
                try
                {
                    MultilineListBoxItem item = new MultilineListBoxItem();
                    item = (MultilineListBoxItem)Items[e.Index];
                    if ((e.State & DrawItemState.Focus) == 0)
                    {
                        e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                        e.Graphics.DrawString(item.Text, Font, new SolidBrush(item.TextColor),
                            e.Bounds);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(new SolidBrush(SystemColors.HighlightText), e.Bounds);
                        e.Graphics.DrawString(item.Text, Font, new SolidBrush(item.TextColor),
                            e.Bounds);
                    }
                }
                catch
                {
                    e.Graphics.FillRectangle(new SolidBrush(SystemColors.Window), e.Bounds);
                    e.Graphics.DrawString(Text, Font, new SolidBrush(Color.Black),
                        e.Bounds);
                }
            }
        }
    }

    public class MultilineListBoxItem
    {
        private string _myText;
        private Color _myTextColor;
        // properties 

        public string Text
        {
            get { return _myText; }
            set { _myText = value; }
        }
        public Color TextColor
        {
            get { return _myTextColor; }
            set { _myTextColor = value; }
        }
        //constructor

        public MultilineListBoxItem(string text, Color color)
        {
            _myText = text;
            _myTextColor = color;
        }
        public MultilineListBoxItem(string text) : this(text, Color.Black) { }
        public MultilineListBoxItem() : this("", Color.Black) { }
        public override string ToString()
        {
            return _myText;
        }
    }//End of ListBoxItem class
}

