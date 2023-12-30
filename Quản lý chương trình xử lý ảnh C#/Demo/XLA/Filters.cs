using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace CSharpFilters
{
	public class ConvMatrix
	{
        //tao lop mat na
		public int TopLeft = 0, TopMid = 0, TopRight = 0;
		public int MidLeft = 0, Pixel = 1, MidRight = 0;
		public int BottomLeft = 0, BottomMid = 0, BottomRight = 0;
		public int Factor = 1;
		public int Offset = 0;
		public void SetAll(int nVal)
		{
			TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = nVal;
		}
	}

    //lop bien doi anh
	public class BitmapFilter
	{
        //bien di anh xam
		public static bool GrayScale(Bitmap b)
		{
			// GDI+ still lies to us - the return format is BGR, NOT RGB.
			BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            //dia chi o nho chua diem anh dau tien
			int stride = bmData.Stride;

            //so byte tren 1 hang
			System.IntPtr Scan0 = bmData.Scan0;
            //kiem soat con tro(ma ko an toan)
			unsafe
			{
                //khai bao con tro p co dia chi o scan0
				byte * p = (byte *)(void *)Scan0;
                //ria cua anh, de con tro chay den hang thu 2
				int nOffset = stride - b.Width*3;
                
				byte red, green, blue;
	            //cho chay het 1 cot
				for(int y=0;y<b.Height;++y)
				{
                    //cho theo hang
					for(int x=0; x < b.Width; ++x )
					{
						blue = p[0];
						green = p[1];
						red = p[2];
                        //cong thuc bien doi anh xam
						p[0] = p[1] = p[2] = (byte)(.299 * red + .587 * green + .114 * blue);
                        //sang diem anh ke tiep
						p += 3;
					}
                    //xuong hang ke tiep(ria cua anh)
					p += nOffset;
				}
			}
            //giai phong bien bmData
			b.UnlockBits(bmData);

			return true;
		}

		public static bool Color(Bitmap b, int red, int green, int blue)
		{
			if (red < -255 || red > 255) return false;
			if (green < -255 || green > 255) return false;
			if (blue < -255 || blue > 255) return false;

			// GDI+ still lies to us - the return format is BGR, NOT RGB.
			BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int stride = bmData.Stride;
			System.IntPtr Scan0 = bmData.Scan0;

			unsafe
			{
				byte * p = (byte *)(void *)Scan0;

				int nOffset = stride - b.Width*3;
				int nPixel;

				for(int y=0;y<b.Height;++y)
				{
					for(int x=0; x < b.Width; ++x )
					{
						nPixel = p[2] + red;
						nPixel = Math.Max(nPixel, 0);
						p[2] = (byte)Math.Min(255, nPixel);

						nPixel = p[1] + green;
						nPixel = Math.Max(nPixel, 0);
						p[1] = (byte)Math.Min(255, nPixel);

						nPixel = p[0] + blue;
						nPixel = Math.Max(nPixel, 0);
						p[0] = (byte)Math.Min(255, nPixel);

						p += 3;
					}
					p += nOffset;
				}
			}

			b.UnlockBits(bmData);

			return true;
		}
        //mat na chap 3*3
		public static bool Conv3x3(Bitmap b, ConvMatrix m)
		{
			// Avoid divide by zero errors
			if (0 == m.Factor) return false;

			Bitmap bSrc = (Bitmap)b.Clone(); 

			// GDI+ still lies to us - the return format is BGR, NOT RGB.
			BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			int stride = bmData.Stride;
			int stride2 = stride * 2;
			System.IntPtr Scan0 = bmData.Scan0;
			System.IntPtr SrcScan0 = bmSrc.Scan0;

			unsafe
			{
				byte * p = (byte *)(void *)Scan0;
				byte * pSrc = (byte *)(void *)SrcScan0;

				int nOffset = stride + 6 - b.Width*3;
				int nWidth = b.Width - 2;
				int nHeight = b.Height - 2;

				int nPixel;

				for(int y=0;y < nHeight;++y)
				{
					for(int x=0; x < nWidth; ++x )
					{
						nPixel = ( ( ( (pSrc[2] * m.TopLeft) + (pSrc[5] * m.TopMid) + (pSrc[8] * m.TopRight) +
							(pSrc[2 + stride] * m.MidLeft) + (pSrc[5 + stride] * m.Pixel) + (pSrc[8 + stride] * m.MidRight) +
							(pSrc[2 + stride2] * m.BottomLeft) + (pSrc[5 + stride2] * m.BottomMid) + (pSrc[8 + stride2] * m.BottomRight)) / m.Factor) + m.Offset); 

						if (nPixel < 0) nPixel = 0;
						if (nPixel > 255) nPixel = 255;

						p[5 + stride]= (byte)nPixel;

						nPixel = ( ( ( (pSrc[1] * m.TopLeft) + (pSrc[4] * m.TopMid) + (pSrc[7] * m.TopRight) +
							(pSrc[1 + stride] * m.MidLeft) + (pSrc[4 + stride] * m.Pixel) + (pSrc[7 + stride] * m.MidRight) +
							(pSrc[1 + stride2] * m.BottomLeft) + (pSrc[4 + stride2] * m.BottomMid) + (pSrc[7 + stride2] * m.BottomRight)) / m.Factor) + m.Offset); 

						if (nPixel < 0) nPixel = 0;
						if (nPixel > 255) nPixel = 255;
							
						p[4 + stride] = (byte)nPixel;

						nPixel = ( ( ( (pSrc[0] * m.TopLeft) + (pSrc[3] * m.TopMid) + (pSrc[6] * m.TopRight) +
							(pSrc[0 + stride] * m.MidLeft) + (pSrc[3 + stride] * m.Pixel) + (pSrc[6 + stride] * m.MidRight) +
							(pSrc[0 + stride2] * m.BottomLeft) + (pSrc[3 + stride2] * m.BottomMid) + (pSrc[6 + stride2] * m.BottomRight)) / m.Factor) + m.Offset); 

						if (nPixel < 0) nPixel = 0;
						if (nPixel > 255) nPixel = 255;

						p[3 + stride] = (byte)nPixel;

						p += 3;
						pSrc += 3;
					}

					p += nOffset;
					pSrc += nOffset;
				}
			}

			b.UnlockBits(bmData);
			bSrc.UnlockBits(bmSrc);

			return true;
		}
		public static bool EmbossLaplacian(Bitmap b)
		{
			ConvMatrix m = new ConvMatrix();
			m.SetAll(-1);
			m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 0;
			m.Pixel = 4;
			m.Offset = 127;

			return  BitmapFilter.Conv3x3(b, m);
		}	
		public static bool EdgeDetectQuick(Bitmap b)
		{
			ConvMatrix m = new ConvMatrix();
			m.TopLeft = m.TopMid = m.TopRight = -1;
			m.MidLeft = m.Pixel = m.MidRight = 0;
			m.BottomLeft = m.BottomMid = m.BottomRight = 1;
		
			m.Offset = 127;

			return  BitmapFilter.Conv3x3(b, m);
		}
	}
}
