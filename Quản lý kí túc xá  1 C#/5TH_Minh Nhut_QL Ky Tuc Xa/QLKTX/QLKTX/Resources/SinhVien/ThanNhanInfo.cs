using System;
using System.Collections.Generic;
using System.Text;

namespace QLKTX
{
    public class ThanNhanInfo
    {
        private string maKTX;
        private string hoTen;
        private string diaChi;
        private string ngheNghiep;
        private DateTime namSinh;
        private int quanHe;

        public string HoTen
        {
            get { return hoTen; }
            set {hoTen=value;}
        }
        public int QuanHe
        {
            get { return quanHe; }
            set {quanHe=value;}
        }
    }
}
