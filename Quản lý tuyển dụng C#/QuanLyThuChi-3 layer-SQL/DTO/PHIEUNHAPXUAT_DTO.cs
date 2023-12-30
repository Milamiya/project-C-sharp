using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PHIEUNHAPXUAT_DTO
    {
        private string _soPhieu;

        public string SoPhieu
        {
            get { return _soPhieu; }
            set { _soPhieu = value; }
        }
        private string _maNV;

        public string MaNV
        {
            get { return _maNV; }
            set { _maNV = value; }
        }
        private DateTime _ngay;

        public DateTime Ngay
        {
            get { return _ngay; }
            set { _ngay = value; }
        }
        private string _lyDo;

        public string LyDo
        {
            get { return _lyDo; }
            set { _lyDo = value; }
        }
        private Boolean _nhapXuat;

        public Boolean NhapXuat
        {
            get { return _nhapXuat; }
            set { _nhapXuat = value; }
        }
    }
}
