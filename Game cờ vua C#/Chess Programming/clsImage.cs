using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;

namespace Chess_Programming
{
    public class clsImage
    {

        private Image _Avatar;

        public clsImage(Image img)
        {
            this._Avatar = img;
        }
        public clsImage()
        {
            this._Avatar = null;
        }
        public clsImage(Image img,int width,int height)
        {
            this._Avatar = ResizeImage ( img,width ,height) ;
        }

        public byte[] ImageToBytes()
        {
            return this.ImageToByteArray(this._Avatar);
        }

        public void ImageFromBytes(byte[] b)
        {
            this._Avatar = ImageFromByteArray(b);
        }

        public Image Avatar
        {
            get
            {
                return this._Avatar;
            }
            set
            {
                this._Avatar = value;
            }
        }

        private byte[] ImageToByteArray(Image img)
        {
            img.Save("tmp");
            FileStream f = new FileStream("tmp", FileMode.OpenOrCreate);
            byte[] bf = new byte[(int)f.Length];
            f.Read(bf, 0, bf.Length);
            f.Close();
            File.Delete("tmp");
            return bf;
        }

        private Image ImageFromByteArray(byte[] bf)
        {
            FileStream f = new FileStream("tmp", FileMode.OpenOrCreate);
            f.Write(bf, 0, bf.Length);
            Image img = Image.FromStream(f);
            f.Close();
            File.Delete("tmp");
            return img;
        }

        private Image ResizeImage(Image img, int Width, int Height)
        {
            if (img.Width < Width)
            {
                Width = img.Width;
            }
            if (img.Height < Height)
            {
                Height = img.Height;
            }

            Image.GetThumbnailImageAbort callback = null;
            IntPtr callbackdata = new IntPtr();
            img = img.GetThumbnailImage(Width, Height, callback, callbackdata);
            return img;
        }
    }
}
