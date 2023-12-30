using System;
using System.Collections.Generic;
using System.Text;

namespace BaoCaoThongKe.BusinessObject
{
    public class TieuChuanChatLuong_InFo
    {
        public TieuChuanChatLuong_InFo() { }
        public TieuChuanChatLuong_InFo(int MaTieuChuanCL, string TenTieuChuanCL)
        {
            MaTieuChuanCL = M_MaTieuChuanCL;
            TenTieuChuanCL = M_TenTieuChuanCL;

        }
        private int M_MaTieuChuanCL;

        public int MaTieuChuanCL
        {
            get { return M_MaTieuChuanCL; }
            set { M_MaTieuChuanCL = value; }
        }

        private string M_TenTieuChuanCL;

        public string TenTieuChuanCL
        {
            get { return M_TenTieuChuanCL; }
            set { M_TenTieuChuanCL = value; }
        }
	
	
    }
}
