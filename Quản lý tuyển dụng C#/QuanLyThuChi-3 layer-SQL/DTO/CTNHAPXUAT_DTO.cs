using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTNHAPXUAT_DTO
    {
        private string _soPhieu;

        public string SoPhieu
        {
            get { return _soPhieu; }
            set { _soPhieu = value; }
        }
        private string _maHang;

        public string MaHang
        {
            get { return _maHang; }
            set { _maHang = value; }
        }
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
    }
}
