using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class DichVuBuuChinh_VienThong_InFo
    {
        public DichVuBuuChinh_VienThong_InFo(int MaDichVuBuuChinhVT,string TenDichVuBuuChinhVT)
        {
            MaDichVuBuuChinhVT = M_MaDichVuBuuChinhVT;
            TenDichVuBuuChinhVT = M_TenDichVuBuuChinhVT;
        }
        private int M_MaDichVuBuuChinhVT;

        public int MaDichVuBuuChinhVT
        {
            get { return M_MaDichVuBuuChinhVT; }
            set { M_MaDichVuBuuChinhVT = value; }
        }
        private string M_TenDichVuBuuChinhVT;

        public string TenDichVuBuuChinhVT
        {
            get { return M_TenDichVuBuuChinhVT; }
            set { M_TenDichVuBuuChinhVT = value; }
        }

        private QL_DoanhNghiep_InFo M_Doanhnghiep;
        public QL_DoanhNghiep_InFo Doanhnghiep
        {
            get { return M_Doanhnghiep; }
            set { M_Doanhnghiep = value; }
        }

        public DichVuBuuChinh_VienThong_InFo()
        {
            M_Doanhnghiep = new QL_DoanhNghiep_InFo();
        }
        

    }
}
