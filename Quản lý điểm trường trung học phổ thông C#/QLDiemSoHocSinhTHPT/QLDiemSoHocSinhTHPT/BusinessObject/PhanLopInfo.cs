using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class PhanLopInfo
    {
        #region MaHocSinhLop
        private string m_MaHocSinhLop;

        public string MaHocSinhLop
        {
            get { return m_MaHocSinhLop; }
            set { m_MaHocSinhLop = value; }
        }

        #endregion

        #region MaLop
        private string m_MaLop;

        public string MaLop
        {
            get { return m_MaLop; }
            set { m_MaLop = value; }
        }

        #endregion

        #region MaHocSinh
        private string m_MaHocSinh;

        public string MaHocSinh
        {
            get { return m_MaHocSinh; }
            set { m_MaHocSinh = value; }
        }

        #endregion

        public PhanLopInfo()
        {
            this.MaHocSinhLop = "";
            this.MaLop = "";
            this.MaHocSinh = "";
        }

        public PhanLopInfo(string maHocSinhLop, string maLop, string maHocSinh)
        {
            this.MaHocSinhLop = maHocSinhLop;
            this.MaLop = maLop;
            this.MaHocSinh = maHocSinh;
        }
    }
}
