using System;
using System.Collections.Generic;
using System.Text;

namespace QLDiemSoHocSinhTHPT.BusinessObject
{
    public class LoaiNguoiDungInfo
    {
        #region MaLoai
        private int m_MaLoai;

        public int MaLoai
        {
            get { return m_MaLoai; }
            set { m_MaLoai = value; }
        }
        #endregion

        #region TenLoai
        private String m_TenLoai;

        public String TenLoai
        {
            get { return m_TenLoai; }
            set { m_TenLoai = value; }
        }
        #endregion

        public LoaiNguoiDungInfo()
        {
        }

        public LoaiNguoiDungInfo(int maLoai, String tenLoai)
        {
            this.MaLoai = maLoai;
            this.TenLoai = tenLoai;
        }
    }
}
