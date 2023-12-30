using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QUANLYHOSONHANVIEN.DataLayer;

namespace QUANLYHOSONHANVIEN.Controller
{
    public class CoSoDuLieuCtr
    {
        CoSoDuLieuData data = new CoSoDuLieuData();
        public bool SaoLuuDuLieu(string duongDan)
        {
            return data.SaoLuuDuLieu(duongDan);
        }
        public bool PhucHoiDuLieu(string duongDan)
        {
            return data.PhucHoiDuLieu(duongDan);
        }
    }
}
