using System;
using System.Collections.Generic;
using System.Linq;
using QuanLyDaoTao.DataAccess;
using QuanLyDaoTao.Utilities;
using System.Data.Linq;
using System.Data;

namespace QuanLyDaoTao.Business
{
    class PhanCongBUS
    {
        private static dbQuanLyDaoTaoDataContextDataContext db = StaticClass.db;

        public static void Them(PhanCong pc)
        {
            try
            {
                db.PhanCongs.InsertOnSubmit(pc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string SinhMa()
        {
            try
            {
                string id = "", newId;
                var x = db.PhanCongs.OrderByDescending(pc => pc.MaPC).Take(1);
                foreach (var i in x)
                {
                    id = i.MaPC;
                }
                if (!string.IsNullOrEmpty(id))
                {
                    newId = "PC" + (int.Parse(id.Substring(2)) + 1).ToString("00000");
                    return newId;
                }
                return "PC00001";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ISingleResult<sp_HienThiPhanCongResult> DanhSachTuyChinh()
        {
            try
            {
                return db.sp_HienThiPhanCong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool KiemTraTonTai(PhanCong pc)
        {
            try
            {
                return db.PhanCongs.Any(p => p.MaGV == pc.MaGV && p.MaMH == pc.MaMH
                    && p.MaLop == pc.MaLop && p.HocKy == pc.HocKy && p.NamHoc == pc.NamHoc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Xoa(string maPC)
        {
            try
            {
                db.PhanCongs.DeleteOnSubmit(db.PhanCongs.Single(pc => pc.MaPC == maPC));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable LayDuLieu()
        {
            try
            {
                return (new DataProvider()).GetTable("Select * from PhanCong");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
