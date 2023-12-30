using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTKHO_DTO
    {
        private string _maKho;

        public string MaKho
        {
            get { return _maKho; }
            set { _maKho = value; }
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
