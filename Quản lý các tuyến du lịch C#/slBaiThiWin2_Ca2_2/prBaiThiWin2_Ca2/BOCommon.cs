using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace prBaiThiWin2_Ca2
{
    class BOCommon
    {
        DACommon com = new DACommon();
        public DataSet LayBangLoaiPhuongTien()
        {
            return com.LayBang("LoaiPhuongTien");
        }

        public DataSet LayBangTuyenDuLich()
        {
            return com.LayBang("TuyenDuLich");
        }

        public void ThemTuyenDL(string matuyen, string tentuyen, string songaydulich, string phipt, string phiano, string loaipt)
        {
            com.ThemTuyenDL(matuyen, tentuyen, songaydulich, phipt, phiano, loaipt);
        }

        public DataTable LayThongTinTuyenDL(string matuyen)
        {
            return com.LayThongTinTuyenDL(matuyen);
        }
    }
}
