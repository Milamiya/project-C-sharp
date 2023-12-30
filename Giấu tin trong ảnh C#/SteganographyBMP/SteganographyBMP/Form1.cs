using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SteganographyBMP
{    
    public partial class Form1 : Form
    {
        private string inPath1;       //duong dan toi file anh can giau
        
        private string inPath2;       // duong dan toi file anh can giai nen
        

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            this.Dispose();
        }

        private void FitPicture(Image image,PictureBox frame,GroupBox box)
        {
            box.Width = image.Width <512 ? image.Width : 512;
            frame.Width = image.Width<512 ? image.Width : 512;
            box.Height = image.Height<512 ? image.Height : 512;
            frame.Height = image.Height<512 ? image.Height : 512 ;
        }
        private void openImageToHidingToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            OpenFileDialog openFileDialog1=new OpenFileDialog();
            openFileDialog1.Title = "Chose an Bitmap Image To Hiding";
            openFileDialog1.Filter = "Bitmap Image(*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inPath1 = openFileDialog1.FileName; // lay ra duong dan cua file vua mo
            }
            else
            {
                inPath1 = "";
            }
            Bitmap oldBitmap = new Bitmap(inPath1);            
            FitPicture(oldBitmap,pictureBox1,groupBox1);
            pictureBox1.Image = oldBitmap;            
        }

        private byte[] AddMessLengthToAhead(byte[] message)
        {
            int messLen = message.Length;   // do dai cua thong diep
            byte[] byteLen = BitConverter.GetBytes(messLen);    // dua do dai cua thong diep thanh mang cac byte
            // thuc ra do dai cua mang byteLen la 4 (du de bieu dien 1 so nguyen 32bit)
            byte[] newMess = new byte[messLen + byteLen.Length];    // thong diep moi sau khi da them do dai vao dau (la mang cac byte)
            // dua do dai thong diep ve dau
            for (int i = 0; i < byteLen.Length; i++)
                newMess[i] = byteLen[i];
            for (int i = 0; i < messLen; i++)
                newMess[i + byteLen.Length] = message[i];
            return newMess;
        }

        //Tao 1 file Stego tu dau vao
        public void CreateStegoFile(string inPath1, string message, string password, string inPath2)
        {
            // kiem tra dau vao xem da hop le hay chua
            if (inPath1 == "") 
                throw new Exception("Ban chua chon anh de giau tin");
            if (inPath2 == "")
                throw new Exception("Ban chua chon noi de luu anh");
            if (message == "")
                throw new Exception("Ban chua nhap thong diep de giau");
            if (password == "")
                throw new Exception("Ban chua nhap mat khau");
            // Mo file dau vao
            FileStream inStream = new FileStream(inPath1, FileMode.Open, FileAccess.Read);
            
            // kiem tra xem co phai anh bitmap 24 bits khong
            char b = (char)inStream.ReadByte();
            char m = (char)inStream.ReadByte();
            if (!(b == 'B' && m == 'M'))
                throw new Exception("Khong phai la anh bitmap");
            // kiem tra xem co phai la anh 24 bit hay k
            inStream.Seek(28,0);    // dua con tro ve vi tri byte thu 28
            byte[] temp=new byte[2];
            inStream.Read(temp,0,2);    // so bit/1pixel duoc luu bang 2 byte
            Int16 nBit= BitConverter.ToInt16(temp,0);       // chuyen mang byte temp[] ve so nguyen 16 bit
            if (nBit != 24)
                throw new Exception("Day khong phai la anh 24 bit");
            // Doc 54 byte phan header roi dua vao trong outStream
            int offset=54;
            inStream.Seek(0, 0);
            byte[] header = new byte[offset];
            inStream.Read(header, 0, offset);

            //viet 54 byte nay vao trong file stego ( file dau ra)
            FileStream outStream = new FileStream(inPath2, FileMode.Create, FileAccess.Write);
            outStream.Write(header, 0, offset);
            
            // ma hoa thong diep va mat khau thanh 1 thong diep duy nhat
            UnicodeEncoding unicode = new UnicodeEncoding();
            byte[] newMessageByte = AddMessLengthToAhead(unicode.GetBytes(message));// them 4 byte do dai cua message vao dau cua thong diep
            // thuc hien tron
            newMessageByte = CryptoHelper.Encrypt(newMessageByte, password);

            // thuc hien giau thong diep nay vao trong anh
            inStream.Seek(offset, 0);    // dua con tro ve noi bat dau cua Data o vi tri thu 54 (offset=54)
            LSBHelper.Encode(inStream, newMessageByte, outStream);      //thay tung bit cua thong diep vao LSB cua inStream va ghi ra outStream

            inStream.Close(); // dong file anh dau vao
            outStream.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // mo hop thoai de chon noi luu file stegano
            SaveFileDialog saveDialog1 = new SaveFileDialog();
            saveDialog1.Title="Where do you want to save the file?";
            saveDialog1.Filter = "Bitmap (*.bmp)|*.bmp";

            string outPath;
            if (saveDialog1.ShowDialog() == DialogResult.OK)
            {
                outPath = saveDialog1.FileName;         
            }
            else
            {
                outPath = "";
            }
            // tao ra 1 file chua thong diep an
            CreateStegoFile(inPath1, textBox1.Text, textBox2.Text, outPath);
            // dua anh nay len pictureBox
            Bitmap bitmap = new Bitmap(outPath);
            FitPicture(bitmap, pictureBox2, groupBox2);
            pictureBox2.Image = bitmap;
            saveDialog1.Dispose();
        }

        
        private void openImageToExtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Chose an Image To Extract";
            openFileDialog1.Filter = "Bitmap (*.bmp)|*.bmp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                inPath2 = openFileDialog1.FileName;
            }
            else { inPath2 = ""; }
            // load anh len picture box 3
            Bitmap bitmap = new Bitmap(inPath2);
            FitPicture(bitmap,pictureBox3,groupBox3);
            pictureBox3.Image = bitmap;

        }

        private void button3_Click(object sender, EventArgs e)  // thuc hien trich thong tin tu Stego file
        {
            // kiem tra xem dau vao co hop le khong? neu khong tao ra cac exception
            if (inPath2 == "")
                throw new Exception("Ban chua chon file anh de trich thong tin");
            string password = textBox3.Text;
            if (password == "")
                throw new Exception("Ban chua nhap mat khau");
            // kiem tra xem file dau vao co phai la file Bitmap 24 bit khong?
            FileStream inStream = new FileStream(inPath2, FileMode.Open, FileAccess.Read);
            inStream.Seek(0, 0);    // dua con tro ve dau file
            char b = (char)inStream.ReadByte();
            char m = (char)inStream.ReadByte();
            if (!(b == 'B' && m == 'M'))
                throw new Exception("Day khong phai la file Bitmap");
            // kiem tra xem co phai anh bitmap 24 bit khong
            int offset = 28;
            inStream.Seek(offset,0);
            byte[] temp=new byte[2];    // doc vao 2 byte
            inStream.Read(temp,0,2);    // vi tri 28 va 29
            // chuyen temp[] ve so nguyen 16 bit
            Int16 numOfBit = BitConverter.ToInt16(temp, 0);
            if (numOfBit != 24)
                throw new Exception("Khong phai anh 24 bit");
            // bat dau tham nhap vao phan data
            offset = 54;
            inStream.Seek(offset, 0);
            byte[] bLen = new byte[4];  // 4 byte luu tru do dai thong diep
            bLen = LSBHelper.Decode(inStream, 4);   // cho nay khong the dung method FileStream.Read duoc,do 4 byte nay thuc chat la 32 byte trong inStream
            //decrypt 4 byte nay de duoc 4 byte thuc su ban dau (do ca 4 byte nay cung duoc ma hoa boi khoa Key[128])
            bLen = CryptoHelper.Decrypt(bLen, password);
            int length = BitConverter.ToInt32(bLen, 0); // chuyen tu mang byte thanh so nguyen 

            // thuc hien doc ra mang thong diep an (van bi Encrypt)
            inStream.Seek(offset + 4 * 8, 0);       // 32 byte dau tien de luu do dai cua thong diep
            byte[] buffer=new byte[length];         // su dung mang nay de luu tru tam
            try
            {
                buffer = LSBHelper.Decode(inStream, length);
            }
            catch { throw new Exception("Anh nay khong chua thong tin  hoac ban da nhap sai mat khau"); }   // trong qua trinh trich xuat ra thong diep giau ,neu gap 1 ngoai le nao do,coi nhu trich xuat khong thanh cong ( thong thuong ngoai le phat sinh se la khong du bo nho)
            byte[] realHidenMessage = new byte[4 + buffer.Length];
            realHidenMessage = ConcatTwoByteArray(bLen, buffer);   // them 4 byte vao dau de tien cho viec Decrypt
            realHidenMessage = CryptoHelper.Decrypt(realHidenMessage, password);  // bay gio ta da duoc mang thong diep thuc su
            byte[] hidenMessage = new byte[length]; // bay gio ta chi quan tam den phan thong diep
            for (int i = 0; i < length; i++)
                hidenMessage[i] = realHidenMessage[i + 4];
            // chuyen ve dang string
            UnicodeEncoding unicode = new UnicodeEncoding();
            string result = unicode.GetString(hidenMessage);
            textBox4.Text = result; // hien thi ket qua ra textbox

            inStream.Close();  // dong file dau vao
        }

        //noi 2 mang byte lai voi nhau
        private byte[] ConcatTwoByteArray(byte[] arr1, byte[] arr2)
        {
            byte[] retArr = new byte[arr1.Length + arr2.Length];
            // lay mang thu nhat
            for (int i = 0; i < arr1.Length; i++)
                retArr[i] = arr1[i];
            // noi them mang thu 2
            for (int i = 0; i < arr2.Length; i++)
                retArr[i + arr1.Length] = arr2[i];
            return retArr;
        }
    }
}
