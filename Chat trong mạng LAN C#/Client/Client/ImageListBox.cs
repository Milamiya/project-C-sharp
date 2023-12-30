using System;
using System.Windows.Forms;
using System.Drawing;

namespace Client
{
    public class ImageListBox : ListBox
    {
        private ImageList _myImageList;
        public ImageList ImageList
        {
            get { return _myImageList; }
            set { _myImageList = value; }
        }
        public ImageListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }

        public ImageListBox(ImageList imgList)
        {
            _myImageList = imgList;
            this.DrawMode = DrawMode.OwnerDrawFixed;
        }

        public void SetTextColor(int index, Color color)
        {
            if (index != -1)
            {
                ImageListBoxItem item = (ImageListBoxItem)Items[index];
                item.TextColor = color;
                Refresh();
            }
        }

        public void SetImageIndex(int index, int imgIndex)
        {
            if (index != -1)
            {
                ImageListBoxItem item = (ImageListBoxItem)Items[index];
                item.ImageIndex = imgIndex;
                Refresh();
            }
        }

        protected override void OnDrawItem(System.Windows.Forms.DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            ImageListBoxItem item;
            Rectangle bounds = e.Bounds;
            try
            {
                item = (ImageListBoxItem)Items[e.Index];
                if (item.ImageIndex != -1)
                {

                    Size imageSize = _myImageList.ImageSize;
                    _myImageList.Draw(e.Graphics, bounds.Left, bounds.Top, item.ImageIndex);
                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(item.TextColor),
                        bounds.Left + imageSize.Width, bounds.Top);
                }
                else
                {
                    e.Graphics.DrawString(item.Text, e.Font, new SolidBrush(item.TextColor),
                    bounds.Left, bounds.Top);
                }
            }
            catch
            {
            }
            base.OnDrawItem(e);
        }
    }//End of ImageListBox class
    public class ImageListBoxItem
    {
        private string _myText;
        private int _myImageIndex;
        private Color _myTextColor;
        // properties 
        public string Text
        {
            get { return _myText; }
            set { _myText = value; }
        }
        public int ImageIndex
        {
            get { return _myImageIndex; }
            set { _myImageIndex = value; }
        }
        public Color TextColor
        {
            get { return _myTextColor; }
            set { _myTextColor = value; }
        }
        //constructor

        public ImageListBoxItem(string text, int index, Color color)
        {
            _myText = text;
            _myTextColor = color;
            _myImageIndex = index;
        }
        public ImageListBoxItem(string text) : this(text, -1, Color.Black) { }
        public ImageListBoxItem() : this("") { }
        public override string ToString()
        {
            return _myText;
        }
    }//End of ImageListBoxItem class
}
